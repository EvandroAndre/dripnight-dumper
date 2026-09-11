using GCommon;
using proto;

namespace COW;

public class UIScreenShotShareMessageWindowController : UIPopupWindowController
{
	protected UIScreenShotShareMessageWindowView m_View;

	protected float m_BeginTime;

	protected float m_EndTime;

	private UIModelShare m_ModelShare;

	private UIUtils.ShareUrlType m_ShareUrlType;

	protected ShareSettingDesc m_ShareSetting;

	private const string SCREEN_SHOT_SHARE_MESSAGE_WINDOW_KEY = "T_37_W_CUTSHARE";

	private uint TimeDelayCallID;

	private uint AnimationDelayCallID;

	private string ImageUrl;

	private ShareImageData m_Data;

	private string ScreenShotUrl;

	private const string OUTANIM = "VFX_UIScreenShotShareMessageWindow_Out";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnScreenShot(object[] data)
	{
	}

	private void OnOtherClick()
	{
	}

	private void OnInviteClick()
	{
	}

	private void OnLineClick()
	{
	}

	private void OnWhatsAppClick()
	{
	}

	private void OnInstagramClick()
	{
	}

	private void ShowDynamicContent()
	{
	}

	private void CloseBtn()
	{
	}

	private void CloseByTime()
	{
	}

	private void Animation()
	{
	}

	private void SendReturnTimeLog()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnPreviewBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
