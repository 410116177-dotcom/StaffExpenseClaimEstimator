using System;

namespace StaffExpenseClaimEstimator
{
    public static class ExpenseCalculator
    {
        private const decimal MileageRate = 0.85m;
        private const decimal MealLimit = 35.00m;
        private const decimal ParkingLimit = 40.00m;

        public static decimal CalculateMileage(
            string kilometreText,
            out string message)
        {
            kilometreText = kilometreText.Trim();

            if (string.IsNullOrWhiteSpace(kilometreText))
            {
                message = "Error: Kilometres are required.";
                return 0.00m;
            }

            if (!decimal.TryParse(
                kilometreText,
                out decimal kilometres))
            {
                message = "Error: Kilometres must be a number.";
                return 0.00m;
            }

            if (kilometres <= 0)
            {
                message =
                    "Error: Kilometres must be greater than zero.";

                return 0.00m;
            }

            decimal estimate = kilometres * MileageRate;

            message = "Success";

            return Math.Round(estimate, 2);
        }

        public static decimal ApplyLimits(
            string category,
            string amountText,
            out string message)
        {
            category = category.Trim();
            amountText = amountText.Trim();

            if (string.IsNullOrWhiteSpace(category))
            {
                message = "Error: Category is required.";
                return 0.00m;
            }

            if (category != "Meal" &&
                category != "Parking")
            {
                message =
                    "Error: Category must be Meal or Parking.";

                return 0.00m;
            }

            if (string.IsNullOrWhiteSpace(amountText))
            {
                message = "Error: Amount is required.";
                return 0.00m;
            }

            if (!decimal.TryParse(
                amountText,
                out decimal amount))
            {
                message = "Error: Amount must be a number.";
                return 0.00m;
            }

            if (amount <= 0)
            {
                message =
                    "Error: Amount must be greater than zero.";

                return 0.00m;
            }

            decimal limit;

            if (category == "Meal")
            {
                limit = MealLimit;
            }
            else
            {
                limit = ParkingLimit;
            }

            if (amount > limit)
            {
                message =
                    $"Warning: Amount capped at ${limit:F2} limit.";

                return limit;
            }

            message = "";

            return Math.Round(amount, 2);
        }
    }
}