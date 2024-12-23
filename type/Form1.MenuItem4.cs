using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// メニュー項目4
/// </summary>
public partial class Form1 {
    /// <summary>
    /// [S]データ1
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem GetMenuItem4() {
        var menuItem = new ToolStripMenuItem() { Text = @"[S]データ(&S)" };
        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("自動作成しない", MenuItem_SM4_1_Click),
                CreateMenuItem("自動作成する（西基準）", MenuItem_SM4_2_Click),
                CreateMenuItem("自動作成する（東基準）", MenuItem_SM4_3_Click)
            });

        return menuItem;
    }
}