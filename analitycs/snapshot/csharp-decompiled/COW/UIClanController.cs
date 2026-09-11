using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanController : UINavigationController, IUIModelDataChangeObserver, ITipsDelegate
{
	public enum ClanTab
	{
		MainPage,
		Members,
		Active,
		ClanWarV2
	}

	public enum ClanWarSubTab
	{
		None,
		ClanWar,
		Championship
	}

	public enum ClanWnd
	{
		None,
		RequestClanWnd
	}

	public enum ClanMemberWnd
	{
		None,
		ApplyWnd
	}

	public class ClanTabData
	{
		public ClanTab m_ClanTab;

		public string m_Title;

		public ETipsType m_RedDot;

		public Action m_OnSelectTab;

		public List<int> m_SubTabs;

		public bool hasRedDot;
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public StandardTabItemViewData mainTabData;

		public UIClanController _003C_003E4__this;

		internal void _003CCreateDrawerTab_003Eb__4()
		{
		}

		internal void _003CCreateDrawerTab_003Eb__5()
		{
		}

		internal bool _003CCreateDrawerTab_003Eb__3()
		{
			return false;
		}

		internal void _003CCreateDrawerTab_003Eb__6()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_1
	{
		public StandardSubTabItemViewData clanWar;

		public StandardSubTabItemViewData clanWarChampionship;

		public _003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCreateDrawerTab_003Eb__0(bool notify)
		{
			return false;
		}

		internal bool _003CCreateDrawerTab_003Eb__1(bool notify)
		{
			return false;
		}

		internal bool _003CCreateDrawerTab_003Eb__2()
		{
			return false;
		}
	}

	private sealed class _003CDelayInit_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIClanController _003C_003E4__this;

		public int targetTab;

		public int targetClanWarSubTab;

		public int targetWnd;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayInit_003Ed__43(int _003C_003E1__state)
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

	private AutoPopup m_AutoPopup;

	protected Color unselectIconColor;

	protected Color selectIconColor;

	private UIClanViewExt m_View;

	private ClanLuckyBagConfigData m_ClanLuckyBagConfigData;

	private UIClanMainPageController m_ClanMainPageController;

	private UIClanMemberPageController m_ClanMemberPageController;

	private UIClanActiveController m_ClanActiveController;

	private UIClanWarV2MainController m_ClanWarMainController;

	private UIClanWarChampionshipController m_ClanWarChampionship;

	private UIClanWarV2RoundChangeController m_ClanWarRoundChangeController;

	private UIClanTrendPageController m_ClanTrendController;

	private UIWidget m_DetailBtnWidget;

	private UICommonGuideController m_GuideCtrl;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelUser m_ModelUser;

	private List<ClanTabData> m_ClanTabDataList;

	private UIClanDrawerTabController m_DrawerTabCtrl;

	private List<StandardTabItemViewData> m_MainTabDataList;

	private List<StandardSubTabItemViewData> m_SubTabDataList;

	private ClanTab m_CurrentClanTab;

	private ClanWarSubTab m_ClanWarSubTab;

	private uint m_ClanWarStageDelayCall;

	private ClanWarV2Stage m_ClanWarStage;

	private const uint GotoLeaderBoardItemId = 0u;

	private bool hasAddTopBarTokenAndJumpBtn;

	private bool m_NeedShowGuideOnClanMainPage;

	private const string BG_LAYER = "Layer_AvatarBG";

	private UIClanTopLeftController m_ClanTopLeftController;

	public bool NeedShowGuideOnClanMainPage => false;

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

	private void Update()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private IEnumerator DelayInit(int targetTab, int targetWnd, int targetClanWarSubTab)
	{
		return null;
	}

	public override void OnNavigationClosed()
	{
	}

	private void RefreshClanPageTopBarShowState(bool showClanTopBar, EClanTopBarShowState showState = EClanTopBarShowState.ClanMainPage)
	{
	}

	void ITipsDelegate.OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void InitClanTabData()
	{
	}

	private string SetClanWarTabTitle()
	{
		return null;
	}

	public void CreateDrawerTab(int targetTab = 0, bool selectDeafultTab = true)
	{
	}

	private void DoLog(ClanTab tabType)
	{
	}

	private void DoLog(ClanWarSubTab tabType)
	{
	}

	private void ShowLeftTabs(bool show)
	{
	}

	private void OnGroupJoin(object[] data)
	{
	}

	private void OnToggleMainPageTabChange()
	{
	}

	private void ChangeTopBar()
	{
	}

	private void AddTopBarTokenAndJumpBtn()
	{
	}

	private void GotoClanLeaderBoard()
	{
	}

	private void GotoClanSearch()
	{
	}

	private void SetJumpBtnState()
	{
	}

	private void RefreshClanCurrencyCnt()
	{
	}

	private void OnToggleActiveChange()
	{
	}

	private void OnToggleMemberListTabChange()
	{
	}

	private void OnTabClanWarSelect()
	{
	}

	private void OnTabChampionshipSelect()
	{
	}

	private void RefreshChampionshipContent()
	{
	}

	private void RefreshClanWarContent()
	{
	}

	private void RecoverUIHiddenByPop()
	{
	}

	private void ShowClanWarMain()
	{
	}

	private void ShowClanWarChampionship()
	{
	}

	private void RefreshDisplayContent(bool needSendEvent = true)
	{
	}

	private void RefreshBottomLeftBtn()
	{
	}

	private void ShowBottomLeftTable(bool show)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void ShowClanMainPageProgressBarGuide(object[] param)
	{
	}

	private void OnClickToken()
	{
	}

	private void OnClanCurrencyBtnClick(object[] data)
	{
	}

	private void OnClanRoomClick()
	{
	}

	private void OnRedPacketClicked()
	{
	}

	private void TryEnableShowRoomListBtnPositively(object[] data)
	{
	}

	private void TryEnableShowRoomListBtnNegatively(object[] data)
	{
	}

	private void TryEnableShowRoomListBtn(object[] data)
	{
	}

	private void OnTrendPageShow()
	{
	}

	private void OnGotoClanTab(uint param)
	{
	}

	public void SelectTabByIndex(ClanTab tab)
	{
	}

	public void SelectTabByIndexAndSubIndex(int tab, int subTab)
	{
	}

	private void RefreshClanWarStage()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void GotoLeaderBoard_ClanActive()
	{
	}

	private void GotoLeaderBoard_ClanWar()
	{
	}

	private void GotoLeaderBoard_ClanWarChmapionship()
	{
	}

	public override void BeforeSharePreview()
	{
	}

	public override void AfterSharePreview()
	{
	}

	private void _003CRefreshClanWarContent_003Eb__66_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeSharePreview()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}
}
