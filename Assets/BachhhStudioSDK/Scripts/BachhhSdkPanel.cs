#if UNITY_EDITOR

#region

using System.Collections.Generic;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;
using UnityEngine;

#endregion

public class BachhhSdkPanel : OdinMenuEditorWindow
{
    [MenuItem("Bachhh Studio Toolkit/Toolkit Panel")]
    private static void OpenWindow()
    {
        GetWindow<BachhhSdkPanel>().Show();
    }

    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree();
        tree.Selection.SupportsMultiSelect = false;

        tree.Add("Game Settings", BachhhTools.GetGameSetting());
        tree.Add("Game Config", BachhhTools.GetGameConfig());
        tree.Add("Sound Config", BachhhTools.GetSoundConfig());
        tree.Add("UI Config", BachhhTools.GetUiConfig());
        tree.Add("IAP Config", BachhhTools.GetIapConfig());
        tree.Add("Builder", BachhhTools.GetBuildSupport());

        return tree;
    }
}
#endif