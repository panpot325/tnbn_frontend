using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// コピー船番一覧フォーム
/// </summary>
public partial class Form2 {
    /// <summary>
    /// Process
    /// </summary>
    private void Process() {
        WorkData.copySelectCnt = WorkData.List.Count(workData => workData.ChgFlg == WorkData.UPDATE);
        if (WorkData.copySelectCnt == 0) {
            MessageBox.Show(@"コピー元を選択してください。");
            return;
        }

        WorkData.List.RemoveAll(w => w.ChgFlg != WorkData.UPDATE);
        WorkDataExclusive.Delete();
        Mode.SetCopy2();
        Close();
        Form1.Activate();
    }
}