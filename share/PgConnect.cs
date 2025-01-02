﻿using Npgsql;
using WorkDataStudio.Properties;

namespace WorkDataStudio.share;

public class PgConnect {
    private static NpgsqlConnection _connection;

    public static PgConnect CreateInstance() {
        return new PgConnect();
    }

    private static string GetConnectionString() {
        return $"Host={Settings.Default.DB_Host};" +
               $"Port={Settings.Default.DB_Port};" +
               $"Username={Settings.Default.DB_User};" +
               $"Password={Settings.Default.DB_Pass};" +
               $"Database={Settings.Default.DB_Name}";
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