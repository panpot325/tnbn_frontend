﻿using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;

namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9 {
    /// <summary>
    /// Process
    /// </summary>
    private void Process() {
        if (string.IsNullOrEmpty(comboBox1.Text)) {
            MessageBox.Show(@"データ削除する船番を選択して下さい。。");
            return;
        }

        if (MessageBox.Show(@$"Sno.{comboBox1.Text} のデータをすべて削除しますか？", "",
                MessageBoxButtons.YesNo) == DialogResult.No) {
            return;
        }

        WorkData.DeleteAll(comboBox1.Text.Trim());
        Mode.SetNew1();
        Close();
        Form1.Activate();
    }
}