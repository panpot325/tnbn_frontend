using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// コピー船番選択フォーム
/// </summary>
public partial class Form7  {
    /// <summary>
    /// メニュー項目配列
    /// </summary>
    /// <returns></returns>
    protected override ToolStripItem[] ToolStripItems() {
        return [
            MenuItemCancel(),
            MenuItemEnter()
        ];
    }

    /// <summary>
    /// 戻る
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemCancel() {
        return CreateMenuItem("戻る", MenuItem_Cancel_Click);
    }

    /// <summary>
    /// 決定
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemEnter() {
        return CreateMenuItem("決定", MenuItem_Enter_Click);
    }
}