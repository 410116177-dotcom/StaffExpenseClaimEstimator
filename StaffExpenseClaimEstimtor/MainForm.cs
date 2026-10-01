using System;
using System.Drawing;
using System.Windows.Forms;

namespace StaffExpenseClaimEstimator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cmbCategory.Items.Add("Mileage");
            cmbCategory.Items.Add("Meal");
            cmbCategory.Items.Add("Parking");

            cmbCategory.SelectedIndex = -1;

            txtKilometres.Enabled = false;
            txtAmount.Enabled = false;

            lblSummary.Text = "";
            lblEstimate.Text = "$0.00";
            lblWarning.Text = "";
        }

        private void cmbCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            string category =
                cmbCategory.SelectedItem?.ToString() ?? "";

            bool mileageSelected =
                category == "Mileage";

            bool amountSelected =
                category == "Meal" ||
                category == "Parking";

            txtKilometres.Enabled = mileageSelected;
            txtAmount.Enabled = amountSelected;

            if (!mileageSelected)
            {
                txtKilometres.Clear();
            }

            if (!amountSelected)
            {
                txtAmount.Clear();
            }

            ClearOutput();
        }

        private void btnCalculate_Click(
            object sender,
            EventArgs e)
        {
            ClearOutput();

            if (string.IsNullOrWhiteSpace(
                txtStaffName.Text))
            {
                ShowError(
                    "Error: Staff name is required.");

                return;
            }

            string category =
                cmbCategory.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(category))
            {
                ShowError(
                    "Error: Expense category is required.");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtDescription.Text))
            {
                ShowError(
                    "Error: Description is required.");

                return;
            }

            decimal estimate;
            string message;

            if (category == "Mileage")
            {
                estimate =
                    ExpenseCalculator.CalculateMileage(
                        txtKilometres.Text,
                        out message);
            }
            else
            {
                estimate =
                    ExpenseCalculator.ApplyLimits(
                        category,
                        txtAmount.Text,
                        out message);
            }

            if (message.StartsWith("Error"))
            {
                ShowError(message);
                return;
            }

            ExpenseClaim claim = new ExpenseClaim
            {
                StaffName = txtStaffName.Text.Trim(),
                ExpenseDate = dtpExpenseDate.Value.Date,
                Category = category,
                Description = txtDescription.Text.Trim(),
                EstimatedReimbursement = estimate
            };

            if (category == "Mileage")
            {
                claim.Kilometres =
                    decimal.Parse(
                        txtKilometres.Text.Trim());
            }
            else
            {
                claim.ExpenseAmount =
                    decimal.Parse(
                        txtAmount.Text.Trim());
            }

            string inputDetails;

            if (category == "Mileage")
            {
                inputDetails =
                    $"Kilometres: {claim.Kilometres}";
            }
            else
            {
                inputDetails =
                    $"Entered amount: " +
                    $"${claim.ExpenseAmount:F2}";
            }

            lblSummary.Text =
                $"Staff Name: {claim.StaffName}\n" +
                $"Expense Date: " +
                $"{claim.ExpenseDate:dd/MM/yyyy}\n" +
                $"Category: {claim.Category}\n" +
                $"{inputDetails}\n" +
                $"Description: {claim.Description}";

            lblEstimate.Text =
                $"${claim.EstimatedReimbursement:F2}";

            if (!string.IsNullOrWhiteSpace(message) &&
                message != "Success")
            {
                lblWarning.ForeColor =
                    Color.DarkOrange;

                lblWarning.Text = message;
            }
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            txtStaffName.Clear();
            txtKilometres.Clear();
            txtAmount.Clear();
            txtDescription.Clear();

            dtpExpenseDate.Value = DateTime.Today;
            cmbCategory.SelectedIndex = -1;

            txtKilometres.Enabled = false;
            txtAmount.Enabled = false;

            ClearOutput();

            txtStaffName.Focus();
        }

        private void ShowError(string message)
        {
            lblSummary.Text = "";
            lblEstimate.Text = "$0.00";
            lblWarning.ForeColor = Color.Red;
            lblWarning.Text = message;
        }

        private void ClearOutput()
        {
            lblSummary.Text = "";
            lblEstimate.Text = "$0.00";
            lblWarning.Text = "";
        }
    }
}