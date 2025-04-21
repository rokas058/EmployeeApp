# 📁 EmployeeApp – Project Setup Guide

This project uses a **PostgreSQL** database and `Entity Framework Core` for data migrations. Everything is automated using PowerShell scripts for easy setup.

---

## ⚙️ How to Set Up the Project

Follow the steps below to initialize the PostgreSQL database, apply Entity Framework migrations, and verify the setup.

---

### ✅ Step-by-Step Instructions

1. **Navigate to the project folder** (replace `yourPath` with the actual path to your solution):

    ```powershell
    cd 'yourPath/EmployeeApp/EmployeeApp'
    ```

2. **Run the database setup script** to configure environment variables and start the PostgreSQL container:

    ```powershell
    ./setUpDatabase.ps1
    ```
    
3. **Run the migration script** to generate and apply the initial database schema:

    ```powershell
    ./migrateData.ps1
    ```

4. **Run the verification script** to confirm that everything is working:

    ```powershell
    ./verifySubmission.ps1
    ```
---

## 🛠️ Requirements

To use this setup, make sure the following tools are installed on your machine:

- [x] **Docker** (for running PostgreSQL)
- [x] **.NET SDK 6.0 
- [x] **PowerShell** (Windows or PowerShell Core on macOS/Linux)

---
## 💡
