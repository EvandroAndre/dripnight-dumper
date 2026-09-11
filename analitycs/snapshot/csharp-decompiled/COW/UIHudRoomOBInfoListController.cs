using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudRoomOBInfoListController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PlayerData> _003C_003E9__26_0;

		internal int _003CBuildAllPlayerList_003Eb__26_0(PlayerData a, PlayerData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIHudRoomOBInfoListController _003C_003E4__this;

		public UITable2 nearby;

		internal UITable2.IUITable2Item _003CInitNearbyTable2_003Eb__0()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public int refTeamScId;

		internal int _003CBuildNearbyPlayerList_003Eb__0(PlayerData a, PlayerData b)
		{
			return 0;
		}
	}

	private const float CELL_WIDTH = 420f;

	private const float CELL_HEIGHT = 50f;

	private UIHudRoomOBInfoListView m_View;

	private UITable2 m_PlayerTable2;

	private CMDBIPLGLGA m_GroupMode;

	private bool m_ShowList;

	private ERoomOBInfoTab m_CurrentTab;

	private float m_NearbyListRefreshTimer;

	private static float GetMultiTeamCellHeightForMemberCount(int memberCount)
	{
		return 0f;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitAllPlayerTable2()
	{
	}

	private void InitNearbyTable2()
	{
	}

	private static int GetMaxSquadMembersForGroupMode(CMDBIPLGLGA mode)
	{
		return 0;
	}

	private UITable2.IUITable2Item OpenMultiTeamRowController()
	{
		return null;
	}

	protected override void OnUIOpen()
	{
	}

	private void Update()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void UpdateGroupModeAndLayout()
	{
	}

	private void RefreshCurrentTabContent(bool scrollAllPlayersToSelected = false)
	{
	}

	private void RefreshAllPlayerTable(bool scrollToSelected = false)
	{
	}

	private bool IsSelectedAllPlayerItemVisible()
	{
		return false;
	}

	private void ScrollAllPlayerTableToSelected()
	{
	}

	private bool TryGetSelectedAllPlayerItem(out UITable2.Item item)
	{
		item = null;
		return false;
	}

	private bool ShouldUseSinglePlayerItem()
	{
		return false;
	}

	private List<TeamData> BuildAllPlayerList()
	{
		return null;
	}

	private void RefreshNearbyGrid()
	{
	}

	private List<PlayerData> BuildNearbyPlayerList()
	{
		return null;
	}

	private int GetNearbyObserverReferenceScTeamId()
	{
		return 0;
	}

	private Vector3 GetNearbyReferencePosition()
	{
		return default(Vector3);
	}

	private void ShowInfoList(bool show)
	{
	}

	private void OnPivotFinished()
	{
	}

	private void OnShowBtnClick()
	{
	}

	private void OnClosePanelClick()
	{
	}

	private void OnAllTabClick()
	{
	}

	private void OnNearTabClick()
	{
	}

	private UITable2.IUITable2Item _003CInitAllPlayerTable2_003Eb__11_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitAllPlayerTable2_003Eb__11_1()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
