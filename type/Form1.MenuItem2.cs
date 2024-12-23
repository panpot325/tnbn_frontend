using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// メニュー項目2
/// </summary>
public partial class Form1 {
    /// <summary>
    /// データ
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem GetMenuItem2() {
        var menuItem = new ToolStripMenuItem() { Text = @"データ(&D)" };
        var subItem = new ToolStripMenuItem() { Text = @"読込" };
        subItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("船番指定", MenuItem_SM21_1_Click),
                CreateMenuItem("今日以降", MenuItem_SM21_2_Click)
            });

        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                subItem,
                CreateMenuItem("登録", MenuItem_SM2_2_Click),
                CreateMenuItem("コピー", MenuItem_SM2_3_Click),
                CreateMenuItem("削除（行選択）", MenuItem_SM2_4_Click),
                CreateMenuItem("削除クリア", MenuItem_SM2_5_Click),
                CreateMenuItem("削除（船番選択）", MenuItem_SM2_6_Click),
            });

        return menuItem;
    }
}