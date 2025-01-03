using System;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

// ReSharper disable ConvertIfStatementToSwitchStatement
// ReSharper disable InvertIf
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// メニュー項目2 イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @sm21_Click(1)
    /// データ > 読込 > 船番指定
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_1_1_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「データ > 読込 > 船番指定」が選択されました。");
        OpenDialog(FormType.Form8, true);
    }

    /// <summary>
    /// @sm21_Click(2)
    /// データ > 読込 > 今日以降
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_1_2_Click(object sender, EventArgs e) {
        MessageBox.Show(@"今日以降は、利用できません。");
    }

    /// <summary>
    /// @sm2_Click(2)
    /// データ > 登録
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_2_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「データ > 登録」が選択されました。");
        Process_Save();
    }

    /// <summary>
    /// @sm2_Click(3)
    /// データ > コピー
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_3_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「「データ > コピー」が選択されました。");
        OpenDialog(FormType.Form2, true);
    }

    /// <summary>
    /// @sm2_Click(4)
    /// データ > 削除（行選択）
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_4_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「データ > 削除（行選択）」が選択されました。");
        Process_Delete(WorkData.DELETE);
    }

    /// <summary>
    /// @sm2_Click(5)
    /// データ > 削除クリア
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_5_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「データ > 削除クリア」が選択されました。");
        Process_Delete(WorkData.DRAFT);
    }

    /// <summary>
    /// @sm6_Click(1)
    /// データ > 削除（船番選択）
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_6_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「データ > 削除（船番選択）」が選択されました。");
        OpenDialog(FormType.Form9, true);
    }
}