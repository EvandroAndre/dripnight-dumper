using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudGameVoiceController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudGameVoiceView m_View;

	private HashSet<BHGGAEEHJCO> m_TeammateIDList;

	private Dictionary<int, TeammateVoiceView> m_TeammatesVoiceViewMap;

	private Dictionary<int, AllPlayerVoiceView> m_AllPlayerVoiceViewMap;

	private UIHudMicroPhoneMuteController m_microCtrl;

	private UIHudSpeakerMuteController m_speakCtrl;

	private bool m_ClosedShowed;

	private bool m_IsShowSingle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshRoomMuteAllState()
	{
	}

	private void OnTeammateMuteStateChange(object[] data)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnMuteStateChange(object[] data)
	{
	}

	public void OnVoicePanelMaskClick()
	{
	}

	public bool IsVoicePnaelMaskShow()
	{
		return false;
	}

	private void OnSpeakerMuteAllBtnClicked()
	{
	}

	private bool IsOpenAreaTalk()
	{
		return false;
	}

	public bool IsOpenPrivilegeRoomVoice()
	{
		return false;
	}

	public void OnSpeakerchanged(object[] data)
	{
	}

	public bool HasTeammate()
	{
		return false;
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	public void SetMicroCtrl(UIHudMicroPhoneMuteController ctrl)
	{
	}

	public void setspeakerCtrl(UIHudSpeakerMuteController ctrl)
	{
	}

	public UIHudMicroPhoneMuteController GetMicroCtrl()
	{
		return null;
	}

	public UIHudSpeakerMuteController GetspeakerCtrl()
	{
		return null;
	}

	private void RefreshToggleView()
	{
	}

	private void RefreshTeammateVoice(bool initOrAdd = false, bool skipBehaviorMuteChange = false)
	{
	}

	private void OnJoinedRoom(object[] data)
	{
	}

	private void OnLeavedRoom(object[] data)
	{
	}

	private void RefreshVoiceViewPanel(bool initAdd = false)
	{
	}

	private void RefreshAllPlayerViewPanel()
	{
	}

	private void TryInitAllPlayerVoiceView()
	{
	}

	private TeammateVoiceView TryCreateTeammate(ref int index, ref int size_height)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnUGCMute(bool mute)
	{
	}

	private void OnReportToggleClick()
	{
	}

	private void OnReportCloseClick()
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

	private void ProcessPrivilegeRoomVoiceAll()
	{
	}

	public void ShowMicPermissionDenialTip()
	{
	}

	public Vector2 GetSelfSize()
	{
		return default(Vector2);
	}

	public void RefreshDisconnect(bool isDisconnected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
