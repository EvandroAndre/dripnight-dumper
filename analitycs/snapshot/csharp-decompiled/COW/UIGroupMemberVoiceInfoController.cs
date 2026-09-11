using GCommon;

namespace COW;

internal class UIGroupMemberVoiceInfoController : UIBaseController
{
	private const string m_NoneMicIcon = "UI_Icon_speaker02";

	private const string m_AllMicIcon = "UI_Icon_speaker";

	private const string m_TeamMicIcon = "UI_Icon_speaker_team";

	private const string m_NoneVoiceIcon = "UI_icon_Roomvoice01";

	private const string m_AllVoiceIcon = "UI_icon_Roomvoice";

	private const string m_TeamVoiceIcon = "UI_icon_Roomvoice_team";

	private UIGroupMemberVoiceInfoView m_View;

	private bool m_IsSpeaker;

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

	public void SetViewData(bool isSpeaker)
	{
	}

	private void RefreshUI()
	{
	}

	private void OnClickMaskClick()
	{
	}

	private void OnNoneTabClick()
	{
	}

	private void OnPreMatchTabClick()
	{
	}

	private void OnAllTabClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
