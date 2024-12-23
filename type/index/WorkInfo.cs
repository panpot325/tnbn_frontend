using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WorkDataStudio.share;

namespace WorkDataStudio.type.index;

/// <summary>
/// 完了情報クラス
/// </summary>
public class WorkInfo {
    public string Sno { get; private set; }
    public string Ret { get; set; }
    public int Date { get;  set; }
    public int Syain { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    private WorkInfo() {
    }

    public static List<WorkInfo> List = [];
    public static int Count => List.Count;
    public static bool Exists => Count > 0;

    public static List<WorkInfo> GetAll() {
        List = Select();

        return List;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private static List<WorkInfo> Select() {
        var sb = new StringBuilder();
        sb.Append("SELECT k.sno AS sno,");
        sb.Append(" COALESCE(f.sno, '未完') AS ret,");
        sb.Append(" COALESCE(f.create_date,0) AS date,");
        sb.Append(" COALESCE(f.create_syain,0) AS syain");
        sb.Append(" FROM (select SNO from TNBN_KAKOWK_DATA group by SNO) AS k");
        sb.Append(" LEFT JOIN tnbn_fin_ship_mst AS f ON k.sno = f.sno");
        sb.Append(" ORDER BY  k.sno DESC;");

        return (from DataRow row in PgOpen.PgSelect(sb.ToString()).Rows
            select new WorkInfo {
                Sno = (string)row["sno"],
                Ret = (string)row["ret"] == "未完" ? " " : "完了",
                Date = (int)row["date"],
                Syain = (int)row["syain"],
            }).ToList();
    }

    /// <summary>
    /// Insert
    /// </summary>
    /// <param name="sno"></param>
    /// <param name="createDate"></param>
    /// <param name="createSyain"></param>
    /// <returns></returns>
    public static bool Insert(string sno, int createDate, int createSyain) {
        var sql = "INSERT INTO tnbn_fin_ship_mst" +
                  $" (sno, create_date, create_syain) " +
                  $" values('{sno}', '{createDate}', '{createSyain}');";

        return PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// Delete
    /// </summary>
    /// <returns></returns>
    public static bool Delete() {
        const string sql = "DELETE FROM tnbn_fin_ship_mst;";

        return PgOpen.PgUpdate(sql);
    }
}