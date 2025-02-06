using System;
using System.Timers;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// ネットワーク状況確認フォーム
/// </summary>
public partial class Form10 {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Form10_Load(object sender, EventArgs e) {
        Log.WriteLine(@"Form2_Load");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Form10_Activated(object sender, EventArgs e) {
        Log.WriteLine(@"Form2_Activated");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void timer1_Elapsed(object sender, ElapsedEventArgs e) {
        Log.WriteLine(@"Form2_timer1_Elapsed");
    }
}