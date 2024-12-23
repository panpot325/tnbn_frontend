using System;
using System.Timers;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;

// ReSharper disable ConvertIfStatementToSwitchStatement
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @Form_Load()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e) {
        Console.WriteLine(@"STEP1: Form1_Load");
        WorkData.workDataCnt = 0;
        WorkData.copyDataCnt = 0;
        WorkData.copySelectCnt = 0;
        Mode.SetNew1();
        ViewNameText();
        timer1.Interval = 200;
    }

    /// <summary>
    /// @Form_Activate()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Activated(object sender, EventArgs e) {
        Console.WriteLine(@"STEP2: Form1_Activated");
        switch (Mode.Value) {
            case Mode.NEW_1 or Mode.NEW_2: //新規 新規2
                Process_New();
                break;
            case Mode.EDIT_1: //船番指定
                Process_Edit();
                break;
            case Mode.COPY_1 or Mode.COPY_2: //船番コピー キーコピー
                Process_Copy();
                break;
        }
    }

    /// <summary>
    /// @Timer1_Timer()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Elapsed(object sender, ElapsedEventArgs e) {
    }

    /// <summary>
    /// Timer_Dmy_Timer()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void timer2_Elapsed(object sender, ElapsedEventArgs e) {
    }

    /// <summary>
    /// @Form_Unload(Cancel As Integer)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
    }
}