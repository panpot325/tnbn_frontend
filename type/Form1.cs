using System;
using System.Timers;
using System.Windows.Forms;
using WorkDataStudio.model;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

// ReSharper disable ConvertIfStatementToSwitchStatement
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 {
    private ErrorStatus[] _errorStatus;
    private int _mx, _my, _grid3Row, _mb;

    /// <summary>
    /// Constructor
    /// </summary>
    public Form1() {
        InitializeComponent();
    }

    /// <summary>
    /// @Form_Load()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e) {
        Console.WriteLine(@"STEP1: Form1_Load");
        Console.WriteLine(DataGrid1.Height);
        _mx = 0;
        _my = 0;
        _mb = 0;
        _grid3Row = 0;
        G.workDataCnt = 0;
        G.copyDataSelCnt = 0;
        G.copyDataPutCnt = 0;
        G.Mode = C.MODE_NEW_1;

        FormPosition();
        MenuStrip();
        ClearVariables();
        ViewNameText();
        
        timer1.Interval = 200;
        //timer1.Enabled = true;
    }

    /// <summary>
    /// @Form_Activate()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Activated(object sender, EventArgs e) {
        Console.WriteLine(@"STEP2: Form1_Activated");
        if (G.pingRetry) {
            G.pingRetry = false;
            return;
        }

        switch (G.Mode) {
            case C.MODE_NEW_1 or C.MODE_NEW_2:
                Process_New();
                break;
            case C.MODE_EDIT_1: //船番指定
                Process_Edit();
                break;
            case C.MODE_COPY_1: //船番コピー
            case C.MODE_COPY_2: //キーコピー
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