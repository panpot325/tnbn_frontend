using System;
using WorkDataStudio.model;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

// ReSharper disable InvertIf
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム Sub
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @変数の初期化()
    /// </summary>
    private void ClearVariables() {
        Frame2.Enabled = true;
        Option1_0.Checked = true;
        Text6.Text = "";
        Text4.Text = "";
        Text3.Text = "";
        Text2.Text = "";
        Text1.Text = "";
        _grid3Row = 0;

        if ((G.Mode == C.MODE_COPY_1 || G.Mode == C.MODE_COPY_2)
            && G.copyDataSelCnt > 0
           ) {
            G.workDataCnt = G.copyDataSelCnt;
            return;
        }

        ClearWorkData();
    }

    /// <summary>
    /// @各メッセージを表示()
    /// </summary>
    private void ShowMessage(WorkDataType dataType) {
        if (dataType is null) return;

        Text1.Text = dataType.GetBiko();
        Text2.Text = dataType.GetHani();
        Text3.Text = dataType.GetTani();
        Text6.Text = dataType.GetZero();
        if (G.Mode != C.MODE_NEW_1 && G.Mode == C.MODE_NEW_2) {
            Text4.Text = "";
        }
    }

    /// <summary>
    /// @削除の切替(pIdx As Integer)
    /// </summary>
    /// <param name="pIdx"></param>
    private void UpDelete(int pIdx) {
    }

    /// <summary>
    /// NullZero
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private decimal DecNullZero(string str) {
        return str is null || str.Length == 0 ? 0m : decimal.Parse(str);
    }

    /// <summary>
    /// @DB更新前各項目チェック(pi As Integer) As Integer
    /// @deprecated
    /// </summary>
    /// <param name="pi"></param>
    /// <returns></returns>
    private int Input_Check_DB(int pi) {
        return 0;
    }

    /// <summary>
    /// @キーの存在チェック(pi As Integer) As Integer
    /// WorkData クラスに統合
    /// </summary>
    /// <param name="pi"></param>
    /// <returns></returns>
    private int Exists_Check(int pi) {
        return 0;
    }

    /// <summary>
    /// @Sデータの件数(pi As Integer) As Integer
    /// </summary>
    /// <param name="pi"></param>
    /// <returns></returns>
    private int SData_Check(int pi) {
        return 0;
    }

    /// <summary>
    /// @NullZero(pVal As Variant) As String
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private string NullZero(int value) {
        return "";
    }
}