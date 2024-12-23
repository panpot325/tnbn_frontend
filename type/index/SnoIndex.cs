using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WorkDataStudio.share;

// ReSharper disable MemberCanBePrivate.Global

namespace WorkDataStudio.type.index;

/// <summary>
/// @船番名一覧リスト
/// </summary>
public class SnoIndex {
    /// Static Instance
    private static readonly SnoIndex _instance = new();

    /// Constants
    private const string SQL = " SELECT sno FROM tnbn_kakowk_data" +
                               " GROUP BY sno" +
                               " ORDER BY sno DESC";

    /// Property
    public static List<string> List => _instance._list;

    public static int Count => List.Count;
    public static bool Exist => Count > 0;

    /// Member
    private readonly List<string> _list;

    /// <summary>
    /// Private Constructor
    /// </summary>
    public SnoIndex() {
        _list = [];
        foreach (DataRow row in PgOpen.PgSelect(SQL).Rows) {
            _list.Add((string)row["sno"]);
        }
    }

    /// <summary>
    /// GetAll
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public static List<string> GetAll(string order = "") {
        List<string> list = [];
        var sb = new StringBuilder();
        sb.Append("SELECT sno FROM tnbn_kakowk_data");
        sb.Append(" GROUP BY sno");
        sb.Append($" ORDER BY sno {order}");
        list.AddRange(from DataRow row in PgOpen.PgSelect(sb.ToString()).Rows select (string)row["sno"]);

        return list;
    }

    /// <summary>
    /// GetCount
    /// </summary>
    /// <param name="sno"></param>
    /// <returns></returns>
    public static int GetCount(string sno) {
        var sql = " SELECT COUNT(*) AS count FROM tnbn_kakowk_data" +
              $" WHERE sno = '{sno.Trim()}'";
        return PgOpen.PgCount(sql);
    }
    
    /// <summary>
    /// GetExist
    /// </summary>
    /// <param name="sno"></param>
    /// <returns></returns>
    public static bool GetExist(string sno) {
        var sql = " SELECT COUNT(*) AS count FROM tnbn_kakowk_data" +
                  $" WHERE sno = '{sno.Trim()}'";
        return PgOpen.PgCount(sql) > 0;
    }
}