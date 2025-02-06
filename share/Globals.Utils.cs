using System.IO;
using System.Text;
using WorkDataStudio.Properties;

namespace WorkDataStudio.share;

/// <summary>
/// Globals
/// </summary>
public partial class Globals {
    /// <summary>
    /// DebugWrite
    /// </summary>
    /// <param name="message"></param>
    public static void DebugWrite(string message) {
        using var sw = new StreamWriter($"{Settings.Default.Dev_Path}/{Settings.Default.Dev_File}", true,
            Encoding.UTF8);
        sw.WriteLine(message);
    }

    /// <summary>
    /// ClearDebugFile
    /// </summary>
    public static void ClearDebugFile() {
        var fileName = $"{Settings.Default.Dev_Path}/{Settings.Default.Dev_File}";
        if (!File.Exists(fileName)) {
            using (File.Create(fileName)) {
            }
        }

        using var fs = new FileStream(fileName, FileMode.Open);
        fs.SetLength(0);
    }
}