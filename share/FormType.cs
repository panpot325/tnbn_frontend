using System.Windows.Forms;

namespace WorkDataStudio.share;

/// <summary>
/// FormType
/// </summary>
public static class FormType {
    public static Form Form1 => new Form1(); //加工ワークデータ作成
    public static Form Form2 => new Form2(); //コピー船番一覧
    public static Form Form3 => new Form3(); //社員番号入力
    public static Form Form4 => new Form4(); //コピー船番選択
    public static Form Form5 => new Form5(); //コピー仮付け予定日選択
    public static Form Form6 => new Form6(); //操作説明
    public static Form Form7 => new Form7(); //コピー船番単位
    public static Form Form8 => new Form8(); //船番単位
    public static Form Form9 => new Form9(); //船番単位削除
    public static Form Form10 => new Form10(); //ネットワーク状況
    public static Form Form11 => new Form11(); //完了情報
}