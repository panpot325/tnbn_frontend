using System.Windows.Forms;
using WorkDataStudio.Component;

namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 : BasicForm {
    private static bool _activate;

    public new static void Activate() {
        _activate = true;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public Form1() {
        InitComponent();
        Init(@"加工ワークデータ作成");
        DataGrid1_Initialize();
        DataGrid2_Initialize();
        DataGrid3_Initialize();
        DataGrid1.Init(); //@グリッド1の初期化
        DataGrid2.Init(); //@グリッド2の初期化
        DataGrid3.Init(); //@グリッド3の初期化
    }

    /// <summary>
    /// SetPosition
    /// </summary>
    protected override void FormPosition() {
        StartPosition = FormStartPosition.CenterScreen;
        //Left = 10; //仮設定
        //Top = 10; //仮設定
    }

    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
    }
}