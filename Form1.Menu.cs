using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 {
    /// <summary>
    /// メニュー項目配列
    /// </summary>
    /// <returns></returns>
    protected override ToolStripItem[] ToolStripItems() {
        return [
            GetMenuItem1(),
            GetMenuItem2(),
            GetMenuItem3(),
            GetMenuItem4(),
            GetMenuItem5()
        ];
    }
}