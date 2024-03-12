#region

using UnityEngine;

#endregion

public static class BachhhDebug
{
    private const string PrefixNormal = "<b>[Bachhh] </b>";
    private const string PrefixWarning = "<b><color=yellow>[Bachhh] </color></b>";
    private const string PrefixError = "<b><color=red>[Bachhh] </color></b>";
    private const string Prefix = "<b>[Bachhh] </b>";

    public static void Log(object o)
    {
#if UNITY_EDITOR || PROTOTYPE
        Debug.Log(PrefixNormal + o);
#endif
    }

    public static void LogWarning(object o)
    {
#if UNITY_EDITOR || PROTOTYPE
        Debug.LogWarning(PrefixWarning + o);
#endif
    }

    public static void LogError(object o)
    {
#if UNITY_EDITOR || PROTOTYPE
        Debug.LogError(PrefixError + o);
#endif
    }

    public static void Log(object o, BachhhColor color)
    {
#if UNITY_EDITOR || PROTOTYPE
        Debug.Log(string.Format("{0}<color={1}>{2}</color>", Prefix, color.ToString().ToLower(), o));
#endif
    }
}

public enum BachhhColor
{
    White,
    Black,
    Red,
    Green,
    Blue,
    Orange,
    Violet,
    Aqua,
    Gray,
    Magenta,
    Purple,
    Yellow
}