using System;
using System.Text;
using WorkDataStudio.Component;

namespace WorkDataStudio;

/// <summary>
/// 操作説明フォーム
/// </summary>
public partial class Form6 : BasicForm {
    public Form6() {
        InitComponent();
        Init(@"操作説明");
    }

    /// <summary>
    /// FormSize
    /// </summary>
    protected override void FormSize() {
        Width = 720;
        Height = 720;
    }

    /// <summary>
    /// Default
    /// </summary>
    protected override void Default() {
        var sb = new StringBuilder();
        sb.Append($"≪ メニューの説明　≫{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【  取　消  】: 画面をクリアします。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【読込−船番指定】: 一船分のデータを表示します。{Environment.NewLine}");
        sb.Append($"　　　　　　　　※左側の明細をダブルクリックするとデータの追加が可能です。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【読込−今日以降】: 仮付予定日が本日以降のデータを表示します。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【  登　録  】: 変更(緑)があるデータ若しくは、削除対象(黄)のデータのみ{Environment.NewLine}");
        sb.Append($"                    データベースに更新します。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【  コピー  】: コピー元一覧からデータをコピーできます。{Environment.NewLine}");
        sb.Append($"　　　　　　　　※１船番単位でのコピーの場合、左側の明細をダブルクリック{Environment.NewLine}");
        sb.Append($"　　　　　　　　　　するとデータの追加が可能です。{Environment.NewLine}");
        sb.Append($"　　　　　　　　※２コピー一覧から選択したコピーに関しては、必ず、{Environment.NewLine}");
        sb.Append($"　　　　　　　　　　キー項目(船番/ブロック/部材/舷)から変更して下さい。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【  削　除  】: カーソルがあるデータ(青)に対し、削除対象(黄)にします。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【  削除ｸﾘｱ 】: カーソルがあるデータ(青)に対し、削除対象解除(白)にします。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}【今日の予定】: 今日の仮付予定のデータを表示します。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}≪ その他　≫{Environment.NewLine}");
        sb.Append($"　・新規登録時、１件分のデータ入力が完了後、『Ｆ５』キーを押すと{Environment.NewLine}");
        sb.Append($"　　メモリ上に格納され、続けて同一船番のデータ入力が可能です。{Environment.NewLine}");
        sb.Append($"　・新規登録時と船番指定読込時は、[Ｓ]データを作成する／しないの選択が{Environment.NewLine}");
        sb.Append($"　　可能です。但し、既存の[Ｓ]データは上書きされます。{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}");
        sb.Append($"{Environment.NewLine}≪　略称　の説明　≫{Environment.NewLine}");

        textBox1.Text = sb.ToString();
        textBox1.SelectionStart = 0;
    }
}