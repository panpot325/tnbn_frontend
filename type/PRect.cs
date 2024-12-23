using System.Windows.Forms;

namespace WorkDataStudio.type;

/// <summary>
/// Rectクラス
/// </summary>
public class PRect {
    /// Static Instance
    private static readonly PRect _instance = new();

    // Private Members
    private readonly int _left;
    private readonly int _top;
    private readonly int _right;
    private readonly int _bottom;

    // Public Static Property
    public static int Left => _instance._left;
    public static int Top => _instance._top;
    public static int Right => _instance._right;
    public static int Bottom => _instance._bottom;

    /// <summary>
    /// Private Constructor
    /// </summary>
    private PRect() {
        _top = 0;
        _left = 0;
        _right = Screen.PrimaryScreen.Bounds.Width - 1;
        _bottom = Screen.PrimaryScreen.Bounds.Height - 1;
    }
}