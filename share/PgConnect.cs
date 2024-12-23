using Npgsql;

namespace WorkDataStudio.share;

public class PgConnect {
    private const string HOST = "10.211.55.2";
    private const string DATABASE = "onozo_202409";
    private const string PORT = "5432";
    private const string USERNAME = "postgres";
    private const string PASSWORD = "postgres";

    private static NpgsqlConnection _connection;

    public static PgConnect CreateInstance() {
        return new PgConnect();
    }

    private static string GetConnectionString() {
        return $"Host={HOST};Port={PORT};Username={USERNAME};Password={PASSWORD};Database={DATABASE}";
    }

    /// <summary>
    /// PgConnect
    /// </summary>
    public static NpgsqlDataReader Read(string sql) {
        Open();
        var command = new NpgsqlCommand(sql, _connection);

        return command.ExecuteReader();
    }

    public static int Update(string sql) {
        Open();
        using var command = new NpgsqlCommand(sql, _connection);
        var rowsAffected = command.ExecuteNonQuery();
        Close();
        return rowsAffected;
    }

    private static void Open() {
        _connection = new NpgsqlConnection(GetConnectionString());
        _connection.Open();
    }

    public static void Close() {
        _connection.Close();
    }
}