using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipTeamJoinController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	public enum ApplyState
	{
		Normal,
		Applying,
		ApplySuccess,
		CantApplyTeamFull
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<FriendAccountInfo> _003C_003E9__15_0;

		internal bool _003CShowSearchResultView_003Eb__15_0(FriendAccountInfo e)
		{
			return false;
		}
	}

	private UIChampionshipTeamJoinView m_View;

	private UIModelChampionship m_ModelChampionship;

	private UIModelFriends m_ModelFriends;

	private Dictionary<ulong, ApplyState> m_ApplyStates;

	private uint m_ChampionshipType;

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

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void SetChampionshipType(uint championshipType)
	{
	}

	public ApplyState GetApplyState(ulong id)
	{
		return ApplyState.Normal;
	}

	public void SetApplyState(ulong id, ApplyState state)
	{
	}

	private void Search()
	{
	}

	public void ShowSearchResultView()
	{
	}

	private int FriendSort(FriendAccountInfo a, FriendAccountInfo b)
	{
		return 0;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void RefreshEasyListView(List<FriendAccountInfo> data)
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
}
