using System;
using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.model;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;
// ReSharper disable MemberCanBeMadeStatic.Local

namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 : Form {
    /// <summary>
    /// SetPosition
    /// </summary>
    private void FormPosition() {
        Width = 1124; //1024
        Height = 764; //734
        Left = (((PRect.Right - PRect.Left) - Width) / 2) + PRect.Left;
        Top = (((PRect.Bottom - PRect.Left) - Height) / 2) + PRect.Top;
        Left = 20; //仮設定
        Top = 20; //仮設定
    }

    /// <summary>
    /// 重複メッセージ
    /// </summary>
    private void WorkDataDuplicateMessage() {
        Text4.Text = $@"キーが重複しています。{Environment.NewLine}";
        Text4.Text += $@"登録処理を中断します。{Environment.NewLine}";
        Text4.Text += $@"正しいキーを入力し直してください。{Environment.NewLine}";
        Text4.ForeColor = Color.Red;
    }
    
    /// <summary>
    /// 重複メッセージ
    /// </summary>
    private void WorkDataValidMessage() {
        Text4.Text = $@"入力値が正しくないデータがある為{Environment.NewLine}";
        Text4.Text += $@"登録処理を中断します。{Environment.NewLine}";
        Text4.Text += $@"正しい値を入力し直してください。{Environment.NewLine}";
        Text4.ForeColor = Color.Red;
    }
    
    /// <summary>
    /// @画面名称表示
    /// </summary>
    private void ViewNameText() {
        Text = $@"{C.VIEW_NAME}.{C.PRG_VER}.{G.Mode}"; //Caption 
    }
    
    /// <summary>
    /// @Del_排他情報
    /// </summary>
    private void ClearExclusive() {
        WorkDataExclusive.Delete(G.staffId, G.pcName); //@Del_排他情報  
    }

    /// <summary>
    /// @ワークデータクリア
    /// </summary>
    private void ClearWorkData() {
        WorkData.Clear();
    }
}