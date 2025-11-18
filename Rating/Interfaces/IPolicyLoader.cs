using Rating.Models;

namespace Rating.Interfaces
{
    // IPolicyLoader defines how a Policy is loaded (e.g., from a file, DB, API).
    // Implementations will handle reading and parsing JSON.
    public interface IPolicyLoader
    {
        Policy LoadPolicy();
    }
}