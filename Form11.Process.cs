using System;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.share;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// 完了情報フォーム
/// </summary>
public partial class Form11 {
    /// <summary>
    /// Process
    /// </summary>
    private void Process() {
        WorkInfo.Delete();
        foreach (var workInfo in WorkInfo.List.Where(workInfo => !string.IsNullOrEmpty(workInfo.Ret.Trim()))) {
            WorkInfo.Insert(
                workInfo.Sno,
                workInfo.Date == 0 ? int.Parse(DateTime.Now.ToString("yyyyMMdd")) : workInfo.Date,
                workInfo.Syain == 0 ? Globals.staffId : workInfo.Syain
            );
        }

        MessageBox.Show(@"データベースに更新しました。");
        Close();
    }
}