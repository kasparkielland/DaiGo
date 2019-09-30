using SQLite;

namespace DaiGo
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

