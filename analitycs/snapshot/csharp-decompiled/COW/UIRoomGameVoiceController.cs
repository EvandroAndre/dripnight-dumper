using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomGameVoiceController : UIPopupWindowController
{
	private UIRoomGameVoiceView m_View;

	private List<TeammateVoiceView> m_TeammateVoiceViewList;

	private Dictionary<int, TeammateVoiceView> m_TeammatesVoiceViewMap;

	protected UIModelCustomRoom m_Model;

	private EGameVoiceListenMode m_CurrentMode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
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

	public void OpenGameVoice(Vector3 pos)
	{
	}

	private void RefreshToggleView()
	{
	}

	private void RefreshTeammateVoice()
	{
	}

	private void OnLeavedRoom(object[] data)
	{
	}

	private void RefreshVoiceViewPanel()
	{
	}

	private TeammateVoiceView TryCreateTeammate(ref int index)
	{
		return null;
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

	private void SetSpeakerMode(EGameVoiceListenMode mode)
	{
	}

	private void OnVoicePanelMaskClick()
	{
	}

	private void ChangeVoiceRoom(string roomID, string playerID, int mode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
