using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UILeaderBoardTitleProfileController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum TitleTemplateType
	{
		None,
		RankTitleSpilt,
		WeaponTitleSpilt,
		TitleItem,
		RankTitleItem,
		WeaponTitleItem,
		RankTitleGopos,
		WeaponTitleGopos,
		PeakTitleSpilt,
		PeakTitleItem,
		PeakTitleGopos
	}

	public enum Table2StaticItemType
	{
		None,
		Spilt,
		Gopos
	}

	public class Table2StaticItem
	{
		public Table2StaticItemType Type;

		public string Text;

		public Action ClickAction;

		public string Text2;

		public Table2StaticItem(Table2StaticItemType type, string text, Action clickAction, string text2)
		{
		}
	}

	private UIModelWeaponPower m_WeaponPowerModel;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelLeaderBoardTitle m_LeaderBoardTitleModel;

	private UIModelClanWarV2 m_ClanWarModel;

	private UILeaderBoardTitleProfileView m_View;

	private List<WeaponPowerPlayerTitleInfo> m_WeaponPowerBRList;

	private List<WeaponPowerPlayerTitleInfo> m_WeaponPowerCSList;

	private List<RankingPlayerTitleInfo> m_RankBRList;

	private List<RankingPlayerTitleInfo> m_RankCSList;

	private List<CSPeakPlayerTitleInfo> m_PeakCSList;

	private List<GuildWarPlayerTitleInfo> m_ClanWarList;

	private uint m_ChooseTitleID;

	private uint m_NewBRTitleID;

	private uint m_SelectedBRTitleID;

	private uint m_NewCSTitleID;

	private uint m_SelectedCSTitleID;

	private uint m_NewClanTitleID;

	private uint m_SelectedClanTitleID;

	private uint m_NewBRRankTitleID;

	private uint m_SelectedBRRankTitleID;

	private uint m_NewCSRankTitleID;

	private uint m_SelectedCSRankTitleID;

	private uint m_NewPeakCSTitleID;

	private uint m_SelectedPeakCSTitleID;

	private int m_LastSelectIndex;

	private bool m_IsLocalPLayer;

	private ulong m_AccountID;

	private ELeaderBoardTitleType m_CurTitleType;

	private const string GM_TITLE_TIP = "T_46_LYF_RANKBOARD_GMTIPS";

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

	public void SetIsLocalPlayer(bool isLocalPLayer, ulong accountID)
	{
	}

	public void RefreshUI()
	{
	}

	private void InitTemplate()
	{
	}

	private void InitToggleGrid()
	{
	}

	private void RefreshBRList()
	{
	}

	private void RefreshCSList()
	{
	}

	private void RefreshClanList()
	{
	}

	private void RefreshView()
	{
	}

	private void HideInvalidClanWarTitle()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshEmptyNodeStatus()
	{
	}

	private void GetSelectedTitleInfo()
	{
	}

	private void SetEquipTitleID(int compareIndex, bool isBR)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnRemoveBtnClick()
	{
	}

	private void OnBattleRoyalBtnClick(UIToggleButton button)
	{
	}

	private void OnCounterStrikeBtnClick(UIToggleButton button)
	{
	}

	private void OnClanTitleBtnClick(UIToggleButton btn)
	{
	}

	private void RefreshConfirmStateByItemClick(uint chooseTitleID, ELeaderBoardTitleType curTitleType)
	{
	}

	private void RefreshConfirmBtn(bool showConfirm)
	{
	}

	private void GoposBtnClick(ELeaderBoardTitleType type)
	{
	}

	private void OnBtnSetRegionClick()
	{
	}

	public void OnItemClick(int index, uint titleID, ELeaderBoardTitleType titleType)
	{
	}

	public int GetLastSelectIndex()
	{
		return 0;
	}

	public bool IsItemEquip(uint itemTitleID, ELeaderBoardTitleType itemTitleType)
	{
		return false;
	}

	private void UpdateProfilePreferenceLeaderBoardTitle()
	{
	}

	private void RefreshItemState(uint titleID, ELeaderBoardTitleType titleType, bool onlyRefreshEquip = false, bool isEquip = true)
	{
	}

	private int GetDataListIndex(uint titleID, ELeaderBoardTitleType titleType)
	{
		return 0;
	}

	private TitleTemplateType GetTemplateTypeByLeaderBoardTitleType(ELeaderBoardTitleType titleType)
	{
		return TitleTemplateType.None;
	}

	private void RefreshItemStateByTable2Item(UITable2.Item item, uint titleID, ELeaderBoardTitleType titleType, bool onlyRefreshEquip = false, bool isEquip = true)
	{
	}

	private void RefreshInEquipState()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_4()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_5()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_6()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_7()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_8()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__37_9()
	{
		return null;
	}

	private void _003CRefreshBRList_003Eb__39_0()
	{
	}

	private void _003CRefreshBRList_003Eb__39_1()
	{
	}

	private void _003CRefreshCSList_003Eb__40_0()
	{
	}

	private void _003CRefreshCSList_003Eb__40_1()
	{
	}

	private void _003CRefreshCSList_003Eb__40_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
