// ReSharper disable MemberCanBePrivate.Global

namespace WorkDataStudio.share;

public static class Mode {
    // Constant
    public const EMode NEW_1 = EMode.NEW_1;
    public const EMode NEW_2 = EMode.NEW_2;
    public const EMode NEW_3 = EMode.NEW_3;
    public const EMode EDIT_1 = EMode.EDIT_1;
    public const EMode EDIT_2 = EMode.EDIT_2;
    public const EMode EDIT_3 = EMode.EDIT_3;
    public const EMode COPY_1 = EMode.COPY_1;
    public const EMode COPY_2 = EMode.COPY_2;

    // Get / Set
    public static EMode Value { get; set; }

    // Boolean Is
    public static bool IsNew1 => Value == NEW_1;
    public static bool IsNew2 => Value == NEW_2;
    public static bool IsNew3 => Value == NEW_3;
    public static bool IsEdit1 => Value == EDIT_1;
    public static bool IsEdit2 => Value == EDIT_2;
    public static bool IsEdit3 => Value == EDIT_3;
    public static bool IsCopy1 => Value == COPY_1;
    public static bool IsCopy2 => Value == COPY_2;

    // Boolean Set
    public static void SetNew1() {
        Value = NEW_1;
    }

    public static void SetNew2() {
        Value = NEW_2;
    }

    public static void SetNew3() {
        Value = NEW_3;
    }

    public static void SetEdit1() {
        Value = EDIT_1;
    }

    public static void SetEdit2() {
        Value = EDIT_2;
    }

    public static void SetEdit3() {
        Value = EDIT_3;
    }

    public static void SetCopy1() {
        Value = COPY_1;
    }

    public static void SetCopy2() {
        Value = COPY_2;
    }

    /// <summary>
    /// Enum
    /// </summary>
    public enum EMode {
        NEW_1, //新規：登録 @新規
        NEW_2, //新規：登録(西東対象２枚) @新規2
        NEW_3, //新規：連続(Ｆ５) @新規F5
        EDIT_1, //修正：船番指定(船番単位) @船番指定
        EDIT_2, //修正：今日以降(キー単位) @今日以降
        EDIT_3, //修正：今日の予定(キー単位) @今日予定
        COPY_1, //新規：コピー(船番単位) @船番コピー
        COPY_2 //新規：コピー(キー単位) @キーコピー
    }
}