using WorkDataStudio.share;

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Sql
/// </summary>
public partial class WorkData {
    /// <summary>
    /// 検索
    /// </summary>
    /// <returns>int</returns>
    private int Find() {
        var sql = "SELECT COUNT(*) AS count FROM tnbn_kakowk_data" +
                  $"{SqlWhere()};";

        return PgOpen.PgCount(sql);
    }

    /// <summary>
    /// 登録
    /// </summary>
    public void Insert() {
        var sql = "INSERT INTO tnbn_kakowk_data" +
                  $" (sno, blk, bzi, pcs, {SqlColumns()}) " +
                  $" values('{Sno}', '{Blk}', '{Bzi}', '{Pcs}', {SqlValues()});";
        PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// 更新
    /// </summary>
    private void Update() {
        var sql = "UPDATE tnbn_kakowk_data" +
                  $" SET({SqlColumns()}) = " +
                  $" ({SqlValues()}) {SqlWhere()};";
        PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// 更新
    /// </summary>
    public void Update(string formula) {
        var sql = "UPDATE tnbn_kakowk_data SET " + formula + SqlWhere();
        PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// 削除
    /// </summary>
    public void Delete() {
        var sql = "DELETE FROM tnbn_kakowk_data" +
                  $"{SqlWhere()};";
        PgOpen.PgUpdate(sql);
    }
}