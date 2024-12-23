using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// 完了情報フォーム
/// </summary>
public partial class Form11  {
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
    /// データ更新
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemEnter() {
        return CreateMenuItem("データ更新", MenuItem_Enter_Click);
    }
}