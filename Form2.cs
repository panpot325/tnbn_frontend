using WorkDataStudio.Component;

namespace WorkDataStudio;

/// <summary>
/// コピー船番一覧フォーム
/// </summary>
public partial class Form2 : BasicForm {
    public Form2() {
        InitComponent();
        Init(@"コピー選択");
        DataGridView4.Init();
    }

    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
        Width = 800;
        Height = 600;
    }
}