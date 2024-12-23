using System.Windows.Forms;
using WorkDataStudio.Component;

namespace WorkDataStudio;

/// <summary>
/// コピー船番一覧フォーム
/// </summary>
public partial class Form2 {
    /// <summary>
    /// メニュー項目配列
    /// </summary>
    /// <returns></returns>
    protected override ToolStripItem[] ToolStripItems() {
        return [
            MenuItem1(),
            MenuItem2(),
            MenuItemEnter()
        ];
    }

    /// <summary>
    /// システム
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItem1() {
        var menuItem = new ToolStripMenuItem() { Text = @"システム" };
        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("取消", MenuItem_SM1_1_Click),
                CreateMenuItem("戻る", MenuItem_SM1_2_Click)
            });

        return menuItem;
    }

    /// <summary>
    /// データ
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItem2() {
        var menuItem = new ToolStripMenuItem() { Text = @"データ" };
        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("船番→新船番", MenuItem_SM2_1_Click),
                CreateMenuItem("全データを表示", MenuItem_SM2_2_Click),
                CreateMenuItem("船番を指定して表示", MenuItem_SM2_3_Click),
                CreateMenuItem("仮付予定日指定して表示", MenuItem_SM2_4_Click),
            });

        return menuItem;
    }

    /// <summary>
    /// 決定
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemEnter() {
        return CreateMenuItem("決定", MenuItem_Enter_Click);
    }
}