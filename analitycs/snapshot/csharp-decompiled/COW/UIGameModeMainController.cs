using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGameModeMainController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum E_ViewState
	{
		Official,
		UGC
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<WorkshopCraftlandRecommendationInfo> _003C_003E9__145_0;

		internal bool _003CCheckCraftlandOfflineGuide1_003Eb__145_0(WorkshopCraftlandRecommendationInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public UIGameModeMainController _003C_003E4__this;

		public UIUGCMapItemController offlineMapItem;

		internal void _003CCheckCraftlandOfflineGuide2_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public UIGameModeMainController _003C_003E4__this;

		public UGCSimpleDownloadTask resDownloadTask;

		internal void _003CRefreshSocialAreaWithUGCMapResDownloader_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public UIGameModeMainController _003C_003E4__this;

		public UGCSimpleDownloadTask resDownloadTask;

		public uint mainTagID;

		internal void _003COnSocialClick2_003Eb__0()
		{
		}

		internal void _003COnSocialClick2_003Eb__1()
		{
		}

		internal void _003COnSocialClick2_003Eb__2()
		{
		}
	}

	private sealed class _003CCorShowCSGuide_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCorShowCSGuide_003Ed__72(int _003C_003E1__state)
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

	private sealed class _003CDelayRefreshLeftHippoCrisisModeView_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshLeftHippoCrisisModeView_003Ed__86(int _003C_003E1__state)
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

	private sealed class _003CLoadVFX_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameModeMainController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadVFX_003Ed__57(int _003C_003E1__state)
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

	private UIGameModeMainView m_View;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelVeteran m_ModelVeteran;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUser m_ModelUser;

	private UIPeriodicRankMapSelectController m_PeriodicRankMapSelectController;

	private UIGameModePeriodicRankInfoController m_PeriodicRankInfoCtrl;

	private UIHippoCrisisGameModeController m_HippoCrisisGameModeCtrl;

	private UIVeteranFirstGameRewardController m_VeteranRewardCtrl;

	private bool m_IsGuest;

	private string TRAINING_GUIDE;

	private string SOCIAL_GUIDE;

	private string FREE_CUSTOM_ROOM;

	private string CRAFTLAND_GAME_MODE;

	private string m_UGCTipTransify;

	private string m_UGCTipPlayerPrefKey;

	private bool m_isEnoughLevel;

	private bool m_isCsRankEnoughLevel;

	private bool m_isBrRankEnoughLevel;

	private bool m_ShowNewModeGuide;

	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelOptionalDownload m_ModelDownload;

	private UIModelLobbyEventBubble m_ModelLobbyEventBubble;

	private UITable2.Item m_NewModeTable2Item;

	private UINewDownloadInfoController m_trainDownloadCtrl;

	private UINewDownloadInfoController m_socialDownloadCtrl;

	private UINewDownloadInfoController m_UGCDownloadCtrl;

	public int CSGuideItemIndex;

	private int m_BRRankItemIndex;

	private uint m_CloseDelayCall;

	private UICommonGuideController m_CSGuideCtrl;

	private Dictionary<ResourceID, Transform> m_AsynLoadEffectDict;

	private Dictionary<uint, Transform> m_AsnyLoadEffectDict2;

	private bool m_DataInit;

	private bool m_IsInGame;

	private int m_RefreshUGCMapsCountDown;

	private uint m_RefreshUGCMapsDelayCall;

	private uint m_UGCOfflineTipDelayCall;

	private uint m_UGCEnterBtnAnimDelayCall;

	private Vector3 m_StartTweenFromRight;

	private Vector3 m_StartTweenToRight;

	private Vector3 m_StartTweenFromLeft;

	private Vector3 m_StartTweenToLeft;

	private float m_TweenPosDeltaLimit;

	private bool m_SwipeTriggered;

	private uint m_SwipeDelayCall;

	private bool m_IsUGCWorkshopEnterWndShowing;

	private E_ViewState m_ViewState;

	private HashSet<string> m_ExposedMapSet;

	private Coroutine m_CSGuideCoroutine;

	private bool m_bIsCSGuideCloseAni;

	public bool IsShowCSGuide;

	public bool hasTriggerCsGuide;

	private Coroutine m_DelayRefreshLeftHippoCrisisModeView;

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

	protected override void OnUIClose()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void AddAynsLoadVFX(ResourceID resourceID, Transform parent)
	{
	}

	private void OnAsyncLoadResFinished(uint ticket, bool success, UnityEngine.Object obj)
	{
	}

	private IEnumerator LoadVFX()
	{
		return null;
	}

	private void InitTable2Template()
	{
	}

	private void InitUGCTalbeTemplate()
	{
	}

	private void SetCraftlandEntryIcon()
	{
	}

	private void CheckUGCExposure(bool force = false)
	{
	}

	private void SetTrainingGuide()
	{
	}

	private void SetSocialGuide()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ShowCSGuide()
	{
	}

	private IEnumerator CorShowCSGuide()
	{
		return null;
	}

	public void CreateCSGuide(UIWidget widget)
	{
	}

	private void OnClickCSGameGuide()
	{
	}

	public void SetUIData()
	{
	}

	private bool IsPresetRoomMode(MapModeData mapModeData)
	{
		return false;
	}

	private UIModelMapOpeningInfo.GameModeSortData CreateGameModeSortData(uint sortId, List<MapModeData> mapModeList)
	{
		return null;
	}

	private UIModelMapOpeningInfo.GameModeSortData CreateSingleMapGameModeSortData(uint sortId, MapModeData mapModeData)
	{
		return null;
	}

	private void ProcessGameModeList(List<UIModelMapOpeningInfo.GameModeSortData> gameModeList)
	{
	}

	private void BuildGameModeTable(List<UIModelMapOpeningInfo.GameModeSortData> gameModeList)
	{
	}

	private void OnFinishBuild()
	{
	}

	private void BuildUGCGameModeTable(List<WorkshopCraftlandRecommendationInfo> info)
	{
	}

	private void ScrollForNotEnoughLevel()
	{
	}

	private void RefreshPeriodicRankMode()
	{
	}

	private IEnumerator DelayRefreshLeftHippoCrisisModeView()
	{
		return null;
	}

	private void RefreshLeftHippoCrisisModeView()
	{
	}

	private void RefreshVeteran()
	{
	}

	private bool ShowLeftHippoCrisisAtLeftBottom()
	{
		return false;
	}

	private void RefreshScrollPos()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCustomRoomClick()
	{
	}

	private void OnTrainingClick2()
	{
	}

	private void OnTrainingClick()
	{
	}

	private void OnSocialClick2()
	{
	}

	private void OnSocialClick()
	{
	}

	public void OnUGCEnterBtnClick()
	{
	}

	private void OnEnterUGC()
	{
	}

	private void OnOldEnterUGC()
	{
	}

	private void OnUGCRoomBtnClick()
	{
	}

	private void OnNormalBtnClick()
	{
	}

	private UIUGCWorkshopEnterWndController GetUGCWorkshopEnterWnd()
	{
		return null;
	}

	private void OnStateShowUIUGCWorkshopEnterWnd()
	{
	}

	private void OnStateCloseUIUGCWorkshopEnterWnd(object[] data)
	{
	}

	public void SelectUGCTab()
	{
	}

	private void CheckCraftlandOfflineGuide2()
	{
	}

	private void ScrollToMapItem()
	{
	}

	private void OnUGCBtnClick()
	{
	}

	private void OnUGCRefreshBtnClick()
	{
	}

	private void UpdateRefreshButtonCountdown()
	{
	}

	private void OnGiftBtnClick()
	{
	}

	private void OnFullScreenBtnClick(GameObject go)
	{
	}

	private void OnFullScreenBtnDragStart(GameObject go)
	{
	}

	private void OnFullScreenBtnDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnFullScreenBtnDragEnd(GameObject go)
	{
	}

	private void OnSceneEditHelpClick()
	{
	}

	private void OnLeaveBtnClick()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshSocialAreaWithUGCMapResDownloader()
	{
	}

	private void RefreshSocialAreaOptionalMapResDownloader()
	{
	}

	private void CorShowItem(object[] data)
	{
	}

	public bool IsInGameModeItemData(MapModeData data, GameModeItemData itemData)
	{
		return false;
	}

	public void ScrollToMap(MapModeData scrollMapData)
	{
	}

	public int GetScrollViewPanelDepth()
	{
		return 0;
	}

	private void OnOpenPeriodicRankMapSelector(object[] data)
	{
	}

	private void Update()
	{
	}

	public override bool NeedSetLobbyObjectVisibleState()
	{
		return false;
	}

	private float GetScrollViewRightDelta(UIScrollView scrollView)
	{
		return 0f;
	}

	private float GetScrollViewLeftDelta(UIScrollView scrollView)
	{
		return 0f;
	}

	private void BindScrollView()
	{
	}

	private void RefreshNextTweenPos(float deltaX)
	{
	}

	private void RefreshPreviousTweenPos(float deltaX)
	{
	}

	private void RefreshNextBtnAlpha(float deltaX)
	{
	}

	private void RefreshPreviousBtnAlpha(float deltaX)
	{
	}

	private void RefreshNextTween(float offset)
	{
	}

	private void RefreshPreviousTween(float offset)
	{
	}

	private void RefreshState(E_ViewState E_ViewState)
	{
	}

	private void CancelSwipeDelayCall()
	{
	}

	private void SetCraftlandGuide()
	{
	}

	private void CheckSocialAreaUGCMapAvailable()
	{
	}

	private bool CheckCraftlandOfflineGuide1()
	{
		return false;
	}

	private string GetUGCTipTransifyKey()
	{
		return null;
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__58_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__58_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__58_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__58_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__58_4()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Template_003Eb__58_5()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitUGCTalbeTemplate_003Eb__59_0()
	{
		return null;
	}

	private void _003CBuildUGCGameModeTable_003Eb__82_0()
	{
	}

	private void _003CUpdateRefreshButtonCountdown_003Eb__111_0()
	{
	}

	private void _003COnDataChanged_003Eb__122_0()
	{
	}

	private void _003CRefreshSocialAreaOptionalMapResDownloader_003Eb__124_0()
	{
	}

	private void _003CBindScrollView_003Eb__134_0()
	{
	}

	private void _003CBindScrollView_003Eb__134_1()
	{
	}

	private void _003CBindScrollView_003Eb__134_2()
	{
	}

	private void _003CBindScrollView_003Eb__134_3()
	{
	}

	private void _003CBindScrollView_003Eb__134_4()
	{
	}

	private void _003CBindScrollView_003Eb__134_6()
	{
	}

	private void _003CBindScrollView_003Eb__134_5()
	{
	}

	private void _003CBindScrollView_003Eb__134_7()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedSetLobbyObjectVisibleState()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
