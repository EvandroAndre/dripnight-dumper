using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSpeakerMuteController : UIBaseController
{
	private bool HasShowTeammateHighVoiceTip;

	private bool m_IsDisconnect;

	private UIHudSpeakerMuteView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	public void RefreshDisconnect(bool isDisconnect)
	{
	}

	public Transform GetMemberVoiceContainer()
	{
		return null;
	}

	private bool ShouldForceEnableVoiceEntry()
	{
		return false;
	}

	private bool GetVoiceEntryEnabled(bool defaultValue)
	{
		return false;
	}

	private void TryOpenGuide()
	{
	}

	private void ShowTeammateHighVoiceTip(object[] data)
	{
	}

	private void OnClicked()
	{
	}

	private void OnClickedDisconnected()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	private void OnSpeakerMuteChanged(bool isSpeakerMute)
	{
	}

	private void onDataInit()
	{
	}

	public void SetToggleEnable2(bool flag)
	{
	}

	public void SetCloseEnabled(bool flag)
	{
	}

	public void RefreshToogleState()
	{
	}

	public void ProcessUGCMute(bool mute)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
