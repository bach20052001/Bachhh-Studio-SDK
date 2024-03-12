using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "BachhhGameSetting", menuName = "Bachhh Studio/Game Setting")]
public class BachhhGameSetting : ScriptableObject
{
    [BoxGroup("Identifier")]
    public string gameName = "Prototype";

    [BoxGroup("Identifier")]
    public string packageName = "com.bachhh.prototype";

    [HorizontalGroup("A", LabelWidth = 100), PropertySpace(10, 10)]
    public string gameVersion = "1.0";

    [HorizontalGroup("A"), PropertySpace(10, 10)]
    public int bundleVersion = 1;

    [HorizontalGroup("A"), PropertySpace(10, 10)]
    public int buildVersion = 0;

    [PropertySpace(10, 20), Header("Appstore ID (iOS Only)")]
    public string appstoreId;

    [Space]
#if UNITY_ANDROID
    
    [BoxGroup("Ads IDs")]
    public string androidAppKey;
    
    [BoxGroup("Ads IDs")]
    public string admobAndroidId;
    
#elif UNITY_IOS
    
    [BoxGroup("Ads IDs")]
    public string iosAppKey;

    [BoxGroup("Ads IDs")]
    public string admobIosId;

#endif

#if UNITY_EDITOR
    [Button(ButtonSizes.Large, ButtonStyle.Box)]
    [BoxGroup("Ads IDs"), PropertySpace(10, 0), LabelText("Verify mediated network adapters"), GUIColor(0.4f, 0.8f, 1)]
    public static void VerifyRequiredAdapter()
    {
        BachhhTools.CheckRequiredNetworks();
    }
#endif

    [BoxGroup("Ads IDs"), Space]
    public List<string> aoaListIds;

#if UNITY_EDITOR
    [Button(ButtonSizes.Large, ButtonStyle.Box)]
    [BoxGroup("Ads IDs"), PropertySpace(10, 0), LabelText("Sync ids from Bachhh server"), GUIColor(0.4f, 0.8f, 1)]
    public static void SyncIdFromHyperCatServer()
    {
        BachhhTools.GetGameIdFromServer();
    }
#endif

    [Space, Header("Analytic")]
    public string firebaseEventPrefix = "bachhhPrototype";

    [Space, Header("Screen Orientation")]
    public ScreenOrientation aoaOrientation = ScreenOrientation.Portrait;

#if UNITY_EDITOR
    public UIOrientation deviceOrientation = UIOrientation.Portrait;
    
    [Button]
    public static void SaveGameSetting()
    {
        BachhhTools.SaveGameSetting();
    }
#endif
}