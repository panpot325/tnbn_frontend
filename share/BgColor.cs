using System.Drawing;

namespace WorkDataStudio.share;

/// <summary>
/// BgColor
/// </summary>
public static class BgColor {
    public static readonly Color CLEARED = Color.FromArgb(0, 0xFF, 0xFF, 0xFF); //透明
    public static readonly Color DEFAULT = Color.FromArgb(255, 255, 255); //Default
    public static readonly Color UPDATED = Color.FromArgb(0xC0, 0xFF, 0xC0); //更新対象データ
    public static readonly Color DELETED = Color.FromArgb(0xFF, 0xFF, 0xC0); //削除対象データ
    public static readonly Color INVALID = Color.FromArgb(0xFF, 0xC0, 0xC0); //入力エラーまたはキー重複
    public static readonly Color SELECTED = Color.FromArgb(0xC0, 0xFF, 0xFF); //選択行
    public static readonly Color DISABLED = Color.FromArgb(0xE0, 0xE0, 0xE0); //入力不可
    public static readonly Color S_GUNWALE_N = Color.FromArgb(0xFF, 0xE0, 0xC0); //S舷を作成しない
    public static readonly Color S_GUNWALE_E = Color.FromArgb(0xFF, 0xC0, 0xFF); //S舷を作成（東基準）
    public static readonly Color S_GUNWALE_W = Color.FromArgb(0xFF, 0xFF, 0xFF); //S舷を作成（西基準）
    public static readonly Color P_GUNWALE_N = Color.FromArgb(0xFF, 0xFF, 0xFF); //P舷を作成しない
    public static readonly Color P_GUNWALE_E = Color.FromArgb(0xC0, 0xC0, 0xFF); //P舷を作成（東基準）
    public static readonly Color P_GUNWALE_W = Color.FromArgb(0xFF, 0xC0, 0x80); //P舷を作成（西基準）
}