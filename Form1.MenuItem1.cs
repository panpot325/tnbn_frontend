using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// メニュー項目1
/// </summary>
public partial class Form1 {
    /// <summary>
    /// システム
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem GetMenuItem1() {
        var menuItem = new ToolStripMenuItem() { Text = @"システム(&F)" };
        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("新規・登録", MenuItem_SM1_1_Click),
                CreateMenuItem("新規・登録（対象）", MenuItem_SM1_2_Click, false),
                CreateMenuItem("終了）", MenuItem_SM1_3_Click)
            });

        return menuItem;
    }
}