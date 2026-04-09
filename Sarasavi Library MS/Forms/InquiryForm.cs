using Sarasavi_Library_MS.DTO;
using Sarasavi_Library_MS.Service;
using Sarasavi_Library_MS.Service.ServiceImpl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sarasavi_Library_MS.Forms
{
    public partial class InquiryForm : Form
    {
        private readonly IInquiryService _inquiryService = new InquiryServiceImpl();
        private Label[] _copyLabels;

        public InquiryForm()
        {
            InitializeComponent();
            SetupCopyLabels();
            SetupEvents();
            ResetUI();
        }

        private void SetupCopyLabels()
        {
            // Map the Labels to Array
            _copyLabels = new Label[] {
                lblCopy1, lblCopy2, lblCopy3, lblCopy4, lblCopy5,
                lblCopy6, lblCopy7, lblCopy8, lblCopy9, lblCopy10
            };
        }

        private void SetupEvents()
        {
            // Safe Subscription Pattern
            btnSearch.Click -= btnSearch_Click;
            btnSearch.Click += btnSearch_Click;

            // Enter key search logic
            txtSearch.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    PerformSearch();
                }
            };
        }

        private void PerformSearch()
        {
            string term = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                lblStatus.Text = "Please enter a search term.";
                lblStatus.ForeColor = Color.OrangeRed;
                lblStatus.Visible = true;
                pnlDetail.Visible = false;
                return;
            }

            try
            {
                var results = _inquiryService.SearchBooks(term);
                if (results != null && results.Count > 0)
                {
                    DisplayInquiryDetails(results.First());
                    pnlDetail.Visible = true;
                    lblStatus.Visible = true;
                    lblStatus.Text = $"Results found: {results.Count}";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    pnlDetail.Visible = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = "No book matches found.";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInquiryDetails(InquiryResultDTO dto)
        {
            // 1. Basic Info
            lblDetailTitle.Text = dto.Title;
            lblDetailAuthor.Text = $"by {dto.Author}  |  Publisher: {dto.Publisher}";
            lblDetailISBN.Text = $"ID: {dto.BookID}  |  ISBN: {dto.ISBN}";

            // 2. Dynamic Status Badge (Ex: "2 Available" or "Not Available")
            if (dto.AvailableCopies > 0)
            {
                lblDetailStatus.Text = $"{dto.AvailableCopies} Available";
                lblDetailStatus.ForeColor = Color.ForestGreen; 
            }
            else
            {
                lblDetailStatus.Text = "Not Available";
                lblDetailStatus.ForeColor = Color.Firebrick;
            }

            // 3. Individual Copy Details Logic

            // Hide All Labels
            foreach (var lbl in _copyLabels) lbl.Visible = false;

            // Load Data (have in Database)
            for (int i = 0; i < dto.CopyList.Count; i++)
            {
                if (i >= _copyLabels.Length) break;

                var copy = dto.CopyList[i];
                var label = _copyLabels[i];

                // Text Format: B00011 - Available
                label.Text = $"{copy.CopyID} - {copy.Status}";
                label.Visible = true;

                // Change Colour for Status
                switch (copy.Status)
                {
                    case "Available":
                        label.ForeColor = Color.Green;
                        break;
                    case "Loaned":
                        label.ForeColor = Color.Red;
                        break;
                    case "Reserved":
                        label.ForeColor = Color.Orange;
                        break;
                    default:
                        label.ForeColor = Color.Gray;
                        break;
                }
            }
        }

        private void ResetUI()
        {
            pnlDetail.Visible = false;
            lblStatus.Visible = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e) => PerformSearch();
    }
}