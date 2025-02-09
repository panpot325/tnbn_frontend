using System;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.Properties;
using WorkDataStudio.share;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;

// ReSharper disable InvertIf
namespace WorkDataStudio;

/// <summary>
/// Entry Point Main
/// </summary>
internal static class Program {
    private static ApplicationContext _mainForm;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
        AppSetting();

        using var mutex = new Mutex(false, Application.ProductName);
        if (!mutex.WaitOne(0, false)) {
            MessageBox.Show(@"既に起動中です。二重起動できません。");
            return;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        G.ClearDebugFile();
        G.pcName = G.GetHostName();
        if (!PgOpen.Connect()) {
            MessageBox.Show(@"データベース接続ができませんでした。");
            return;
        }

        WorkDataType.GetAll();
        if (!WorkDataType.Exists) {
            MessageBox.Show(@$"システム管理者に連絡してください。{Environment.NewLine}加工ワークデータタイプ確認してください。");
            return;
        }

        _mainForm = new ApplicationContext();
        _mainForm.MainForm = FormType.Form3;
        Application.Run(_mainForm);
    }

    /// <summary>
    /// ConfigurationManager.AppSettings
    /// </summary>
    private static void AppSetting() {
        var keys = ConfigurationManager.AppSettings.AllKeys;
        foreach (SettingsProperty property in Settings.Default.Properties) {
            if (keys.Contains(property.Name)) {
                Settings.Default[property.Name] =
                    Convert.ChangeType(GetAppSetting(property.Name), property.PropertyType);
            }
        }
    }

    /// <summary>
    /// GetAppSetting
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    private static string GetAppSetting(string key) {
        return ConfigurationManager.AppSettings[key];
    }

    /// <summary>
    /// ShowForm
    /// </summary>
    /// <param name="form"></param>
    public static void ShowForm(Form form) {
        _mainForm.MainForm = form;
        _mainForm.MainForm.Show();
    }
}