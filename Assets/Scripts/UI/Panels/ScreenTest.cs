public class ScreenTest : UIPanel
{
    public static ScreenTest Instance { get; private set; }

    public override UiPanelType GetId()
    {
        return UiPanelType.ScreenTest;
    }

    public static void Show()
    {
        var newInstance = (ScreenTest) GUIManager.Instance.NewPanel(UiPanelType.ScreenTest);
        Instance = newInstance;
        newInstance.OnAppear();
    }

    public override void OnAppear()
    {
        if (isInited)
            return;

        base.OnAppear();

        Init();
    }

    private void Init()
    {
    }

    protected override void RegisterEvent()
    {
        base.RegisterEvent();
    }

    protected override void UnregisterEvent()
    {
        base.UnregisterEvent();
    }

    public override void OnDisappear()
    {
        base.OnDisappear();
        Instance = null;
    }
}