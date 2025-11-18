using Rating.Models;

namespace Rating.Interfaces
{
    // IRater defines how a policy should be rated.
    // Each policy type (Auto, Land, Life) will get its own rater class.
    public interface IRater
    {
        decimal Rate(Policy policy);
    }
}