using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum EScrollType
	{
		TabBtnClick,
		PosUnChange,
		ScrollToItem
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public UILobbyV2GameAssistWndController _003C_003E4__this;

		public int i;

		public Predicate<IGameAssistItemData> _003C_003E9__0;

		internal bool _003CSetMailRead_003Eb__0(IGameAssistItemData x)
		{
			return false;
		}
	}

	protected UILobbyV2GameAssistWndView m_View;

	private List<UILobbyV2GameAssistTabItemController> m_TabItemList;

	private List<int> m_FirstTabTiltePosList;

	private UIModelGameAssistantIntroduction m_ModelGameAssist;

	private UIModelRankingTips m_ModelRankingTips;

	private const uint TITLE_POS_OFFSET = 5u;

	private ELobbyAssistWndTab m_CurSelectTab;

	private ELobbyAssistDataType m_CurBubbleType;

	private Vector3 m_LastScrollViewPos;

	private Vector2 m_LastScrollViewOffset;

	private int m_ScrollToIndex;

	private int m_LastSyncedTabScrollIndex;

	private float m_ScrollPercent;

	private List<bool> m_HasDataToGetList;

	private List<ulong> m_ReadMailInfoList;

	private bool m_CanUpdateChanegTab;

	private bool m_HasEnteredTipsTab;

	private Vector2 TITLE_SIZE;

	private Vector2 REWARD_SIZE;

	private Vector2 CLANINVITE_SIZE;

	private Vector2 REQUEST_SIZE;

	private Vector2 TIPS_SIZE;

	private Vector2 WISH_SIZE;

	private Vector2 CDN_BIG_SIZE;

	private Vector2 CDN_SMALL_SIZE;

	private Vector2 SQUADTREASURE_SIZE;

	private Vector2 RELAYMART_SIZE;

	private Vector2 HIGHLIGHTMOMENT_SIZE;

	private Vector2 REPORTFEEDBACK_SIZE;

	private Vector2 TODAY_BATTLE_REPORT_SIZE;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void StoreClanInviteData()
	{
	}

	private void InitDictStatePullAgreement()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void SetMailRead()
	{
	}

	private bool CheckAllAssistDataReady()
	{
		return false;
	}

	public void AddMailIdRead(ulong id)
	{
	}

	public void SetViewData(ELobbyAssistDataType curBubbleType)
	{
	}

	public void ReadyRefreshView()
	{
	}

	public UITable2 GetAssistTable2()
	{
		return null;
	}

	public void ShowTabInfoByIndex(int index)
	{
	}

	private void ClearAntiHackReportFeedbackRedDots()
	{
	}

	private void RequestCheckAvailableDiscountCodes(int index)
	{
	}

	public List<UITable2.Item> GetAssistItemList()
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateChangeTab()
	{
	}

	private void InitTableItemTemplate()
	{
	}

	private void RefreshContentByIndex(int index)
	{
	}

	private int GetFirstFitTypeItemToScroll(List<int> typeList)
	{
		return 0;
	}

	private bool CheckTitleChileTypeIsFit(AssistTitleInfo titleInfo, List<int> typeList)
	{
		return false;
	}

	private void SyncTabScrollViewByTabIndex(int index)
	{
	}

	private void RefreshTabHighLight(int index)
	{
	}

	private int GetTitleIndexByTableIndex(int curShowIndex)
	{
		return 0;
	}

	public void ShowRuleCdn(int curShowIndex)
	{
	}

	private int GetTableIndexByTitleIndex(int titleIndex)
	{
		return 0;
	}

	private void RefreshView(bool needRebuild = false, bool firstBuild = false)
	{
	}

	private void SetEmptyContainerState(bool show)
	{
	}

	private void RefreshTableView(List<IGameAssistItemData> dataList, bool needRebuild = false)
	{
	}

	private bool CheckNeedHideLine(ELobbyAssistDataType curType, ELobbyAssistDataType nextType)
	{
		return false;
	}

	private bool CheckUseSmallCdnSize(IGameAssistItemData assistData)
	{
		return false;
	}

	private void Scroll(EScrollType type)
	{
	}

	protected virtual UILobbyV2GameAssistTabItemController OpenTabItem()
	{
		return null;
	}

	private void RefreshTabHighLight(bool isFirstBuild)
	{
	}

	private void RefreshTabView(List<IGameAssistItemData> dataList, bool firstBuild)
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshSquadTreasureView(List<IGameAssistItemData> dataList)
	{
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_4()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_5()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_6()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_7()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_8()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_9()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_10()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_11()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_12()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_13()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_14()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_15()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTableItemTemplate_003Eb__50_16()
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
