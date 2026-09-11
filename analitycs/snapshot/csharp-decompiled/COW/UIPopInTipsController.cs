using GCommon;

namespace COW;

internal class UIPopInTipsController : UIPopupWindowController
{
	private UIPopInTipsView m_View;

	private const int AUTO_SHOW_DETAIL_COUNTDOWN = 10;

	private ulong m_UserID;

	private string m_LockRegion;

	private float m_CountDownTime;

	protected override void OnUIInit()
	{
	}

	public void Update()
	{
	}

	private void OnClickRejectBtn()
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private bool CanUpdateCountDown()
	{
		return false;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetData(ulong userId, string nickname, string lockRegion)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
