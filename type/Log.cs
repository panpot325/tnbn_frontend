﻿using System;
using System.IO;
using System.Text;
using WorkDataStudio.Properties;
using WorkDataStudio.share;

namespace WorkDataStudio.type;

// ReSharper disable once ClassNeverInstantiated.Global
public class Log {
    /// <summary>
    /// Sub_LogWrite
    /// </summary>
    /// <param name="message"></param>
    public static void Sub_LogWrite(string message) {
        if (Settings.Default.Log_Write != 1) return;
        using var sw = new StreamWriter($"{Settings.Default.Log_Path}/{Settings.Default.Log_File}", true,
            Encoding.GetEncoding("Shift_JIS"));
        sw.WriteLine($"{DateTime.Now:yyyy/MM/dd HH:mm:ss}\t{message}");
    }

    /// <summary>
    /// WriteLine
    /// </summary>
    /// <param name="message"></param>
    /// <param name="lf"></param>
    public static void WriteLine(string message, bool lf = true) {
        if (!AppConfig.DebugMode) {
            return;
        }

        if (lf) {
            Console.WriteLine(message);
        }
        else {
            Console.Write(message);
        }
    }
}