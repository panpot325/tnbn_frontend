using WorkDataStudio.Component;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// 完了情報フォーム
/// </summary>
public partial class Form11 : BasicForm {
    public Form11() {
        InitComponent();
        Init(@"完了情報");
        DataGridView5.Init();
    }

    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
    }

    /// <summary>
    /// Default
    /// </summary>
    protected override void Default() {
        WorkInfo.GetAll();
    }
}