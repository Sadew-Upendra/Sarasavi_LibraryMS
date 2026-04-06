using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Service;
using Sarasavi_Library_MS.Service.ServiceImpl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Forms
{
    public partial class BookForm : Form
    {
        private readonly IBookService _bookService = new BookServiceImpl();
        private string _selectedBookId = null;
        private ComboBox[] _copyTypeBoxes;
        private Label[] _copyTypeLabels;

        public BookForm()
        {
            InitializeComponent();

            // Map UI arrays
            _copyTypeBoxes = new ComboBox[] {
                cmbCopy1, cmbCopy2, cmbCopy3, cmbCopy4, cmbCopy5,
                cmbCopy6, cmbCopy7, cmbCopy8, cmbCopy9, cmbCopy10
            };
            _copyTypeLabels = new Label[] {
                lblCopy1, lblCopy2, lblCopy3, lblCopy4, lblCopy5,
                lblCopy6, lblCopy7, lblCopy8, lblCopy9, lblCopy10
            };

            SetupEvents();
            LoadBooks();
            ClearForm();
        }

        private void SetupEvents()
        {
            // Use the Safe Subscription pattern (-= then +=)
            dgvBookTable.CellClick -= dgvBookTable_CellClick;
            dgvBookTable.CellClick += dgvBookTable_CellClick;

            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnUpdate.Click -= btnUpdate_Click;
            btnUpdate.Click += btnUpdate_Click;

            btnDelete.Click -= btnDelete_Click;
            btnDelete.Click += btnDelete_Click;

            btnClear.Click -= btnClear_Click;
            btnClear.Click += btnClear_Click;

            // Logic-specific events
            cmbClassification.SelectedIndexChanged -= (s, e) => RefreshGeneratedID();
            cmbClassification.SelectedIndexChanged += (s, e) => RefreshGeneratedID();

            cmbCopies.SelectedIndexChanged -= (s, e) => UpdateCopyTypeVisibility();
            cmbCopies.SelectedIndexChanged += (s, e) => UpdateCopyTypeVisibility();
        }

        private void LoadBooks()
        {
            try
            {
                var books = _bookService.GetAllBooks();
                dgvBookTable.DataSource = null;
                dgvBookTable.DataSource = books;

                if (dgvBookTable.Columns.Count > 0)
                {
                    ConfigureGridColumns();
                }

                dgvBookTable.ClearSelection();
                if (dgvBookTable.CurrentCell != null) dgvBookTable.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBookTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvBookTable.Rows[e.RowIndex];
            _selectedBookId = row.Cells["BookID"].Value?.ToString();

            if (string.IsNullOrEmpty(_selectedBookId)) return;

            var book = _bookService.GetBookById(_selectedBookId);
            if (book != null)
            {
                PopulateFields(book);
                SetFormMode(isEditing: true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            char classification = cmbClassification.Text[0];
            string nextId = _bookService.GenerateNextBookId(classification);

            int count = GetCopyCount();
            var copyTypes = new string[count];
            for (int i = 0; i < count; i++)
                copyTypes[i] = _copyTypeBoxes[i].SelectedItem?.ToString() ?? "Borrowable";

            var dto = BuildDTOFromForm();
            dto.BookID = nextId;

            try
            {
                if (_bookService.RegisterBook(dto, copyTypes))
                {
                    MessageBox.Show(
                        $"✓ Book Registered Successfully!\n\nBook ID: {nextId}\nTitle: {dto.Title}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedBookId)) return;
            if (!ValidateInputs()) return;

            var dto = BuildDTOFromForm();
            dto.BookID = _selectedBookId;

            try
            {
                if (_bookService.UpdateBook(dto))
                {
                    MessageBox.Show("✓ Book updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedBookId)) return;

            var confirm = MessageBox.Show(
                $"⚠ Delete this book and all its copies?\n\nID: {_selectedBookId}",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (_bookService.DeleteBook(_selectedBookId))
                {
                    MessageBox.Show("✓ Book deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deletion Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetUI()
        {
            ClearForm();
            LoadBooks();
        }

        private void ClearForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtISBN.Clear();
            _selectedBookId = null;

            if (cmbClassification.Items.Count > 0) cmbClassification.SelectedIndex = 0;
            if (cmbCopies.Items.Count > 0) cmbCopies.SelectedIndex = 0;

            foreach (var cmb in _copyTypeBoxes) cmb.SelectedIndex = 0;

            dgvBookTable.ClearSelection();
            if (dgvBookTable.CurrentCell != null) dgvBookTable.CurrentCell = null;

            UpdateCopyTypeVisibility();
            SetFormMode(isEditing: false);
        }

        private void SetFormMode(bool isEditing)
        {
            btnSave.Enabled = !isEditing;
            btnUpdate.Enabled = isEditing;
            btnDelete.Enabled = isEditing;

            // In Book Registration, Classification usually cannot change during Edit if ID depends on it
            cmbClassification.Enabled = !isEditing;

            this.Text = isEditing ? "Book Management (Editing Mode)" : "Book Management (Registration Mode)";
        }

        private void PopulateFields(BookDTO book)
        {
            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtPublisher.Text = book.Publisher;
            txtISBN.Text = book.ISBN;
            cmbClassification.Text = book.Classification;
            cmbCopies.Text = book.TotalCopies.ToString();

            // Logic to fetch and set Copy Types would go here if your service supports it
        }

        private BookDTO BuildDTOFromForm() => new BookDTO
        {
            Classification = cmbClassification.Text.Substring(0, 1),
            Title = txtTitle.Text.Trim(),
            Author = txtAuthor.Text.Trim(),
            Publisher = txtPublisher.Text.Trim(),
            ISBN = txtISBN.Text.Trim()
        };

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Book Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Author Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return false;
            }
            return true;
        }

        private void UpdateCopyTypeVisibility()
        {
            int count = GetCopyCount();
            for (int i = 0; i < _copyTypeBoxes.Length; i++)
            {
                bool visible = i < count;
                _copyTypeBoxes[i].Visible = visible;
                _copyTypeLabels[i].Visible = visible;
                if (!visible) _copyTypeBoxes[i].SelectedIndex = 0;
            }
        }

        private int GetCopyCount()
        {
            if (int.TryParse(cmbCopies.Text, out int count))
            {
                return Math.Max(1, Math.Min(10, count));
            }
            return 1;
        }

        private void ConfigureGridColumns()
        {
            SetColumnHeader("BookID", "Book ID");
            HideColumn("Classification");
            SetColumnHeader("Title", "Book Title");
            SetColumnHeader("Author", "Author");
            SetColumnHeader("TotalCopies", "Copies");
            HideColumn("ISBN");
            HideColumn("AvailableCopies");
        }

        private void RefreshGeneratedID() { /* Optional: Update a label with the next ID */ }
        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
        private void SetColumnHeader(string n, string h) { if (dgvBookTable.Columns.Contains(n)) dgvBookTable.Columns[n].HeaderText = h; }
        private void HideColumn(string n) { if (dgvBookTable.Columns.Contains(n)) dgvBookTable.Columns[n].Visible = false; }

    }
}