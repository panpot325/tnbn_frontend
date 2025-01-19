using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// コピー船番選択フォーム
/// </summary>
public partial class Form7 {
    /// <summary>
    /// Process
    /// </summary>
    private void Process() {
        if (string.IsNullOrEmpty(comboBox1.Text)) {
            MessageBox.Show(@"コピー元の船番を選択して下さい。");
            return;
        }

        if (string.IsNullOrEmpty(textBox1.Text)) {
            MessageBox.Show(@"新しい船番を入力して下さい。");
            return;
        }

        if (SnoIndex.GetExist(textBox1.Text)) {
            if (MessageBox.Show(@"既存の船番データを置き換えますか？", "",
                    MessageBoxButtons.YesNo) == DialogResult.No) {
                return;
            }
        }

        var where = $"sno = '{comboBox1.Text.Trim()}'";
        switch (WorkData.GetCount(where)) {
            case > 5000:
                MessageBox.Show(@"５０００件オーバーです。範囲を絞って下さい。");
                return;
            case 0:
                MessageBox.Show(@"コピー元の船番を選択して下さい。");
                return;
        }

        WorkData.GetAll(where);
        WorkData.snoName = textBox1.Text;
        foreach (var workData in WorkData.List) {
            workData.Sno = textBox1.Text.Trim();
            workData.ChgFlg = WorkData.UPDATE;
            workData.YoteibiHon = 0;
            workData.YoteibiKyosei = 0;
            workData.JissibiKari = 0;
            workData.JissibiHon = 0;
            workData.JissibiKyosei = 0;
            workData.StatusKari = 0;
            workData.StatusHon = 0;
            workData.StatusKyosei = 0;
        }

        Mode.SetCopy1();
        WorkDataExclusive.Delete(); //@Del_排他情報
        WorkDataExclusive.Insert(WorkData.snoName); // Ins_排他中に更新(船番)
        Close();
        Owner.Close();
        Form1.Activate();
    }
}