using System;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// 完了情報フォーム
/// </summary>
public partial class Form11 {
    /// <summary>
    /// Form11_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Form11_Load(object sender, EventArgs e) {
        Log.WriteLine(@"Form11_Load");
    }

    /// <summary>
    /// Form11_Activated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Form11_Activated(object sender, EventArgs e) {
        Log.WriteLine(@"Form11_Activated");
    }

    /// <summary>
    /// DataGridView5_DoubleClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGridView5_DoubleClick(object sender, EventArgs e) {
        Log.WriteLine(@"DataGridView5_DoubleClick");
        var value = DataGridView5.Row.Cells[1].Value.ToString().Trim();
        DataGridView5.WorkInfo.Ret = string.IsNullOrEmpty(value)
            ? "完了"
            : " ";
        DataGridView5.Row.Cells[1].Value = DataGridView5.WorkInfo.Ret;
    }
}