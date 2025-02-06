using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// 船番単位フォーム
/// </summary>
public partial class Form8 {
    /// <summary>
    /// Process
    /// </summary>
    private void Process() {
        if (string.IsNullOrEmpty(comboBox1.Text)) {
            MessageBox.Show(@"船番を指定して下さい。");
            return;
        }

        WorkData.snoName = comboBox1.Text;
        if (WorkDataExclusive.Count(Globals.staffId, Globals.pcName, WorkData.snoName, 0) > 0
            || WorkDataExclusive.Count(Globals.staffId, Globals.pcName, WorkData.snoName, 1) > 0) {
            MessageBox.Show(@"排他中のため変更できません。。");
            return;
        }

        WorkData.Filter._Sno(WorkData.snoName);
        WorkData.GetAll();
        foreach (var workData in WorkData.List) {
            workData.ChgFlg = WorkData.UPDATE;
        }

        //データが取得できた他場合
        if (WorkData.Exists) {
            Mode.SetEdit1();
        }

        WorkDataExclusive.Delete(); //@Del_排他情報
        WorkDataExclusive.Insert(WorkData.snoName); // Ins_排他中に更新(船番)
        Close();
        Form1.Activate();
    }
}