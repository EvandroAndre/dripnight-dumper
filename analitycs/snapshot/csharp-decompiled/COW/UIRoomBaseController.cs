using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public abstract class UIRoomBaseController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	protected enum EGameSettingItemStyle
	{
		Short,
		Long
	}

	public class RoomGameSettingData
	{
		public string Title;

		public string Text;

		public bool PredictToolEnable;

		public bool PredictToolDisable;

		public bool TrapEnable;

		public bool TrapDisable;

		public bool IsDefault;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RoomPlayerInfo> _003C_003E9__73_0;

		public static Action<string> _003C_003E9__115_3;

		public static Action<string> _003C_003E9__115_0;

		internal int _003CRefreshOberserverList_003Eb__73_0(RoomPlayerInfo a, RoomPlayerInfo b)
		{
			return 0;
		}

		internal void _003CStartRoom_003Eb__115_3(string s)
		{
		}

		internal void _003CStartRoom_003Eb__115_0(string s)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public StoreDesc storeDesc;

		internal void _003CStartRoom_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass151_0
	{
		public UIRoomBaseController _003C_003E4__this;

		public UIPopupMessageBoxController quitDialog;

		internal void _003COverwriteBackButtonLogic_003Eb__0()
		{
		}

		internal void _003COverwriteBackButtonLogic_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public ulong accountId;

		internal bool _003CIsSwitchSeat_003Eb__0(RoomGroupInfo data)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass81_0
	{
		public UIRoomBaseController _003C_003E4__this;

		public uint mapConfigID;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003CCheckReconnectPop_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCheckReconnectPop_003Ed__56(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRefreshChatScrollView_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRoomBaseController _003C_003E4__this;

		public float value;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshChatScrollView_003Ed__99(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRefreshPlayerList_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRoomBaseController _003C_003E4__this;

		public List<RoomGroupInfo> currentGroups;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshPlayerList_003Ed__70(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CStartUpdateGameSetting_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRoomBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartUpdateGameSetting_003Ed__71(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public bool IsCloseByRoomHangup;

	private UIRoomTeamInfoController m_TeamInfoCtrl;

	protected int ITEM_WIDTH;

	private const int SOLO_ITEM_HEIGHT = 58;

	private const int DUO_ITEM_HEIGHT = 110;

	private const int QUAD_ITEM_HEIGHT = 214;

	private const int PENTA_ITEM_HEIGHT = 266;

	private const int HEXA_ITEM_HEIGHT = 315;

	private const int DUO_ITEM_HEIGHT_WITH_TEAMINFO = 140;

	private const int QUAD_ITEM_HEIGHT_WITH_TEAMINFO = 246;

	private const int PENTA_ITEM_HEIGHT_WITH_TEAMINFO = 298;

	private const int HEXA_ITEM_HEIGHT_WITH_TEAMINFO = 345;

	protected const int COOLDOWN_SECONDS = 35;

	protected int m_ItemHeight;

	protected UICustomRoomView m_View;

	protected UIModelCustomRoom m_Model;

	protected RoomCreateRuleDataManager m_DataManager;

	private CountDownConfig m_Config;

	private bool m_FirstEnteringIdleStateChecked;

	private UIModelChat m_ChatModel;

	private Queue<UIRoomChatMessageItemController> m_RoomChatMessageItemList;

	protected UIRoomCardListController m_RoomCardCtrl;

	protected UIRoomHangupBtnController m_RoomHangupBtnCtrl;

	protected UIInviteGroupBoxController m_GroupInvitationController;

	protected UILobbyV2InviteGroupBoxController m_LobbyInviteCtrl;

	protected UICustomRoomCountDownWindowController m_CountDownController;

	protected List<UIRoomObserverItemController> m_SpectatorCtrls;

	protected EGameSettingItemStyle m_GameSettingItemStyle;

	private List<UIRoomGameSettingItemController> m_CustomRoomDropListItemList;

	private bool m_UseNewChatStyle;

	private int lastSeatIndex;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	protected bool IsMatchMakingMode;

	protected bool m_IsRoomMatchMaking;

	protected bool m_DisableCodeAndMatchMaking;

	protected bool IsCountingDown;

	private uint m_RemindDelayCall;

	private SceneEditSlotInfo m_CurrentMapSlotInfo;

	private UICustomRoomRankTeamBoardController m_ScoreBoardCtrl;

	protected UGCSimpleDownloadTask m_ResDownloadTask;

	private bool m_IsSmallSizeResAutoDownloadStarted;

	private GameObject m_RemindPlayShot;

	private Coroutine m_CoroutineUpdateGameSetting;

	private Coroutine m_RefreshPlayerListCoroutine;

	private UICountDownController m_SlienceCDCtrl;

	protected EPanelBGType m_CurrentShowType;

	private bool m_NeedTeamVoice;

	private int m_lastRoomId;

	private bool FirstFitScrollView;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected bool IsSocialRoomMode()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshMicBtnPresssedState()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public void ShowHideMicPressedVFX(bool show)
	{
	}

	private IEnumerator CheckReconnectPop()
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	public static void LeaveCustomRoomVoice()
	{
	}

	private void InitCasualRoomAdvSettingUI()
	{
	}

	protected virtual void RefreshAdvRoomSetting()
	{
	}

	private void OnShowLeftInfoBtnClick()
	{
	}

	private void OnScoreBoardBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private static void RecordVoiceTime()
	{
	}

	private void ResetScrollViewWidth()
	{
	}

	private void CancelRemindDelayCall()
	{
	}

	private bool IsSwitchSeat(tcp.RoomInfo info)
	{
		return false;
	}

	protected virtual void RefreshRoomStatus()
	{
	}

	protected virtual void RefreshUIData(bool mapModeChanged)
	{
	}

	private IEnumerator RefreshPlayerList(List<RoomGroupInfo> currentGroups)
	{
		return null;
	}

	private IEnumerator StartUpdateGameSetting()
	{
		return null;
	}

	private void RefreshTeamInfoBtn()
	{
	}

	private void RefreshOberserverList(List<RoomPlayerInfo> spectatorData)
	{
	}

	protected virtual List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	private void UpdateGameSetting(List<RoomGameSettingData> gameSettingDataList)
	{
	}

	private void RefreshLoadout()
	{
	}

	private void RefreshReadyBtn()
	{
	}

	private void OptionalDownloadStateChange()
	{
	}

	private void OnResDownloaderClick(uint mapConfigId)
	{
	}

	private void OnUGCResDownloaderClick()
	{
	}

	private void RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
	}

	private void RefreshWaiting()
	{
	}

	private void OnCustomVoiceRoomChange(int value)
	{
	}

	private void VoiceTeamStart()
	{
	}

	private void VoiceRoomStart()
	{
	}

	private void OnTeamChange()
	{
	}

	private void RefreshChatStyle(bool shouldLeave = false)
	{
	}

	private void RefreshSilenceView()
	{
	}

	private void StartBtnCountDown()
	{
	}

	private void OnCountDownStarted()
	{
	}

	private void OnCountDownFinished()
	{
	}

	protected void RefreshSystemHint()
	{
	}

	private void SetNoMessageActive(bool show)
	{
	}

	private void RefreshLatestMessage()
	{
	}

	private void TryPostRoomWinRateChatMessage()
	{
	}

	private IEnumerator RefreshChatScrollView(float value)
	{
		return null;
	}

	protected virtual void InitItemWidthAndHeight()
	{
	}

	protected void SetGameSettingItemStyle(EGameSettingItemStyle style)
	{
	}

	protected virtual void RefreshRoomCard()
	{
	}

	protected bool IsCreater()
	{
		return false;
	}

	private bool IsShowReadBtn()
	{
		return false;
	}

	private bool IsShowRemindBtn()
	{
		return false;
	}

	private bool IsShowLookOverBtn()
	{
		return false;
	}

	protected abstract bool IsShowInviteBtn();

	protected abstract bool IsShowOB();

	protected abstract bool IsShowToggleDisplayTypeBtn();

	protected abstract bool IsShowInfoPanelOpenBtn();

	protected abstract bool IsShowLoadOut();

	protected abstract proto.EInventory.ItemSubType RoomCardType();

	protected void OnBtnGameStart()
	{
	}

	public virtual bool IsFreeToStartRoom()
	{
		return false;
	}

	protected virtual void StartRoom()
	{
	}

	protected virtual void MatchMaking()
	{
	}

	protected abstract string GetCurrentGameStartInfo();

	protected abstract void OnBtnGameStartCallBack();

	protected virtual void OnBtnMatchMakingCallBack()
	{
	}

	private void OnBtnGameReady()
	{
	}

	private void OnBtnRemind()
	{
	}

	private void OnBtnInvite()
	{
	}

	protected abstract void OnBtnCustomize();

	protected void OnOBShowBtnClick()
	{
	}

	private void OnOBHideBtnClick()
	{
	}

	protected virtual void OnInfoPanelOpenClick()
	{
	}

	protected virtual void OnInfoPanelCloseClick()
	{
	}

	private void OnChatBtnClick()
	{
	}

	private void OnRecruitBtnClick()
	{
	}

	private void OnCopyIDBtnClick()
	{
	}

	private void OnRoomQRCodeBtnClick()
	{
	}

	private void OnRemindSuccess()
	{
	}

	private void OnGetRemind(object[] param)
	{
	}

	private void StopRemindAnim()
	{
	}

	private void OnDisplayTypeBtnChange()
	{
	}

	private void RefreshDisplayTypeLabel()
	{
	}

	private void RefreshGameVoiceBtnView()
	{
	}

	private void OnVoiceJoinRoom(object[] data)
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	protected void UpdateInfoPanelBG(EPanelBGType panelBGType)
	{
	}

	private void OnBackBtnClick()
	{
	}

	protected void LockPlayerActionInCD()
	{
	}

	protected void OnCountDownStart(object[] data)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnSelectedChanged(object[] data)
	{
	}

	private void RefreshRoomCardTip()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected void OnMatchMakingStatechange()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public void ChangeRoomSettingAutoSendMessgae(string msg)
	{
	}

	public void ChangeCustomParamsAutoSendMessage(string msg)
	{
	}

	private void RefreshNormalVoiceBtn()
	{
	}

	public void ShowNormalVoiceBtn(bool show)
	{
	}

	public void ShowNormalVoiceInfoBtn(bool show)
	{
	}

	private void OnSpeakerChange(int value)
	{
	}

	private void RefreshNormalGameVoiceBtnView()
	{
	}

	public bool IsNormalVoiceBtnShow()
	{
		return false;
	}

	private void OnNormalVoiceJoinRoom(object[] data)
	{
	}

	private void OnNormalMicrophoneChanged(object[] data)
	{
	}

	private void OnNormalSpeackerBtnClick()
	{
	}

	private void OnNormalMicBtnClick()
	{
	}

	private void TryRefreshNormalSpeaker()
	{
	}

	public void ShowNormalTeamVoiceGuide()
	{
	}

	private void OnTeamInfoBtnClick()
	{
	}

	private void RefreshReapeatActiveSkillShow(Dictionary<ulong, HashSet<ulong>> accountIDs)
	{
	}

	private void _003COnUIInit_003Eb__50_0(bool isPress)
	{
	}

	private void _003CRefreshSilenceView_003Eb__90_0()
	{
	}

	private void _003CStartRoom_003Eb__115_1()
	{
	}

	private void _003COnBtnRemind_003Eb__121_0()
	{
	}

	private void _003CRefreshRoomCardTip_003Eb__147_0()
	{
	}

	private void _003COnNormalMicBtnClick_003Eb__163_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
