using System;
using System.Text;

namespace WorkDataStudio.share;

// ReSharper disable once ClassNeverInstantiated.Global
public class PgDump {
    public static void Dump() {
        // ReSharper disable once ConvertToConstant.Local
        var name = "tnbn_kakowk_data";
        var sb = new StringBuilder();
        sb.Append($"COPY {name} TO '{AppConfig.BackupPath}/{GetFileName(name)}'");
        sb.Append(" WITH CSV HEADER DELIMITER ',' FORCE QUOTE *;");
        sb.Append("");
        Console.WriteLine(sb.ToString());
        PgOpen.PgDump(sb.ToString());
    }

    private static string GetFileName(string name) {
        return $"{name}-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.csv";
    }
}