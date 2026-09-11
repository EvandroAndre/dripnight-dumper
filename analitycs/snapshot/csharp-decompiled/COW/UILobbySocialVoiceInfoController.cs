using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbySocialVoiceInfoController : UIBaseController
{
	private bool IsSinglePressBtn;

	public int DefaultMicBgWidth;

	public int DefaultMicBgHeight;

	public static int WIDGET_WIDTH;

	public static int WIDGET_HEIGHT;

	private bool IsSpeaker;

	private bool IsCustomRoomMic;

	private Action CustomRoomMicClick;

	private bool IsCustomRoomSpeaker;

	private UILobbySocialVoiceInfoView m_View;

	private UIModelVoice m_modelVoice;

	private UIModelCustomRoom m_ModelRoom;

	private const int RoomMicGridPosX = 0;

	private Color SelectCol;

	private Color UnSelectCol;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPressedAllBtn()
	{
	}

	private void OnPressedPrematchBtn()
	{
	}

	private void OnGoSettingBtn()
	{
	}

	private void CloseOrHide()
	{
	}

	private void OnToggleBtn()
	{
	}

	private bool IsNearVoiceMode()
	{
		return false;
	}

	private void DispatchListenModeChange(EGameVoiceListenMode mode)
	{
	}

	private void DispatchSpeakerListenModeChange(EGameVoiceListenMode mode)
	{
	}

	private void DispatchSpeakerMuteChange()
	{
	}

	private void SetNearMicrophoneMode(EGameVoiceListenMode mode)
	{
	}

	public void SetSpeaker(bool isSpeaker)
	{
	}

	public void RefreshSingleBtn()
	{
	}

	private void OnPreMatchTeammateCountChange()
	{
	}

	public void SetRoomMicState(Action action)
	{
	}

	private void RefreshUI(EGameVoiceListenMode targetMode)
	{
	}

	private void RefreshPressedBtnUI()
	{
	}

	public override void Show()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshVoiceEffectName()
	{
	}

	private void RefreshMagicSelected()
	{
	}

	private void JoinLobbySocialChannelRoom(EGameVoiceListenMode channel)
	{
	}

	private void ApplyCoupledLobbySocialMode(EGameVoiceListenMode mode)
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

	public void SetRoomSpeakerState()
	{
	}

	private void CloseMicPressed()
	{
	}

	private void OnNoneTabClick_RoomSpeaker()
	{
	}

	private void OnPreMatchTabClick_RoomSpeaker()
	{
	}

	private void OnAllTabClick_RoomSpeaker()
	{
	}

	private void SetSpeakerMode(EGameVoiceListenMode mode)
	{
	}

	private void ChangeVoiceRoom(string roomID, string playerID, int mode)
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
