using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkDataStudio.share;

// ReSharper disable MemberCanBePrivate.Global
namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Static
/// </summary>
public partial class WorkData {
    /// <summary>
    /// WorkDataList
    /// </summary>
    public static List<WorkData> List = [];

    /// <summary>
    /// WorkDataCount
    /// </summary>
    public static int Count => List.Count;

    /// <summary>
    /// WorkDataExists
    /// </summary>
    public static bool Exists => Count > 0;

    /// <summary>
    /// WorkDataFilter
    /// </summary>
    public static WorkDataFilter Filter => WorkDataFilter.New();

    /// <summary>
    /// WorkDataGetAll
    /// </summary>
    public static List<WorkData> GetAll() {
        List = Fetch();

        return List;
    }

    /// <summary>
    /// WorkDataGetAll
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public static List<WorkData> GetAll(string where) {
        List = Fetch(where);

        return List;
    }

    /// <summary>
    /// GetCount
    /// </summary>
    /// <returns></returns>
    public static int GetCount() {
        var sb = new StringBuilder();
        sb.Append("SELECT COUNT(*) AS count FROM tnbn_kakowk_data");
        sb.Append(" WHERE 1 = 1");
        sb.Append(WorkDataFilter.HasSno ? $" AND sno = '{WorkDataFilter.Sno}'" : "");
        sb.Append(WorkDataFilter.HasBlk ? $" AND blk = '{WorkDataFilter.Blk}'" : "");
        sb.Append(WorkDataFilter.HasBzi ? $" AND bzi = '{WorkDataFilter.Bzi}'" : "");
        sb.Append(WorkDataFilter.HasPcs ? $" AND pcs = '{WorkDataFilter.Pcs}'" : "");
        sb.Append(WorkDataFilter.HasYotei ? $" AND yoteibi_kari = {WorkDataFilter.Yotei}" : "");

        return PgOpen.PgCount(sb.ToString());
    }

    /// <summary>
    /// GetCount
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public static int GetCount(string where) {
        var sb = new StringBuilder();
        sb.Append("SELECT COUNT(*) AS count FROM tnbn_kakowk_data");
        if (!string.IsNullOrEmpty(where)) {
            sb.Append($" WHERE {where}");
        }

        return PgOpen.PgCount(sb.ToString());
    }

    /// <summary>
    /// WorkDataCreate
    /// </summary>
    /// <returns></returns>
    public static WorkData Create() {
        return new WorkData {
            ChgFlg = DRAFT,
            ErrorValidation = new Validation()
        }.DefaultField();
    }

    /// <summary>
    /// WorkDataAdd
    /// </summary>
    /// <returns></returns>
    public static List<WorkData> Add(string sno = "") {
        var workData = Create();
        workData.Sno = sno;
        List.Add(workData);
        return List;
    }

    /// <summary>
    /// WorkDataClear
    /// </summary>
    public static List<WorkData> Clear() {
        List = [
        ];
        return List;
    }

    /// <summary>
    /// ValidAll
    /// @更新チェック
    /// </summary>
    /// <returns></returns>
    public static int ValidAll() {
        var cnt = 0;
        foreach (var workData in List.Where(workData => workData.ChgFlg == UPDATE)) {
            cnt += workData.Valid();
            workData.Err1Flg = cnt > 0 ? 1 : 0; //入力ﾁｪｯｸｴﾗｰﾌﾗｸﾞ
        }

        return cnt;
    }

    /// <summary>
    /// @重複チェック
    /// </summary>
    /// <param name="error2"></param>
    /// <returns></returns>
    public static int DuplicateAll(bool error2 = false) {
        var cnt = 0;
        foreach (var workData in List.Where(workData => workData.ChgFlg == UPDATE)) {
            var duplicate = workData.Duplicate();
            workData.Err2Flg = error2 && duplicate > 0 ? 1 : 0;
            cnt += duplicate;
        }

        return cnt;
    }

    /// <summary>
    /// 更新、削除
    /// </summary>
    /// <param name="delete"></param>
    public static void UpdateAll(bool delete = false) {
        foreach (var workData in List) {
            switch (workData.ChgFlg) {
                case UPDATE:
                    (workData.Find() > 0 ? (Action)workData.Update : workData.Insert)();
                    break;
                case DELETE:
                    (delete ? (Action)workData.Delete : () => { })();
                    break;
            }
        }
    }

    /// <summary>
    /// DeleteAll
    /// @加工ワークデータの削除_船番
    /// </summary>
    public static void DeleteAll(string sno) {
        var sql = "DELETE FROM tnbn_kakowk_data" +
                  $" WHERE sno = '{sno}';";
        PgOpen.PgUpdate(sql);
    }

    /// <summary>
    /// InsertAll
    /// </summary>
    public static void InsertAll() {
        foreach (var workData
                 in List
                     .Where(workData => workData.Err1Flg == 0
                                        && workData.Err2Flg == 0)) {
            workData.Insert();
        }
    }

    /// <summary>
    /// Field Construct
    /// </summary>
    /// <param name="index"></param>
    /// <param name="data"></param>
    /// <param name="newCreate"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    private static WorkDataField<T> NewField<T>(int index, T data, bool newCreate = false) {
        var def = WorkDataType.List[index].Def;
        return newCreate && def != WorkDataType.HYPHEN
            ? new WorkDataField<T>(WorkDataType.List[index], (T)Convert.ChangeType(def, typeof(T)))
            : new WorkDataField<T>(WorkDataType.List[index], data);
    }
}