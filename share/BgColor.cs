using System.Drawing;

namespace WorkDataStudio.share;

/// <summary>
/// BgColor
/// </summary>
public static class BgColor {
    public static readonly Color CLEARED = Color.FromArgb(0, 255, 255, 255); //透明
    public static readonly Color DEFAULT = Color.FromArgb(255, 255, 255); //Default
    public static readonly Color UPDATED = Color.FromArgb(192, 255, 192); //更新対象データ
    public static readonly Color DELETED = Color.FromArgb(255, 255, 192); //削除対象データ
    public static readonly Color INVALID = Color.FromArgb(255, 192, 192); //入力エラーまたはキー重複
    public static readonly Color SELECTED = Color.FromArgb(192, 255, 255); //選択行
    public static readonly Color DISABLED = Color.FromArgb(224, 224, 224); //入力不可
    public static readonly Color S_GUNWALE_N = Color.FromArgb(255, 244, 192); //S舷を作成しない
    public static readonly Color S_GUNWALE_E = Color.FromArgb(255, 192, 255); //S舷を作成（東基準）
    public static readonly Color S_GUNWALE_W = Color.FromArgb(255, 255, 255); //S舷を作成（西基準）
    public static readonly Color P_GUNWALE_N = Color.FromArgb(255, 255, 255); //P舷を作成しない
    public static readonly Color P_GUNWALE_E = Color.FromArgb(192, 192, 255); //P舷を作成（東基準）
    public static readonly Color P_GUNWALE_W = Color.FromArgb(255, 192, 128); //P舷を作成（西基準）
}