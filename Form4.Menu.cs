using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// コピー船番単位フォーム
/// </summary>
public partial class Form4 {
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
    /// 抽出
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemEnter() {
        return CreateMenuItem("抽出", MenuItem_Enter_Click);
    }
}