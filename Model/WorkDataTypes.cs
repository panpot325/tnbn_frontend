using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using WorkDataStudio.Properties;
using WorkDataStudio.share;

// ReSharper disable MemberCanBePrivate.Global

namespace WorkDataStudio.Model;

/// <summary>
/// 加工ワークータタイプコレクション
///  @Singleton Design Pattern
/// </summary>
public class WorkDataTypes {
    /// Static Instance
    private static readonly WorkDataTypes _instance = new();

    // Static Members
    private readonly List<WorkDataType> _list;
    private readonly DataTable _table;

    // Static Property
    public static List<WorkDataType> List => _instance._list;
    public static int Count => List.Count;
    public static bool Exists => Count > 0;
    public static DataTable Table => _instance._table;

    /// Constants
    private const string SQL = "SELECT * FROM tnbn_kakowk_data_type" +
                               " ORDER BY dm";

    /// <summary>
    /// Private Constructor
    /// </summary>
    private WorkDataTypes() {
        _list = [];
        _table = PgOpen.PgSelect(SQL);
        foreach (DataRow row in _table.Rows) {
            _list.Add(new WorkDataType(
                (string)row["dm"],
                (string)row["ryaku"],
                (string)row["meisyo"],
                (string)row["nyu_mode"],
                (decimal)row["nyu_tani"],
                (string)row["tani"],
                (short)row["dev_tensu"],
                (decimal)row["hani_min"],
                (decimal)row["hani_max"],
                (string)row["zero_entry"],
                (string)row["keishiki"],
                (string)row["biko"],
                (string)row["karitsuke"],
                (string)row["yosetu"],
                (string)row["kyosei"],
                (string)row["def"],
                0m
            ));
        }
    }

    public static DataTable GetDataTable() {
        var table = new DataTable();
        table.Columns.Add("dm", typeof(string));
        foreach (var data in _instance._list) {
            var row = table.NewRow();
            row["dm"] = data.Dm;
            table.Rows.Add(row);
        }

        return table;
    }

    /// <summary>
    /// Dump List
    /// </summary>
    public static void Dump() {
        using var sw = new StreamWriter($"{Settings.Default.Dev_Path}/KakoWkDataType.txt", false, Encoding.UTF8);
        var i = 1;
        foreach (var data in List) {
            sw.Write($"{i++:000} {data.Dm} {data.Ryaku} {data.Meisyo} {data.NyuMode} ");
            sw.Write($"{data.DecNyuTani} {data.Tani} {data.DevTensu} {data.DecHaniMin} ");
            sw.Write($"{data.DecHaniMax} {data.ZeroEntry} {data.Keishiki} {data.Biko} ");
            sw.Write($"{data.Karituke} {data.Yosetu} {data.StrKyosei} {data.Def} ");
            sw.WriteLine($"{data.IntHaniMin2}");
        }

        sw.WriteLine(Count);
    }
}