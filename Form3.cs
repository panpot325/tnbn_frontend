using WorkDataStudio.Component;

// ReSharper disable InvertIf
namespace WorkDataStudio;

/// <summary>
/// 社員番号入力フォーム
/// </summary>
public partial class Form3 : BasicForm {
    /// <summary>
    /// Constructor
    /// </summary>
    public Form3() {
        InitComponent();
        Init(@"社員番号入力");
    }
    
    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
        Width = 360;
        Height = 160;
    }
}