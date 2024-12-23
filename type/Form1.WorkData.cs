using System.Linq;
using WorkDataStudio.model;
using WorkDataStudio.share;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム WorkData
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @DB更新前入力チェック()
    /// </summary>
    /// <returns>bool</returns>
    private bool WorkData_Valid() {
        var errCnt = 0;
        if (G.Mode == C.MODE_NEW_2) {
            WorkData_E_W_Edit(); // 西東対象データ編集
        }

        //foreach (var data in WorkData.List.Select((value, index) => new { value, index }))
        foreach (var workData in WorkData.List.Where(workData => workData.ChgFlg == C.UPDATE)) {
            errCnt += workData.Valid();
            workData.Err1Flg = errCnt > 0 ? 1 : 0; //入力ﾁｪｯｸｴﾗｰﾌﾗｸﾞ
        }

        return errCnt == 0;
    }

    /// <summary>
    /// @キー重複チェック()
    /// </summary>
    /// <returns></returns>0
    private bool WorkData_Duplicate() {
        var errCnt = 0;
        foreach (var workData in WorkData.List.Where(workData => workData.ChgFlg == C.UPDATE)) {
            switch (G.Mode) {
                case C.MODE_COPY_2:
                    var errCnt2 = workData.Duplicate();
                    errCnt += errCnt2;
                    if (errCnt2 > 0) {
                        workData.Err2Flg = 1;
                        G.duplicateErrCnt++;
                    }

                    break;
                default:
                    errCnt += workData.Duplicate();
                    break;
            }
        }

        return errCnt == 0;
    }

    /// <summary>
    /// @西東対象データ編集()
    /// </summary>
    private void WorkData_E_W_Edit() {
        var data = WorkData.List[0];
        data.E_W_Edit();
        DataGrid3.With(g => {
            g[0, 11].Value = data.Lk3;
            g[0, 12].Value = data.Lk4;
            g[0, 13].Value = data.Lk5;
            g[0, 28].Value = data.Sp3.ToString("####0.0");
            g[0, 29].Value = data.Sp4.ToString("####0.0");
            g[0, 30].Value = data.Sp5.ToString("####0.0");
            g[0, 33].Value = data.Lh3;
            g[0, 34].Value = data.Lh4.ToString("####0.0");
            g[0, 35].Value = data.Lh5.ToString("####0.0");
            g[0, 38].Value = data.Lt3;
            g[0, 39].Value = data.Lt4.ToString("####0.0");
            g[0, 40].Value = data.Lt5.ToString("####0.0");
            g[0, 43].Value = data.Ll3;
            g[0, 44].Value = data.Ll4.ToString("####0.0");
            g[0, 45].Value = data.Ll5.ToString("####0.0");
            g[0, 48].Value = data.Wl3;
            g[0, 49].Value = data.Wl4.ToString("####0.0");
            g[0, 50].Value = data.Wl5.ToString("####0.0");
            g[0, 54].Value = data.Stp3;
            g[0, 55].Value = data.Stp4.ToString("####0.0");
            g[0, 56].Value = data.Stp5.ToString("####0.0");
        });
    }

    /// <summary>
    /// @加工ワークデータの更新()
    /// </summary>
    private void WorkData_Update() {
        foreach (var workData in WorkData.List) {
            switch (workData.ChgFlg) {
                case C.UPDATE:
                    if (workData.Find() > 0) {
                        workData.Update();
                    }
                    else {
                        workData.Insert();
                    }

                    break;
                case C.DELETE:
                    if (G.Mode != C.MODE_EDIT_1 && G.Mode != C.MODE_COPY_1) {
                        workData.Delete();
                    }

                    break;
            }
        }
    }

    /// <summary>
    /// @加工ワークデータSの更新()
    /// </summary>
    private void WorkData_S_Update() {
        foreach (var workData in WorkData.List
                     .Where(workData =>
                         workData.Pcs == "S"
                         && workData.CrePFlg != 1
                         && workData.ChgFlg != C.DELETE)
                ) {
            workData.Delete();
            workData.Insert();
        }
    }

    /// <summary>
    /// @Set_加工ワークデータ
    /// </summary>
    /// <param name="pi"></param>
    private void WorkData_Set(int pi) {
        var data = WorkData.List[pi].SetOfGrid(DataGrid3);
    }

    /// <summary>
    /// @CrePSFlgの更新()
    /// </summary>
    private void WorkData_PS_Update() {
        foreach (var workData in WorkData.List) {
            switch (workData.Pcs) {
                case "P":
                    workData.Update($"cres_flg = {workData.CreSFlg}, crep_flg = 1");
                    break;
                case "S":
                    workData.Update($"crep_flg = {workData.CrePFlg}, cres_flg = 0");
                    break;
            }
        }
    }
}