using System.Linq;
using WorkDataStudio.Model;
using WorkDataStudio.share;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム WorkData
/// </summary>
public partial class Form1 {
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
    /// @加工ワークデータSの更新()
    /// </summary>
    private void WorkData_S_Update() {
        foreach (var workData in WorkData.List
                     .Where(workData =>
                         workData.Pcs == "S"
                         && workData.CrePFlg != 1
                         && workData.ChgFlg != WorkData.DELETE)
                ) {
            workData.Delete();
            workData.Insert();
        }
    }

    /// <summary>
    /// @CrePSFlgの更新()
    /// </summary>
    private void WorkData_PS_Update() {
        if (!Frame2.Enabled || !Option1_0.Checked) return;

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