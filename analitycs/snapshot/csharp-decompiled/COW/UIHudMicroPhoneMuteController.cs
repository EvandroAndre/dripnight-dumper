using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMicroPhoneMuteController : UIBaseController
{
	private bool m_IsShowSelfLowVoice;

	private UIhudMicroPhoneMuteView m_View;

	private UIModelVoice m_ModelVoice;

	private bool m_IsDisconnect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshMicBtnPresssedState()
	{
	}

	public void ShowHideMicPressedVFX(bool show)
	{
	}

	private void InitIsNewUI()
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

	public void RefreshToogleState()
	{
	}

	public void RefreshMicSprite()
	{
	}

	private bool IsOpenAreaTalk()
	{
		return false;
	}

	private bool ShouldForceEnableVoiceEntry()
	{
		return false;
	}

	private bool GetVoiceEntryEnabled(bool defaultValue)
	{
		return false;
	}

	public void RefreshDisconnect(bool isDisconnect)
	{
	}

	private void OnDisConnectedBtn()
	{
	}

	private void OnMicroPhoneMuteToggleChange()
	{
	}

	private void OnDataInit()
	{
	}

	public void SetMicMute(bool flag)
	{
	}

	public void SetButtonEnable(bool flag)
	{
	}

	private void ShowTurnOnMicTutorial(object[] data)
	{
	}

	public void ProcessUGCMute(bool mute)
	{
	}

	public void ShowMicPermissionDenialTip()
	{
	}

	public void ShowDisconnectTips()
	{
	}

	private void ShowSelfLowVoiceTip(object[] data)
	{
	}

	private void ShowMicTip(string key)
	{
	}

	public void RefreshMicBanView()
	{
	}

	public Transform GetMemberVoiceContainer()
	{
		return null;
	}

	private void ShowTutorialForMicPressed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
