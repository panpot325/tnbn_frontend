using System;
using System.Windows.Forms;
using WorkDataStudio.type;

namespace WorkDataStudio.Component;

public class BasicForm : Form {
    /// <summary>
    /// CreateForm
    /// </summary>
    protected void Init(string caption) {
        Text = caption;
        FormSize();
        FormPosition();
        MenuStrip();
        Default();
    }

    /// <summary>
    /// CreateMenuStrip
    /// </summary>
    private void MenuStrip() {
        var menuStrip = new MenuStrip();
        SuspendLayout();
        menuStrip.SuspendLayout();
        menuStrip.Items.AddRange(ToolStripItems());
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    /// <summary>
    /// CreateMenuItem
    /// </summary>
    /// <param name="text"></param>
    /// <param name="handler"></param>
    /// <param name="enabled"></param>
    /// <returns></returns>
    protected ToolStripMenuItem CreateMenuItem(string text, EventHandler handler, bool enabled = true) {
        var toolStripMenuItem = new ToolStripMenuItem(
            text,
            null,
            handler
        );
        toolStripMenuItem.Enabled = enabled;
        return toolStripMenuItem;
    }

    // @virtual
    protected virtual void FormSize() {
        Width = 400;
        Height = 160;
    }

    // @virtual
    protected virtual void FormPosition() {
        Left = (PRect.Right - PRect.Left - Width) / 2 + PRect.Left;
        Top = (PRect.Bottom - PRect.Left - Height) / 2 + PRect.Top;
        StartPosition = FormStartPosition.CenterScreen;
    }

    // @virtual
    protected virtual void Default() {
    }

    // @virtual
    protected virtual ToolStripItem[] ToolStripItems() {
        return new ToolStripItem[] { };
    }

    /// <summary>
    /// OpenDialog
    /// </summary>
    /// <param name="form"></param>
    /// <param name="modal"></param>
    protected void OpenDialog(Form form, bool modal = false) {
        if (modal) {
            form.ShowDialog(this);
            form.Dispose();
            return;
        }

        form.Show();
    }
}