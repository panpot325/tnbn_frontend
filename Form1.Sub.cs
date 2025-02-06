using WorkDataStudio.Model;
using WorkDataStudio.share;
using C = WorkDataStudio.share.Constants;

// ReSharper disable InvertIf
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム Sub
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @画面名称表示
    /// </summary>
    private void ViewNameText() {
        Text = $@"{C.VIEW_NAME}.{C.PRG_VER}.{Mode.Value}"; //Caption 
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
        if (!Mode.IsNew1 && Mode.IsNew2) {
            Text4.Text = "";
        }
    }

    /// <summary>
    /// OptionSet
    /// </summary>
    /// <param name="option"></param>
    /// <param name="frame"></param>
    private void OptionSet(bool option, bool frame = true) {
        Frame2.Enabled = frame;
        Option1_0.Checked = option;
        Option1_1.Checked = !option;
    }

    /// <summary>
    /// MessageClear
    /// </summary>
    private void MessageClear() {
        Text1.Text = "";
        Text2.Text = "";
        Text3.Text = "";
        Text4.Text = "";
        Text6.Text = "";
    }
}