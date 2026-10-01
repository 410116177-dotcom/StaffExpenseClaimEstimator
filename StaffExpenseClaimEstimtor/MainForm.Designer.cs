using System.Drawing;
using System.Windows.Forms;

namespace StaffExpenseClaimEstimator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblStaffName = new Label();
            txtStaffName = new TextBox();
            lblExpenseDate = new Label();
            dtpExpenseDate = new DateTimePicker();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblKilometres = new Label();
            txtKilometres = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            grpSummary = new GroupBox();
            lblSummary = new Label();
            lblEstimatedTitle = new Label();
            lblEstimate = new Label();
            lblWarning = new Label();

            grpSummary.SuspendLayout();
            SuspendLayout();

            // lblStaffName
            lblStaffName.AutoSize = true;
            lblStaffName.Location = new Point(20, 30);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(82, 20);
            lblStaffName.TabIndex = 0;
            lblStaffName.Text = "Staff Name";

            // txtStaffName
            txtStaffName.Location = new Point(180, 27);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(440, 27);
            txtStaffName.TabIndex = 1;

            // lblExpenseDate
            lblExpenseDate.AutoSize = true;
            lblExpenseDate.Location = new Point(20, 75);
            lblExpenseDate.Name = "lblExpenseDate";
            lblExpenseDate.Size = new Size(98, 20);
            lblExpenseDate.TabIndex = 2;
            lblExpenseDate.Text = "Expense Date";

            // dtpExpenseDate
            dtpExpenseDate.Format =
                DateTimePickerFormat.Short;
            dtpExpenseDate.Location =
                new Point(180, 72);
            dtpExpenseDate.Name = "dtpExpenseDate";
            dtpExpenseDate.Size = new Size(250, 27);
            dtpExpenseDate.TabIndex = 3;

            // lblCategory
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 120);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(127, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Expense Category";

            // cmbCategory
            cmbCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location =
                new Point(180, 117);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(250, 28);
            cmbCategory.TabIndex = 5;
            cmbCategory.SelectedIndexChanged +=
                cmbCategory_SelectedIndexChanged;

            // lblKilometres
            lblKilometres.AutoSize = true;
            lblKilometres.Location =
                new Point(20, 165);
            lblKilometres.Name = "lblKilometres";
            lblKilometres.Size = new Size(144, 20);
            lblKilometres.TabIndex = 6;
            lblKilometres.Text =
                "Kilometres Travelled";

            // txtKilometres
            txtKilometres.Location =
                new Point(180, 162);
            txtKilometres.Name = "txtKilometres";
            txtKilometres.Size = new Size(250, 27);
            txtKilometres.TabIndex = 7;

            // lblAmount
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 210);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(120, 20);
            lblAmount.TabIndex = 8;
            lblAmount.Text = "Expense Amount";

            // txtAmount
            txtAmount.Location = new Point(180, 207);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 27);
            txtAmount.TabIndex = 9;

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Location =
                new Point(20, 255);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";

            // txtDescription
            txtDescription.Location =
                new Point(180, 252);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars =
                ScrollBars.Vertical;
            txtDescription.Size = new Size(440, 100);
            txtDescription.TabIndex = 11;

            // btnCalculate
            btnCalculate.Location =
                new Point(180, 375);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(170, 35);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate Estimate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click +=
                btnCalculate_Click;

            // btnClear
            btnClear.Location = new Point(450, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 35);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // grpSummary
            grpSummary.Controls.Add(lblWarning);
            grpSummary.Controls.Add(lblEstimate);
            grpSummary.Controls.Add(lblEstimatedTitle);
            grpSummary.Controls.Add(lblSummary);
            grpSummary.Location = new Point(20, 435);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(740, 210);
            grpSummary.TabIndex = 14;
            grpSummary.TabStop = false;
            grpSummary.Text = "Claim Summary";

            // lblSummary
            lblSummary.Location = new Point(15, 28);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(705, 105);
            lblSummary.TabIndex = 0;

            // lblEstimatedTitle
            lblEstimatedTitle.AutoSize = true;
            lblEstimatedTitle.Location =
                new Point(15, 140);
            lblEstimatedTitle.Name =
                "lblEstimatedTitle";
            lblEstimatedTitle.Size =
                new Size(186, 20);
            lblEstimatedTitle.TabIndex = 1;
            lblEstimatedTitle.Text =
                "Estimated Reimbursement:";

            // lblEstimate
            lblEstimate.AutoSize = true;
            lblEstimate.Font = new Font(
                "Segoe UI",
                12F,
                FontStyle.Bold,
                GraphicsUnit.Point);
            lblEstimate.Location =
                new Point(220, 133);
            lblEstimate.Name = "lblEstimate";
            lblEstimate.Size = new Size(65, 28);
            lblEstimate.TabIndex = 2;
            lblEstimate.Text = "$0.00";

            // lblWarning
            lblWarning.ForeColor =
                Color.OrangeRed;
            lblWarning.Location =
                new Point(15, 172);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(705, 25);
            lblWarning.TabIndex = 3;

            // MainForm
            AutoScaleDimensions =
                new SizeF(8F, 20F);
            AutoScaleMode =
                AutoScaleMode.Font;
            ClientSize = new Size(785, 670);

            Controls.Add(grpSummary);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtKilometres);
            Controls.Add(lblKilometres);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(dtpExpenseDate);
            Controls.Add(lblExpenseDate);
            Controls.Add(txtStaffName);
            Controls.Add(lblStaffName);

            Name = "MainForm";
            StartPosition =
                FormStartPosition.CenterScreen;
            Text = "Staff Expense Claim Estimator";

            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStaffName = null!;
        private TextBox txtStaffName = null!;
        private Label lblExpenseDate = null!;
        private DateTimePicker dtpExpenseDate = null!;
        private Label lblCategory = null!;
        private ComboBox cmbCategory = null!;
        private Label lblKilometres = null!;
        private TextBox txtKilometres = null!;
        private Label lblAmount = null!;
        private TextBox txtAmount = null!;
        private Label lblDescription = null!;
        private TextBox txtDescription = null!;
        private Button btnCalculate = null!;
        private Button btnClear = null!;
        private GroupBox grpSummary = null!;
        private Label lblSummary = null!;
        private Label lblEstimatedTitle = null!;
        private Label lblEstimate = null!;
        private Label lblWarning = null!;
    }
}