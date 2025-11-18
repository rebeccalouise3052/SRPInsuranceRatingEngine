// This file defines the types of insurance policies the system can handle.
// Using an enum makes the policy type strongly typed and prevents invalid strings.

namespace Rating.Models
{
    // Enum = a fixed set of named values.
    // Here we define the 3 supported policy types.
    public enum PolicyType
    {
        Auto, // Car insurance
        Land, // Land/building insurance
        Life  // Life insurance
    }
}
