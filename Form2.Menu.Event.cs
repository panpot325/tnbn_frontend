using System;
using WorkDataStudio.share;

namespace WorkDataStudio;

/// <summary>
/// コピー船番一覧フォーム
/// </summary>
public partial class Form2 {
    /// <summary>
    /// 取消
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM1_1_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「取消」が選択されました。");
    }

    /// <summary>
    /// 戻る
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM1_2_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「戻る」が選択されました。");
        Close();
    }

    /// <summary>
    /// 船番→新船番
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_1_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「船番→新船番」が選択されました。");
        OpenDialog(FormType.Form7, true);
    }

    /// <summary>
    /// 全データを表示
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_2_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「全データを表示」が選択されました。");
    }

    /// <summary>
    /// 船番を指定して表示
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_3_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「船番を指定して表示」が選択されました。");
        OpenDialog(FormType.Form4, true);
    }

    /// <summary>
    /// 仮付予定日指定して表示
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_4_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「仮付予定日指定して表示」が選択されました。");
    }

    /// <summary>
    /// 決定
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Enter_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「決定」が選択されました。");
        Process();
    }
}