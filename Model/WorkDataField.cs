namespace WorkDataStudio.Model;

/// <summary>
/// Generic Class
/// </summary>
/// <typeparam name="T"></typeparam>
public class WorkDataField<T>(WorkDataType type, T data) {
    /// <summary>
    /// ワークデータ
    /// </summary>
    private T _data = data;

    /// <summary>
    /// Property Type
    /// </summary>
    public WorkDataType Type { get; } = type;

    /// <summary>
    /// Property Data
    /// </summary>
    public T Data {
        get {
            if (typeof(T) == typeof(string)) {
                return (T)(object)_data.ToString().Trim();
            }

            return _data;
        }
        set => _data = value;
    }
}