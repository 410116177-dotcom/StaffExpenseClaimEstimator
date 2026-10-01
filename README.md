# Staff Expense Claim Estimator

A beginner-level C# Windows Forms proof-of-concept developed for 2607-5101 Assignment 2.

## Authors

- Uday Sharma
- Gursharan Singh

## Project Purpose

The application allows a staff member to enter basic expense information and receive an estimated reimbursable amount before submitting a formal claim.

The application provides estimation and basic checking only. It does not approve or process expense claims.

## Implemented Features

- Capture the staff name, expense date and description
- Select Mileage, Meal or Parking
- Validate missing and invalid numerical values
- Calculate Mileage reimbursement
- Apply Meal and Parking limits
- Display claim information and the estimated reimbursement
- Display validation errors and limit warnings
- Clear entered information and results

## Business Rules

- Mileage is reimbursed at $0.85 per kilometre
- Kilometres must be greater than zero
- Meal reimbursement is limited to $35.00
- Parking reimbursement is limited to $40.00
- An amount above its limit is capped and produces a warning
- An amount equal to its limit is accepted without a warning
- Reimbursement results are displayed with two decimal places

## Example Results

| Category | Input | Estimated Reimbursement |
|---|---:|---:|
| Mileage | 100 kilometres | $85.00 |
| Meal | $50.00 | $35.00 |
| Parking | $55.00 | $40.00 |

## Technology

- C#
- Windows Forms
- .NET
- Microsoft Visual Studio

## Main Project Files

- `Program.cs` - starts the application
- `MainForm.cs` - manages input, output and button events
- `MainForm.Designer.cs` - contains the Windows Form controls
- `ExpenseClaim.cs` - temporarily holds claim information
- `ExpenseCalculator.cs` - validates values and applies the reimbursement rules

## How to Run the Application

1. Download or clone this repository.
2. Open `StaffExpenseClaimEstimtor.slnx` in Microsoft Visual Studio.
3. Build the solution.
4. Press `F5` or select the Start button.
5. Enter the expense information and select Calculate Estimate.

## Scope

This project is a small logic proof-of-concept. It does not include user accounts, databases, permanent storage, claim histories, approval workflows, receipt uploads, payroll integration, tax calculations or dashboards.
