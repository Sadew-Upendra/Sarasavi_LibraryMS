# Sarasavi Library Management System

A comprehensive Windows Forms application for managing library operations including book inventory, user management, loans, and returns.

## Features

### 📚 Book Management
- Register and manage book inventory
- Support for multiple copy types (Borrowable/Reference)
- Track book classifications
- Manage book availability status
- Author, ISBN, publisher information

### 👥 User Management
- Register library members and staff
- Manage user profiles (Name, NIC, Contact, Address)
- Support different user types (Member, Librarian, Admin)
- Auto-generated user IDs and login credentials

### 📋 Loan Management
- Track book loans and returns
- Manage loan duration
- Track user borrowing history
- Monitor overdue books
- Return book processing

### 📊 Inquiry/Search
- Search books by various criteria
- View user borrowing history
- Check book availability
- Generate reports

### 🔐 Authentication
- Secure login system
- User role-based access control
- Auto-generated credentials for new users

## Technology Stack

- **Language**: C# 7.3
- **.NET Framework**: 4.8
- **UI Framework**: Windows Forms (WinForms)
- **Database**: SQL Server (SarasaviLibraryDB)
- **Architecture**: Layered Architecture

## Project Structure

```
Sarasavi Library MS/
├── Forms/                 # WinForms UI components
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   ├── BookForm.cs        # Book CRUD operations
│   ├── UserForm.cs        # User CRUD operations
│   ├── LoanForm.cs
│   ├── InquiryForm.cs
│   └── Profile.cs
├── Service/               # Business logic layer
│   ├── IBookService.cs
│   ├── IUserService.cs
│   ├── ILoanService.cs
│   └── ServiceImpl/       # Service implementations
├── DAO/                   # Data access layer
│   ├── IDAO interfaces
│   └── DAOImpl/           # DAO implementations
├── DTO/                   # Data transfer objects
│   ├── BookDTO.cs
│   ├── UserDTO.cs
│   └── LoanDTO.cs
├── Database/              # Database connection
│   └── DBConnection.cs
└── Resources/             # Images, icons, etc.
```

## Prerequisites

### System Requirements
- Windows 10 or later
- .NET Framework 4.8 installed
- SQL Server 2016 or later

### Software Dependencies
- Visual Studio Community 2019 or later (for development)
- SQL Server Management Studio (for database management)

## Installation & Setup

### 1. Database Setup

1. Open **SQL Server Management Studio**
2. Connect to your SQL Server instance
3. Create a new database named `SarasaviLibraryDB`:
   ```sql
   CREATE DATABASE SarasaviLibraryDB;
   ```
4. Execute the database schema scripts to create tables (schema scripts should be in `Database/` folder)

### 2. Connection String Configuration

Update `App.config` with your SQL Server connection details:

```xml
<connectionStrings>
  <add name="SarasaviDBConnection" 
       connectionString="Data Source=.;Initial Catalog=SarasaviLibraryDB;Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3. Build & Run

1. Open the solution in Visual Studio
2. Restore NuGet packages (if any)
3. Build the solution: `Ctrl + Shift + B`
4. Run the application: `F5`

## Default Login Credentials

- **Username**: admin
- **Password**: admin123

*Note: Change default credentials immediately after first login*

## Usage Guide

### Registration
1. Navigate to User Management → Register New User
2. Fill in required fields (Name, NIC)
3. System generates User ID and temporary password
4. User can login and change password

### Book Registration
1. Navigate to Book Management → Add New Book
2. Enter book details (Title, Author, ISBN, Publisher)
3. Select classification type
4. Specify number of copies
5. Choose copy types (Borrowable/Reference)

### Loan Book
1. Go to Loans → New Loan
2. Select user and book
3. System calculates due date
4. Confirm loan transaction

### Return Book
1. Go to Loans → Return Book
2. Select loan entry
3. Confirm return
4. Check for overdue penalties (if applicable)

## Architecture Overview

### Layered Architecture
The application follows a three-tier architecture:

```
UI Layer (Forms)
      ↓
Service Layer (Business Logic)
      ↓
DAO Layer (Data Access)
      ↓
Database
```

**Benefits:**
- Separation of concerns
- Easy to test and maintain
- Data access logic isolated from business logic
- Reusable services across multiple forms

### DTOs (Data Transfer Objects)
DTOs provide a clean way to transfer data between layers:
- `BookDTO` - Book information
- `UserDTO` - User information
- `LoanDTO` - Loan transaction information

## API Reference

### IBookService
```csharp
bool RegisterBook(BookDTO dto, string[] copyTypes)
bool UpdateBook(BookDTO dto)
bool DeleteBook(string bookId)
List<BookDTO> GetAllBooks()
BookDTO GetBookById(string bookId)
```

### IUserService
```csharp
bool RegisterUser(UserDTO dto)
bool UpdateUser(UserDTO dto)
bool DeleteUser(string userId)
List<UserDTO> GetAllUsers()
UserDTO GetUserById(string userId)
```

### ILoanService
```csharp
bool CreateLoan(LoanDTO dto)
bool ReturnBook(string loanId)
List<LoanDTO> GetUserLoans(string userId)
List<LoanDTO> GetOverdueLoans()
```

## Error Handling

The application includes comprehensive error handling:

- **Validation Errors**: User-friendly messages for invalid input
- **Database Errors**: Logged and displayed with recovery suggestions
- **Connection Errors**: Clear messaging if database is unavailable
- **Business Logic Errors**: Specific messages for business rule violations

## Database Connection Troubleshooting

If you see "Database Connection Failed" message:

1. **Verify SQL Server is running**
   - Open Services → Look for SQL Server (SQLEXPRESS)
   - Start the service if stopped

2. **Check database exists**
   ```sql
   SELECT name FROM sys.databases WHERE name = 'SarasaviLibraryDB'
   ```

3. **Verify connection string**
   - Server name should match your SQL Server instance
   - Database name must be exactly `SarasaviLibraryDB`
   - Check App.config for correct connection string

4. **Test connection manually**
   - Open SQL Server Management Studio
   - Try connecting with the same credentials

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Code Style Guidelines

- Follow C# naming conventions (PascalCase for public members, camelCase for local variables)
- Use meaningful variable and method names
- Add XML documentation comments for public methods
- Keep methods focused and single-responsibility
- Use async/await for long-running operations where applicable

## Known Issues

- None currently documented

## Troubleshooting

### Application won't start
- Verify .NET Framework 4.8 is installed: `dotnet --list-runtimes`
- Check Event Viewer for error details
- Ensure all required assemblies are present

### Data not saving to database
- Verify SQL Server service is running
- Check database connection string in App.config
- Ensure user has write permissions on the database

### Forms not displaying correctly
- Check that all Designer files are in sync with code-behind
- Rebuild the solution: `Ctrl + Shift + B`
- Close and reopen the form designer

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

For issues, feature requests, or questions:
- Create an Issue on GitHub
- Contact the development team

## Authors

- Developed By Sadew Upendra

## Acknowledgments

- Built with Windows Forms and .NET Framework
- Special thanks to the SQL Server community
- Thanks to all contributors and testers

---

**Last Updated**: 2024
**Version**: 1.0.0
