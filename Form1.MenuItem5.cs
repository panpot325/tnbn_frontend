using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// メニュー項目5
/// </summary>
public partial class Form1 {
    /// <summary>
    /// [P]データ
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem GetMenuItem5() {
        var menuItem = new ToolStripMenuItem() { Text = @"[P]データ(&P)" };
        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("自動作成しない", MenuItem_SM5_1_Click),
                CreateMenuItem("自動作成する（西基準）", MenuItem_SM5_2_Click),
                CreateMenuItem("自動作成する（東基準）", MenuItem_SM5_3_Click)
            });

        return menuItem;
    }
}