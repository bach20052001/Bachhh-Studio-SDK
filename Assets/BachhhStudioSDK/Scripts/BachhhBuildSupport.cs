#region

using UnityEngine;
using Sirenix.OdinInspector;

#endregion

[CreateAssetMenu(fileName = "BachhhBuildSupport", menuName = "Bachhh Studio/Build Support")]
public class BachhhBuildSupport : ScriptableObject
{
    [FolderPath]
    public string windowBuildPath = "D:/Bachhh Studio Build";

    [FolderPath]
    public string macOsBuildPath = "/Volumes/SSD/AndroidBuild";

#if UNITY_EDITOR
    [Button(ButtonSizes.Large, ButtonStyle.Box)]
    [InfoBox("Test build")]
    [LabelText("Build APK")]
    [GUIColor(0.4f, 0.8f, 1)]
    [PropertySpace(10, 10)]
    public static void BuildApk()
    {
        BachhhTools.BuildApk();
    }

    [Button(ButtonSizes.Large, ButtonStyle.Box)]
    [InfoBox("Submit build")]
    [LabelText("Build AAB")]
    [GUIColor(0.4f, 0.8f, 1)]
    [PropertySpace(10, 10)]
    public static void BuildAab()
    {
        BachhhTools.BuildAab();
    }
#endif
}