using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentSquadTreasureFriendListBoxController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private UIPaymentSquadTreasureFriendListBoxView m_View;

	private UIModelFriends m_ModelFriends;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private bool m_IsShowClanIcon;

	private List<FriendAccountInfoData> m_CachedFriends;

	private uint m_WinkCall;

	private bool m_HasSearch;

	private ulong m_LastRefreshTime;

	private ulong m_CurrentGroupId;

	public ulong CurrentGroupId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void RefreshContent()
	{
	}

	private void OnTweenFinished()
	{
	}

	private void RefreshFriendsList()
	{
	}

	private void CheckAndRequestInTeamAccountIds()
	{
	}

	private void SetFriendUIData()
	{
	}

	private int CompareFriendListInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	private List<FriendAccountInfoData> GetFriendAccountInfoData(List<FriendAccountInfo> list)
	{
		return null;
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	private void OnMaskClick()
	{
	}

	private void ResetSearchInput()
	{
	}

	private void RefreshScrollView()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void UpdateRefreshState(bool inCD = false)
	{
	}

	private void _003COnSearchBtnClick_003Eb__25_0()
	{
	}

	private void _003COnRefreshBtnClick_003Eb__31_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
