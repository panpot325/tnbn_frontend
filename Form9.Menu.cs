using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9  {
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
    /// 削除実行
    /// </summary>
    /// <returns></returns>
    private ToolStripMenuItem MenuItemEnter() {
        return CreateMenuItem("削除実行", MenuItem_Enter_Click);
    }
}