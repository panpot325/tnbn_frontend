﻿using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WorkDataStudio.share;

/// <summary>
/// Postgres Openクラス
/// </summary>
public class PgOpen {
    private const string HOST = "10.211.55.2";
    private const string DATABASE = "onozo_202409";
    private const string PORT = "5432";
    private const string USERNAME = "postgres";
    private const string PASSWORD = "postgres";
    private NpgsqlConnection _conn;

    /// Static Instance
    private static readonly PgOpen _instance = new();

    /// <summary>
    /// Open
    /// </summary>
    /// <returns>bool</returns>
    public static bool Connect() {
        try {
            _instance.Open();
            return true;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            return false;
        }
        finally {
            _instance.Close();
            Console.WriteLine(@"データベースに接続しました。");
        }
    }

    /// <summary>
    /// static method
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public static　int PgCount(string sql) {
        try {
            _instance.Open();
            var reader = _instance.ExecuteQueryReader(sql);
            while (reader.Read()) {
                return Convert.ToInt32(reader[0]);
            }

            return 0;
        }
        catch (Exception exception) {
            MessageBox.Show(@"DB_select_count:\n" + exception.Message, @"error");
            return 0;
        }
        finally {
            _instance.Close();
        }
    }

    /// <summary>
    /// static method
    /// </summary>
    /// <param name="sql"></param>
    /// <returns>DataTable</returns>
    public static　DataTable PgSelect(string sql) {
        try {
            var dataTable = new DataTable();
            _instance.Open();
            _instance.ExecuteQueryAdapter(sql).Fill(dataTable);
            return dataTable;
        }
        catch (Exception exception) {
            MessageBox.Show(@"DB_select_table_view:\n" + exception.Message, @"error");
            return null;
        }
        finally {
            _instance.Close();
        }
    }

    /// <summary>
    /// static method
    /// </summary>
    /// <param name="sql"></param>
    /// <returns>bool</returns>
    public static　bool PgUpdate(string sql) {
        _instance.Open();
        try {
            _instance.ExecuteNonQuery(sql);
            return true;
        }
        catch (Exception e) {
            MessageBox.Show(e.Message);
            return false;
        }
        finally {
            _instance.Close();
        }
    }

    /// <summary>
    /// Private Constructor
    /// </summary>
    private PgOpen() {
    }

    /// <summary>
    /// Open
    /// </summary>
    private void Open() {
        const string connStr = $"Host={HOST};Port={PORT};Username={USERNAME};Password={PASSWORD};Database={DATABASE}";
        _conn = new NpgsqlConnection(connStr);
        _conn.Open();
    }

    /// <summary>
    /// Close
    /// </summary>
    private void Close() {
        _conn.Close();
        _conn.Dispose();
    }

    /// <summary>
    /// ExecuteNonQuery
    /// </summary>
    /// <param name="sql"></param>
    private void ExecuteNonQuery(string sql) {
        var sqlCom = new NpgsqlCommand(sql, _conn);

        sqlCom.ExecuteNonQuery();
    }

    /// <summary>
    /// ExecuteQueryAdapter
    /// </summary>
    /// <param name="sql"></param>
    /// <returns>NpgsqlDataAdapter</returns>
    private NpgsqlDataAdapter ExecuteQueryAdapter(string sql) {
        var adapter = new NpgsqlDataAdapter(sql, _conn);

        return adapter;
    }

    /// <summary>
    /// ExecuteQueryReader
    /// </summary>
    /// <param name="sql"></param>
    /// <returns>NpgsqlDataReader</returns>
    private NpgsqlDataReader ExecuteQueryReader(string sql) {
        var sqlCom = new NpgsqlCommand(sql, _conn);
        var reader = sqlCom.ExecuteReader();

        return reader;
    }
}