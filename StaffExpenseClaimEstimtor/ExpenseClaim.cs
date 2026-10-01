using System;

namespace StaffExpenseClaimEstimator
{
    public class ExpenseClaim
    {
        public string StaffName { get; set; } = "";

        public DateTime ExpenseDate { get; set; }

        public string Category { get; set; } = "";

        public decimal Kilometres { get; set; }

        public decimal ExpenseAmount { get; set; }

        public string Description { get; set; } = "";

        public decimal EstimatedReimbursement { get; set; }
    }
}