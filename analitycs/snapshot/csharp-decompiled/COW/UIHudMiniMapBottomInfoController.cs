using GCommon;

namespace COW;

internal class UIHudMiniMapBottomInfoController : UIBaseController
{
	private UIHudMiniMapBottomInfoView m_View;

	private MiniMapBottomInfoEvent m_Data;

	private MutableString m_CountdownStr;

	private bool m_HasTimeWarning;

	private uint m_VfxHolderID;

	private float m_TickCount;

	private const float TICK_INTERVAL = 0.1f;

	private int m_RemainSecond;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetUIData(GEvent data)
	{
	}

	private void Update()
	{
	}

	private void UpdateCountDown(float remainSecond)
	{
	}

	private void ShowRemainSecond(int remainSecond)
	{
	}

	private void UpdateProgress()
	{
	}

	private float DefaultGetProgress()
	{
		return 0f;
	}

	private void _003CSetUIData_003Eb__14_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
