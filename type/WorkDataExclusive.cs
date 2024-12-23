using WorkDataStudio.share;
using G = WorkDataStudio.share.Globals;

namespace WorkDataStudio.type;

/// <summary>
/// WorkDataExclusive
/// </summary>
public static class WorkDataExclusive {
    /// <summary>
    /// TNBN_KAKOWK_DATA_HAITAから排他を解除する  
    /// </summary>
    /// <param name="syain"></param>
    /// <param name="pcName"></param>
    /// <param name="pSno"></param>
    /// <returns></returns>
    public static bool Delete(int syain, string pcName, string pSno = "") {
        var sql = "DELETE FROM tnbn_kakowk_data_haita" +
                  $" WHERE syain = '{syain}'" +
                  $" AND pcnim = '{pcName}'" +
                  (pSno == ""
                      ? ""
                      : $" AND sno = '{pSno.Trim()}'")
            ;

        return PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// TNBN_KAKOWK_DATA_HAITAから排他を解除する 
    /// </summary>
    /// <param name="pSno"></param>
    /// <returns></returns>
    public static bool Delete(string pSno = "") {
        var sql = "DELETE FROM tnbn_kakowk_data_haita" +
                  $" WHERE syain = '{G.staffId}'" +
                  $" AND pcnim = '{G.pcName}'" +
                  (pSno == ""
                      ? ""
                      : $" AND sno = '{pSno.Trim()}'")
            ;

        return PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// @Sel_排他情報
    /// </summary>
    /// <param name="syain"></param>
    /// <param name="pcName"></param>
    /// <param name="pSno"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    public static int Count(int syain, string pcName, string pSno = "", int flag = 0) {
        var sql = "SELECT COUNT(*) AS count FROM tnbn_kakowk_data_haita" +
                  (flag == 0 ? $" WHERE syain <> '{syain}'" : $" WHERE syain = '{syain}'") +
                  $" AND pcnim = '{pcName}'" +
                  (pSno == ""
                      ? ""
                      : $" AND sno = '{pSno.Trim()}'")
            ;

        return PgOpen.PgCount(sql);
    }

    /// <summary>
    /// @Sel_排他情報 
    /// </summary>
    /// <param name="pSno"></param>
    /// <param name="flag"></param>
    /// <returns></returns>
    public static int Count(string pSno = "", int flag = 0) {
        var sql = "SELECT COUNT(*) AS count FROM tnbn_kakowk_data_haita" +
                  (flag == 0 ? $" WHERE syain <> '{G.staffId}'" : $" WHERE syain = '{G.staffId}'") +
                  $" AND pcnim = '{G.pcName}'" +
                  (pSno == ""
                      ? ""
                      : $" AND sno = '{pSno.Trim()}'")
            ;

        return PgOpen.PgCount(sql);
    }

    /// <summary>
    /// @Ins_排他中に更新
    /// </summary>
    /// <param name="syain"></param>
    /// <param name="pcName"></param>
    /// <param name="pSno"></param>
    /// <returns></returns>
    public static bool Insert(int syain, string pcName, string pSno = "") {
        var sql = "INSERT INTO tnbn_kakowk_data_haita" +
                  $" (syain, pcnim, sno) " +
                  $" values('{syain}', '{pcName}', '{pSno}');";

        return PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// @Ins_排他中に更新 
    /// </summary>
    /// <param name="pSno"></param>
    /// <returns></returns>
    public static bool Insert(string pSno = "") {
        var sql = "INSERT INTO tnbn_kakowk_data_haita" +
                  $" (syain, pcnim, sno) " +
                  $" values('{G.staffId}', '{G.pcName}', '{pSno}');";

        return PgOpen.PgUpdate(sql);
    }
}