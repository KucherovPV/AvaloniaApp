using AvaloniaApplicationPracticeOne.Model;
using AvaloniaApplicationPracticeOne.Model;

namespace AvaloniaApplicationPracticeOne;

public class Service
{

    private static PostgresContext? _db;
    
    public static PostgresContext  GetDbContext()
    {
        if (_db == null)
        {
            _db = new PostgresContext();
        }
        return _db;
    }
}