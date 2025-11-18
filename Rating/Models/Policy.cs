using System;

namespace Rating.Models
{
    // The Policy class represents a single insurance policy.
    // It contains ALL possible fields for Auto, Land, and Life insurance.
    // Specific raters will use only the fields relevant to their policy type.
    public class Policy
    {
        // The type of policy (Auto, Land, or Life)
        public PolicyType Type { get; set; }

        // ========================================
        // AUTO POLICY DATA
        // ========================================

        // The car manufacturer (e.g., BMW, Ford)
        public string Make { get; set; }

        // The deductible amount (what the user pays before insurance)
        public decimal Deductible { get; set; }

        // ========================================
        // LAND POLICY DATA
        // ========================================

        // Amount insured via the land bond
        public decimal BondAmount { get; set; }

        // The total property valuation
        public decimal Valuation { get; set; }

        // ========================================
        // LIFE POLICY DATA
        // ========================================

        // Date of birth of the insured person
        public DateTime DateOfBirth { get; set; }

        // The life insurance payout amount
        public decimal Amount { get; set; }

        // Whether the insured person is a smoker (affects risk)
        public bool IsSmoker { get; set; }
    }
}
