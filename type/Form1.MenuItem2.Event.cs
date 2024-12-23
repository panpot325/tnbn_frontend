using System;
using System.Windows.Forms;
using WorkDataStudio.model;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

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
    private void MenuItem_SM21_1_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「データ > 読込 > 船番指定」が選択されました。");
        var form8 = new Form8();
        form8.ShowDialog(this);
        form8.Dispose();
    }

    /// <summary>
    /// @sm21_Click(2)
    /// データ > 読込 > 今日以降
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM21_2_Click(object sender, EventArgs e) {
        MessageBox.Show(@"今日以降は、利用できません。");
    }

    /// <summary>
    /// @sm2_Click(2)
    /// データ > 登録
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_2_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「データ > 登録」が選択されました。");

        Text4.Text = "";
        //選択モード=新規2 新規・登録(対象)の場合、複数入力(F5)は不可
        if (G.Mode == C.MODE_NEW_2) {
            WorkData.Add();
            WorkData.List[0].ChgFlg = C.UPDATE;
        }

        foreach (var workData in WorkData.List) {
            workData.Err1Flg = 0; //入力ﾁｪｯｸｴﾗｰﾌﾗｸﾞ
            workData.Err2Flg = 0; //重複ﾁｪｯｸｴﾗｰﾌﾗｸﾞ
        }

        //DB更新前入力チェック
        if (WorkData_Valid()) {
            switch (G.Mode) {
                //新規, 新規2
                case C.MODE_NEW_1:
                case C.MODE_NEW_2:
                    WorkData_Mode_New_1_2();
                    break;

                //キーコピー
                case C.MODE_COPY_2:
                    WorkData_Mode_Copy_2();
                    break;

                //今日以降, 今日予定            
                case C.MODE_EDIT_2:
                case C.MODE_EDIT_3:
                    WorkData_Mode_Edit_2_3();
                    break;

                //船番指定, 船番コピー
                case C.MODE_EDIT_1:
                case C.MODE_COPY_1:
                    WorkData_Mode_Edit_1_Copy_1();
                    break;

                default:
                    return;
            }
        }
        else {
            switch (G.Mode) {
                // 船番指定, 船番コピー
                case C.MODE_EDIT_1:
                case C.MODE_COPY_1:
                    WorkData_Mode_Edit_1_Copy_1();
                    break;

                default:
                    WorkData_Mode_Default();
                    return;
            }
        }

        Text = $@"{C.VIEW_NAME}.{C.PRG_VER}.{G.Mode}"; //Caption
        DataGrid3.Focus();
    }

    /// <summary>
    /// @sm2_Click(3)
    /// データ > コピー
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_3_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「「データ > コピー」が選択されました。");
    }

    /// <summary>
    /// @sm2_Click(4)
    /// データ > 削除（行選択）
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_4_Click(object sender, EventArgs e) {
        MessageBox.Show(@"「データ > 削除（行選択）」が選択されました。");
    }

    /// <summary>
    /// @sm2_Click(5)
    /// データ > 削除クリア
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_5_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「データ > 削除クリア」が選択されました。");
    }

    /// <summary>
    /// @sm6_Click(1)
    /// データ > 削除（船番選択）
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM2_6_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「データ > 削除（船番選択）」が選択されました。");
    }
}