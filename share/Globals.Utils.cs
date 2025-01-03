using System.IO;
using System.Text;
using WorkDataStudio.Properties;

namespace WorkDataStudio.share;

/// <summary>
/// Globals
/// </summary>
public partial class Globals {
    /// <summary>
    /// LogWrite
    /// </summary>
    /// <param name="message"></param>
    public static void LogWrite(string message) {
        using var sw = new StreamWriter($"{Settings.Default.Dev_Path}/Logs.txt", true, Encoding.UTF8);
        sw.WriteLine(message);
    }

    /// <summary>
    /// ファイルの内容をクリアする
    /// </summary>
    public static void ClearDebugFile() {
        var fileName = $"{Settings.Default.Dev_Path}/Data.txt";
        if (!File.Exists(fileName)) {
            using (File.Create(fileName)) {
            }
        }

        using var fs = new FileStream($"{Settings.Default.Dev_Path}/Data.txt", FileMode.Open);
        fs.SetLength(0);
    }
}