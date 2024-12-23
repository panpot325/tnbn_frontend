using System;
using System.Windows.Forms;

// ReSharper disable MemberCanBeMadeStatic.Local

namespace WorkDataStudio;

/// <summary>
/// メニュー項目
/// </summary>
public partial class Form1 {
    /// <summary>
    /// CreateMenuItem
    /// </summary>
    /// <param name="text"></param>
    /// <param name="handler"></param>
    /// <returns></returns>
    private ToolStripMenuItem CreateMenuItem(string text, EventHandler handler) {
        return new ToolStripMenuItem(
            text,
            null,
            handler
        );
    }
}