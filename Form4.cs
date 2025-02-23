﻿using WorkDataStudio.Component;
using WorkDataStudio.type;
using WorkDataStudio.type.index;

namespace WorkDataStudio;

/// <summary>
/// コピー船番単位フォーム
/// </summary>
public partial class Form4 : BasicForm {
    public Form4() {
        InitComponent();
        Init(@"船番選択");
    }

    /// <summary>
    /// InitComboBox
    /// </summary>
    protected override void Default() {
        comboBox1.Items.Clear();
        comboBox2.Items.Clear();
        foreach (var sno in SnoIndex.GetAll("asc")) {
            Log.WriteLine(sno);
            comboBox1.Items.Add(sno.Trim());
            comboBox2.Items.Add(sno.Trim());
        }
    }

    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
    }
}