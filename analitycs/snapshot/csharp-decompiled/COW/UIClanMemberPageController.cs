using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanMemberPageController : UIPreviewBaseController, IEasyList, IUIModelDataChangeObserver
{
	private enum EnumSortState
	{
		None,
		AscendingOrder,
		DescendingOrder
	}

	private enum EnumSortType
	{
		None,
		WeeklyActiveness,
		TotalActiveness,
		WeeklyClanWarPoint,
		TotalClanWarPoint,
		Status
	}

	public class ClanMemberData
	{
		public ClanMember clanMember;

		public bool expandState;

		public ClanMemberData(ClanMember clanMember, bool expandState)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__61_0;

		public static Action _003C_003E9__63_0;

		internal void _003COnQuitBtnClick_003Eb__61_0()
		{
		}

		internal void _003COnDisbandBtnClick_003Eb__63_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public ulong accountID;

		internal bool _003CShowAvatar_003Eb__0(ClanMemberData x)
		{
			return false;
		}
	}

	private UIClanMemberPageView m_View;

	private UIModelClan m_ModelClan;

	private UIModelTailor m_ModelTailor;

	private UIModelProfile m_ModelProfile;

	private UIModelUser m_ModelUser;

	private UIModelClanTrend m_ModelClanTrend;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private List<ClanMemberData> m_ClanMembersExpand;

	private List<ClanMemberData> m_ClanMembersShrink;

	private List<UISprite> m_DesIconExpandLists;

	private List<UISprite> m_DesIconShrinkLists;

	private bool isCurrentTab;

	public bool IsExpanded;

	private ulong m_SelectedAccountID;

	private EnumSortState m_CurrentExpandSortState;

	private EnumSortType m_CurrentExpandSortType;

	private EnumSortState m_CurrentShrinkSortState;

	private EnumSortType m_CurrentShrinkSortType;

	private bool m_HasInitShrinkEasyList;

	private bool m_HasInitExpandEasyList;

	private Color32 White;

	private Color32 Grey;

	private ulong m_LastClickExpandBtnTs;

	private const ulong SwitchColdDownTime = 3uL;

	private int m_BGWidth;

	private UIRoot m_UIRoot;

	private bool m_HasInitData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitBGWidth()
	{
	}

	private void SetExtendPanel()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public void RefreshViewData(List<ClanMember> memberList)
	{
	}

	public void RefreshOnlyData()
	{
	}

	public void RefreshAvatar()
	{
	}

	private void OnClickExtend()
	{
	}

	private void OnMemberItemSelected(object[] param)
	{
	}

	private void OnTabSelected(object[] param)
	{
	}

	private void OnClickInspect()
	{
	}

	private void OnClickGift()
	{
	}

	private void OnClickBtnShrinkSwitch()
	{
	}

	private void OnClickBtnExtendSwitch()
	{
	}

	private void OnClickWeeklyActivenessShrinkBtn()
	{
	}

	private void OnClickStatusShrinkBtn()
	{
	}

	private void OnClickWeeklyActivenessBtn()
	{
	}

	private void OnClickTotalActivenessBtn()
	{
	}

	private void OnClickWeeklyClanWarPointBtn()
	{
	}

	private void OnClickTotalClanWarPointBtn()
	{
	}

	private void OnClickStatusBtn()
	{
	}

	private void OnClickExitBtn()
	{
	}

	private void OnClickNoLikeBtn()
	{
	}

	private void OnRecruitClick()
	{
	}

	public void OnOpenApplyList()
	{
	}

	private void OnQuitBtnClick()
	{
	}

	private void OnApplyActingLeaderBtnClick()
	{
	}

	private void OnDisbandBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void TryShowPreviewAvatar(ulong accountID)
	{
	}

	private bool ShowAvatar(ulong accountID)
	{
		return false;
	}

	private void ShowLoading(bool show)
	{
	}

	private void RefreshClanNum()
	{
	}

	private void RefreshClanInfo()
	{
	}

	private void RefreshExpandState()
	{
	}

	private void RefreshHighLight()
	{
	}

	private void ClearAllIconExpandColor()
	{
	}

	private void ClearAllIconShrinkColor()
	{
	}

	private int WeeklyActivenessComparison(ClanMemberData p1, ClanMemberData p2)
	{
		return 0;
	}

	private int TotalActivenessComparison(ClanMemberData p1, ClanMemberData p2)
	{
		return 0;
	}

	private int WeeklyClanWarPointComparison(ClanMemberData p1, ClanMemberData p2)
	{
		return 0;
	}

	private int TotalClanWarPointComparison(ClanMemberData p1, ClanMemberData p2)
	{
		return 0;
	}

	private int StatusComparison(ClanMemberData p1, ClanMemberData p2)
	{
		return 0;
	}

	private void SwapComparer(ref ClanMemberData p1, ref ClanMemberData p2)
	{
	}

	private void SortMember()
	{
	}

	private void RefreshkLikeBtnState(object[] data)
	{
	}

	private void UpdateDeputyCaptainButtonState()
	{
	}

	private bool _003COnClickNoLikeBtn_003Eb__58_0(ClanMemberData x)
	{
		return false;
	}

	private void _003COnApplyActingLeaderBtnClick_003Eb__62_0()
	{
	}

	private bool _003CRefreshHighLight_003Eb__72_0(ClanHighLightInfo x)
	{
		return false;
	}

	private bool _003CRefreshkLikeBtnState_003Eb__82_0(ClanMemberData x)
	{
		return false;
	}

	private bool _003CRefreshkLikeBtnState_003Eb__82_1(ulong id)
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
