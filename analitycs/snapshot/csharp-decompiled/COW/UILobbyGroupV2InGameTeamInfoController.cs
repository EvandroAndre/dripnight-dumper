using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

internal class UILobbyGroupV2InGameTeamInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public List<GroupMemberInfo> members;

		internal bool _003CRefreshGrid_003Eb__0(ulong accountID)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public ulong accountID;

		internal bool _003CRefreshGrid_003Eb__1(GroupMemberInfo member)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_2
	{
		public ulong accountID;

		internal bool _003CRefreshGrid_003Eb__2(GroupMemberInfo item)
		{
			return false;
		}
	}

	private UILobbyGroupV2InGameTeamInfoView m_View;

	private UIModelGroup m_ModelGroup;

	private UILobbyV2TeamInfoController m_TeamInfoController;

	private readonly List<UILobbyGroupV2InGameTeamInfoItemController> m_ScrollViewItems;

	private readonly List<UILobbyGroupV2InGameTeamInfoItemController> m_CommonItems;

	private readonly List<ulong> m_MemberOrder;

	private readonly List<GroupMemberInfo> m_SortedMembers;

	private bool m_UseCommonGrid;

	private const int COMMON_GRID_MAX_COUNT = 4;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnAvatarUpdate(object[] data)
	{
	}

	private void OnInteractMuteStateChange(object[] data)
	{
	}

	private void OnLeaveBtnClick()
	{
	}

	private void OnDragableClick()
	{
	}

	public void RefreshGrid()
	{
	}

	private void SetItemsActiveRange(List<UILobbyGroupV2InGameTeamInfoItemController> items, int activeCount)
	{
	}

	private void EnsureItemCount(List<UILobbyGroupV2InGameTeamInfoItemController> items, UIGrid targetGrid, int needed)
	{
	}

	public Vector3 GetBriefBoxCenterPos()
	{
		return default(Vector3);
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshAllItemsSetShare()
	{
	}

	private void RefreshItemListSetShare(List<UILobbyGroupV2InGameTeamInfoItemController> items)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
