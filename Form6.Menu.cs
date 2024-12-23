using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// 操作説明フォーム
/// </summary>
public partial class Form6  {
    /// <summary>
    /// メニュー項目配列
    /// </summary>
    /// <returns></returns>
    protected override ToolStripItem[] ToolStripItems() {
        return [
            MenuItemCancel()
        ];
    }

    /// <summary>
    /// 戻る
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemCancel() {
        return CreateMenuItem("戻る", MenuItem_Cancel_Click);
    }
}