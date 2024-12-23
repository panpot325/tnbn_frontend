using System.Windows.Forms;
using WorkDataStudio.Model;

namespace WorkDataStudio;

/// <summary>
/// コピー船番単位フォーム
/// </summary>
public partial class Form4 {
    /// <summary>
    /// Process
    /// </summary>
    private void Process() {
        if (string.IsNullOrEmpty(comboBox1.Text)
            && string.IsNullOrEmpty(comboBox2.Text)) {
            MessageBox.Show(@"船番を指定して下さい。");
            return;
        }

        var where = (string.IsNullOrEmpty(comboBox1.Text))
            ? ""
            : $"sno >= '{comboBox1.Text.Trim()}'";

        if (!string.IsNullOrEmpty(comboBox2.Text)) {
            if (!string.IsNullOrEmpty(where)) {
                where = $"{where} AND ";
            }

            where = $"{where} sno <= '{comboBox2.Text.Trim()}'";
        }

        WorkData.copySelectCnt = WorkData.GetCount(where);
        if (WorkData.copySelectCnt > 5000) {
            MessageBox.Show(@"５０００件オーバーです。範囲を絞って下さい。");
            return;
        }

        WorkData.GetAll(where);
        foreach (var workData in WorkData.List) {
            workData.ChgFlg = WorkData.DRAFT;
        }
        WorkData.selected = true; //条件選択 = True @Deprecated
        Close();
    }
}