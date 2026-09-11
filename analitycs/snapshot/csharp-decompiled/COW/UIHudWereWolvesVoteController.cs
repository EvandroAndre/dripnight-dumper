using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWereWolvesVoteController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HistroyPlayerInfo> _003C_003E9__50_0;

		internal int _003COnRefreshHistroyInfo_003Eb__50_0(HistroyPlayerInfo a, HistroyPlayerInfo b)
		{
			return 0;
		}
	}

	private UIHudWereWolvesVoteView m_View;

	private List<BEIPMEAHGNP> m_VoteList;

	private List<BHGGAEEHJCO> m_SkippedList;

	private List<UIHudWereWolvesVoteIndexController> m_SkippedChildController;

	private UITimeLabelHelper m_TimeHelper;

	private float m_CountDownTime;

	private UIHudWereWolvesVoteIndexController m_SponsorIndex;

	private WereWolvesChatEasyListCallBack m_ChatEasyListCallback;

	private WereWolvesHistroyListCallBack m_HistroyEasyListCallback;

	private UIHudWereWolvesQuickChatScrollController m_QuickChatNode;

	private UIHudWereWolvesSpeakerController m_SpeakerController;

	private uint m_LastQuickPlayerId;

	private Dictionary<int, List<HistroyPlayerInfo>> m_HistroyInfoDic;

	private int m_CurHistroyTab;

	private TutorialEventEnum m_CurVoteTutorialType;

	private bool m_IsMapOpen;

	private bool m_IsChatPanleShowing;

	private float lastLeftTimeS;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	private void RefreshDescription()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnQuickChatItemClick(object[] data)
	{
	}

	private void OnRefreshChatInfo(object[] data)
	{
	}

	private void OnRefreshSponsor(object[] data)
	{
	}

	private void OnVotePlayer()
	{
	}

	private void OnSkipVote()
	{
	}

	public void OnRefreshVoteList(object[] data)
	{
	}

	private void RefreshSkippedList()
	{
	}

	private void RefreshChatNode()
	{
	}

	public void OnNewPhase(object[] param)
	{
	}

	public void OnEndTimeCome(object[] param)
	{
	}

	private void Update()
	{
	}

	private void OnMap()
	{
	}

	private void OnSendChat()
	{
	}

	private void OnQuickChat()
	{
	}

	private void OnMic()
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	private void OnSpeaker()
	{
	}

	private void RefreshVoteButtonState()
	{
	}

	private void OnVoiceChange(object[] data)
	{
	}

	public void RefreshButtonState()
	{
	}

	private int Cmp(BEIPMEAHGNP infoA, BEIPMEAHGNP infoB)
	{
		return 0;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController GetChildController(Transform parent)
	{
		return null;
	}

	public UIEasyListItemController GetHistroyChildController(Transform parent)
	{
		return null;
	}

	public void HideSpeakerNode()
	{
	}

	private void OnRefreshHistroyInfo(object[] data)
	{
	}

	private void OnShowChatPanel()
	{
	}

	private void OnShowHistroyPanel()
	{
	}

	private void OnShowHistroyOne()
	{
	}

	private void OnShowHistroyTwo()
	{
	}

	private void OnShowHistroyThree()
	{
	}

	private void RefreshHistroyList()
	{
	}

	public void OnStartVote()
	{
	}

	private void OnOpenMapTutorial(object[] data)
	{
	}

	private void OnChatTutorial(object[] data)
	{
	}

	private void OnMicTutorial(object[] data)
	{
	}

	private void OnQuickChatTutorial(object[] data)
	{
	}

	private void OnVoteOrSkipTutorial(object[] data)
	{
	}

	private void OnShowContinueTutorial()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
