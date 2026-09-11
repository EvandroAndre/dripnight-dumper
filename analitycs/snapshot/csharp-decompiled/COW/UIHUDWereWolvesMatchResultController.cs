using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

internal class UIHUDWereWolvesMatchResultController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__27_0;

		internal void _003CQuitGame_003Eb__27_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private const int CONST_LEFTCOUNT = 5;

	private UIHUDWereWolvesMatchResultView m_View;

	private bool m_IsLocalPlayerWolf;

	private bool m_IsQuited;

	protected UIModelMatch m_ModelMatch;

	protected MatchStats m_MatchStats;

	protected MatchIncome m_MatchIncome;

	private Dictionary<ulong, UIHUDWereWolvesPlayerResultItem> m_PlayerItemList;

	private float m_EndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void InitDataShow()
	{
	}

	private void InitPlayersInfo(List<IJBHGACEICP> PlayerList)
	{
	}

	private void OnRefreshChatInfo(object[] data)
	{
	}

	private void OnSendChat()
	{
	}

	public void OnEndTimeCome(object[] param)
	{
	}

	private void OnVoice()
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	public void RefreshVoiceButtonState()
	{
	}

	private void Update()
	{
	}

	private void UpdateLeftTimeShow()
	{
	}

	private void OpenSharePage()
	{
	}

	private void FromSharePage()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	private void QuitGame()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnPlayerVoiceStateChange(object[] data)
	{
	}

	private void OnLocalPlayerVoiceStateChange(object[] data)
	{
	}

	private void InitReward()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void ShowReward(MatchIncome income)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}
}
