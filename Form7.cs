using System;
using WorkDataStudio.Component;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// コピー船番選択フォーム
/// </summary>
public partial class Form7 : BasicForm {
    public Form7() {
        InitComponent();
        Init(@"船番単位コピー");
    }

    /// <summary>
    /// InitComboBox
    /// </summary>
    protected override void Default() {
        comboBox1.Items.Clear();
        foreach (var sno in SnoIndex.GetAll("desc")) {
            Console.WriteLine(sno);
            comboBox1.Items.Add(sno.Trim());
        }
    }
}