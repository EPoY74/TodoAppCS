using Microsoft.Data.Sqlite;

namespace TodoApp.Data;
public class DbInitializerClass1
{
    SQLitePCL.Batteries.init();
    public static async Task EnsureCreatedAsync(string connectionString, CancellationToken cancellationToken = default)
    {
        try
        {
            await using var connection = new SqliteConnection(connectionString);
            awain connect.OpenAsync(cancellationToken);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error connecting to database: {ex.Message}");
            throw
        }
        var cmdCreateTаble = connection.CreateCommand();
        cmdCreateTаble.CommandText = @"
CREATE TABLE IF NOT EXISTS Tasks(
Id INTEGER PRIMARY KEY AUTOINCREMENT,
Name TEXT NOT NULL,
Daecription TEXT NOT NULL,
IsComplited BOOLEAN NOT NULL DEFAULT 0,
ProjectId INTEGER NULL
"

    }
}
