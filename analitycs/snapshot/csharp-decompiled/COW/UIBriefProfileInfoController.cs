using GCommon;

namespace COW;

internal class UIBriefProfileInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private UIBriefProfileInfoView m_View;

	private BaseItemInfo m_PinItemInfo;

	private bool m_isSelf;

	private string m_NickName;

	private ulong m_AccountID;

	private uint m_RankLimitVFXDelayCall;

	private UIGroupMemberVoiceInfoController m_Voice;

	private UIPrivilegeIconController m_PrivilegeIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	public void SetUIData(BaseProfileInfo info, uint showState = 0u)
	{
	}

	public void UpdatePin(uint pinId)
	{
	}

	public UISprite GetPinIcon()
	{
		return null;
	}

	public void SetBgSprite(bool isActive)
	{
	}

	public void SetNickNameLeftAlignment()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnMicBtnClick()
	{
	}

	private void OnSpeackerBtnClick()
	{
	}

	public void RefreshGameVoiceBtnView()
	{
	}

	private void OnMicrophoneListenModeChange(int mode)
	{
	}

	private void OnHighlightRankLimited()
	{
	}

	private void OnSpeakerListnModeChange(int mode)
	{
	}

	private void OnJoinedGameVoiceRoom(object[] data)
	{
	}

	private void OnLeavedGameVoiceRoom(object[] data)
	{
	}

	private void OnRoomHangup(object[] data)
	{
	}

	private void OnRoomHangupEnd(object[] data)
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	private void UpdateNickNameAndAlias()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003CSetUIData_003Eb__12_0()
	{
	}

	private void _003COnHighlightRankLimited_003Eb__22_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
