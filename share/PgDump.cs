using System;
using System.Text;

namespace WorkDataStudio.share;

/// <summary>
/// PgDumpクラス
/// </summary>
public static class PgDump {
    /// <summary>
    /// DumpCsv
    /// </summary>
    public static void DumpCsv() {
        foreach (var backUpName in AppConfig.BackUpNames) {
            DumpCsv(backUpName);
        }
    }

    /// <summary>
    /// DumpCsv
    /// </summary>
    /// <param name="tablename"></param>
    /// <returns></returns>
    private static bool DumpCsv(string tablename) {
        var sb = new StringBuilder();
        sb.Append($"COPY tnbn_{tablename} TO '{AppConfig.BackupPath}/{CsvFileName(tablename)}'");
        sb.Append(" WITH CSV ENCODING 'sjis' HEADER DELIMITER ',' FORCE QUOTE *;");
        sb.Append("");
        return PgOpen.PgDump(sb.ToString());
    }

    /// <summary>
    /// CSVファイル名の取得
    /// </summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    private static string CsvFileName(string tableName) {
        return $"{tableName}-{DateTime.Now:yyyy-MM-dd}.csv"; // yyyy-MM-dd-HH-mm-ss
    }
}