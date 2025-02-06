// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using WorkDataStudio.Properties;
using WorkDataStudio.share;

namespace WorkDataStudio.Model;

/// <summary>
/// 加工ワークデータタイプクラス Member
/// </summary>
public partial class WorkDataType {
    /// <summary>
    /// 
    /// </summary>
    public static List<WorkDataType> List = [];

    /// <summary>
    /// 
    /// </summary>
    public static int Count => List.Count;

    /// <summary>
    /// 
    /// </summary>
    public static bool Exists => Count > 0;

    /// <summary>
    /// 
    /// </summary>
    public static List<WorkDataType> GetAll() {
        List = Select();

        return List;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static List<WorkDataType> Select() {
        const string sql = "SELECT * FROM tnbn_kakowk_data_type" +
                           " ORDER BY dm";
        var index = 0;
        return (from DataRow row in PgOpen.PgSelect(sql).Rows
            select new WorkDataType {
                _dm = (string)row["dm"],
                _ryaku = (string)row["ryaku"],
                _meisyo = (string)row["meisyo"],
                _nyuMode = (string)row["nyu_mode"],
                _nyuTani = (decimal)row["nyu_tani"],
                _tani = (string)row["tani"],
                _devTensu = (short)row["dev_tensu"],
                _haniMin = (decimal)row["hani_min"],
                _haniMax = (decimal)row["hani_max"],
                _zeroEntry = (string)row["zero_entry"],
                _keishiki = (string)row["keishiki"],
                _biko = (string)row["biko"],
                _karituke = (string)row["karitsuke"],
                _yosetu = (string)row["yosetu"],
                _kyosei = (string)row["kyosei"],
                _def = (string)row["def"],
                _haniMin2 = 0m,
                _index = index++
            }).ToList();
    }

    /// <summary>
    /// 配列番号を取得
    /// </summary>
    /// <param name="dm"></param>
    /// <returns></returns>
    public static int DmIndex(string dm) {
        return (
            from data in List.Select((value, index) => new { value, index })
            where data.value.Dm == dm
            select data.index).FirstOrDefault();
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
            sw.Write($"{data._haniMax} {data.ZeroEntry} {data.Keishiki} {data.Biko} ");
            sw.Write($"{data.Karituke} {data.Yosetu} {data.StrKyosei} {data.Def} ");
            sw.WriteLine($"{data.IntHaniMin2}");
        }

        sw.WriteLine(Count);
    }
}