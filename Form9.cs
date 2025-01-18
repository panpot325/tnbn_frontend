using WorkDataStudio.Component;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9 : BasicForm {
    public Form9() {
        InitComponent();
        Init(@"船番単位削除");
    }

    /// <summary>
    /// InitComboBox
    /// </summary>
    protected override void Default() {
        comboBox1.Items.Clear();
        foreach (var sno in SnoIndex.GetAll("asc")) {
            comboBox1.Items.Add(sno.Trim());
        }
    }

    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
    }
}