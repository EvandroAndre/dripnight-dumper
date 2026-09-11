using GCommon;

namespace COW;

internal class UIMicPermissionDenialTipsBoxController : UIPopupWindowController
{
	private enum ECloseReason
	{
		CloseBtn = 1,
		LaterBtn,
		GotoBtn,
		TimeOut,
		Others
	}

	private UIHighPingTipsBoxView m_View;

	private float m_AcculatedTime;

	private int m_CountDownLabelTime;

	private ECloseReason m_CloseReason;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnCloseBtn(ECloseReason reason, bool goToSettings)
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void _003COnUIInit_003Eb__6_0()
	{
	}

	private void _003COnUIInit_003Eb__6_1()
	{
	}

	private void _003COnUIInit_003Eb__6_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
