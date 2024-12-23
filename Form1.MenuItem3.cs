using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// メニュー項目3
/// </summary>
public partial class Form1 {
    /// <summary>
    /// その他
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem GetMenuItem3() {
        var menuItem = new ToolStripMenuItem() { Text = @"その他(&E)" };
        menuItem.DropDownItems.AddRange(
            new ToolStripItem[] {
                CreateMenuItem("今日の予定", MenuItem_SM3_1_Click),
                CreateMenuItem("操作説明", MenuItem_SM3_2_Click),
                CreateMenuItem("完了情報", MenuItem_SM3_3_Click)
            });
        return menuItem;
    }
}