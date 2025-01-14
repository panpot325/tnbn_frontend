using WorkDataStudio.Component;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// 船番単位フォーム
/// </summary>
public partial class Form8 : BasicForm {
    /// <summary>
    /// Constructor
    /// </summary>
    public Form8() {
        InitComponent();
        Init(@"船番単位");
    }

    /// <summary>
    /// InitComboBox
    /// </summary>
    protected override void Default() {
        comboBox1.Items.Clear();
        foreach (var sno in SnoIndex.GetAll("desc")) {
            comboBox1.Items.Add(sno.Trim());
        }
    }
}