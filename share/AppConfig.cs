﻿using System;
using System.Configuration;
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace WorkDataStudio.share;

/// <summary>
/// ConfigurationManagerラッパークラス
/// </summary>
public static class AppConfig {
    // AppSettings
    public static bool DebugMode = Get<bool>("Debug_Mode", false);
    public static string BackupPath = Get("Backup_Path", "C:\\tanban_renkei\\Backup");

    /// <summary>
    /// 設定ファイルから指定した型のデータを取得
    /// 取得できなかった場合、デフォルト値を返却
    /// </summary>
    /// <typeparam name="T">データ型</typeparam>
    /// <param name="name">名称</param>
    /// <param name="def">デフォルト値</param>
    /// <returns>データ</returns>
    private static T Get<T>(string name, T def = default) {
        if (!Exists(name)) {
            return def;
        }

        try {
            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[name], typeof(T));
        }
        catch (Exception) {
            return def;
        }
    }

    /// <summary>
    /// 指定した名称のデータが設定ファイルに存在するか判定します。
    /// </summary>
    /// <param name="name">名称</param>
    /// <returns>存在する/存在しない</returns>
    private static bool Exists(string name) {
        if (!ConfigurationManager.AppSettings.HasKeys()) {
            return false;
        }

        return ConfigurationManager.AppSettings[name] is not null;
    }
}