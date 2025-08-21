# Staff Scheduling System (FrmNobetListesi)

[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![SQL Server](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)](https://www.microsoft.com/en-us/sql-server)

Desktop application for automated staff duty scheduling in banking IT operations. Built during internship at financial technology company serving major banks.

## Business Context

Developed for a financial IT services company managing duty schedules between:
- Bank-side on-call personnel (bi-weekly rotation)
- IT company support staff (bi-weekly rotation)

Previously managed manually, this system automates the entire scheduling process with email notifications.

## Features

### Automated Scheduling
- Bi-weekly duty rotation system
- Automatic staff rotation (top person moves to bottom)
- Email notifications to assigned personnel
- No manual intervention required

### Staff Management
- Add/remove staff members
- Maintain duty roster
- Track rotation history
- Role-based assignments

### Technical Implementation
- Layered architecture pattern
- Entity Framework ORM
- MSSQL database integration
- Desktop WinForms interface

## Tech Stack

- **C# .NET Framework** - Core development platform
- **Entity Framework 6.4.4** - Object-relational mapping
- **Microsoft SQL Server** - Database management
- **Windows Forms** - Desktop UI framework
- **Dapper 2.0.123** - Micro-ORM for performance-critical queries

## Architecture
FrmNobetListesi/
├── FRMNobetListesi/          # Presentation Layer (WinForms)
├── NobetListesi.Interface/   # Contract definitions
├── NobetListesi.Service/     # Business logic layer
└── packages/                 # NuGet dependencies

### Layered Architecture
- **Presentation Layer**: Windows Forms UI
- **Service Layer**: Business logic and rules
- **Interface Layer**: Contracts and abstractions
- **Data Layer**: Entity Framework models and repositories

## Installation & Setup

### Prerequisites
- .NET Framework 4.7.2 or higher
- Microsoft SQL Server (LocalDB or full instance)
- Visual Studio 2019 or later

### Database Setup
1. Update connection string in app.config
2. Run Entity Framework migrations
3. Seed initial staff data

### Running the Application
```bash
# Open in Visual Studio
# Build solution
# Set FRMNobetListesi as startup project
# Run (F5)
Business Logic
Rotation Algorithm

Current duty holder moves to bottom of list
Next person in queue becomes active
Automatic email sent to new duty holder
Schedule updates bi-weekly

Email Integration

SMTP configuration for notifications
Automated duty assignment emails
Schedule change confirmations
System status updates

Banking Industry Context
This system addresses real operational needs in financial IT:

24/7 Support Requirements: Banks need constant technical support
Compliance: Automated scheduling ensures coverage consistency
Risk Management: Eliminates human error in duty assignments
Operational Efficiency: Reduces administrative overhead

Performance Features

Efficient database queries with Dapper
Minimal resource usage for desktop deployment
Fast startup and operation
Reliable email delivery system

Security Considerations

SQL injection prevention through parameterized queries
Secure email credential storage
Role-based access to configuration
Audit trail for schedule changes

Development Experience
Built during internship at financial technology company:

Real-world banking industry exposure
Enterprise software development practices
Client requirement analysis and implementation
Production deployment experience

Contributing
This is a portfolio project demonstrating enterprise desktop application development for financial services.
License
This project is for portfolio demonstration purposes.
Contact
Cenk Yavuz - Full Stack Developer

Email: cnkyvzz@gmail.com
LinkedIn: linkedin.com/in/yavuzcenk
GitHub: @cnkyvz
