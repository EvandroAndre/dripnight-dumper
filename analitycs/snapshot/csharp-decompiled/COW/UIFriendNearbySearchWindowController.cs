using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendNearbySearchWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum EWindowState
	{
		None,
		Searching,
		Result,
		NoResult
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UIFriendNearbySearchWindowController _003C_003E4__this;

		public bool hasResult;

		internal void _003CDelayShowSearchResult_003Eb__0()
		{
		}
	}

	private UIFriendNearbySearchWindowView m_View;

	private EWindowState m_CurrentState;

	private UIModelFriends m_ModelFriends;

	private UIModelLocalization m_ModelLocalization;

	private List<UIModelFriends.NearbyPlayerInfo> m_NearbyPlayerList;

	private uint m_SearchDelayCallId;

	private float m_SearchStartTime;

	private const float MIN_SEARCH_DISPLAY_DURATION = 1f;

	private List<UIFriendNearbyProfileController> m_ProfileControllers;

	private List<GameObject> m_ProfileContainers;

	private int m_SearchSoundTicket;

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

	private void InitProfileContainers()
	{
	}

	private void RegisterEvents()
	{
	}

	private void UnregisterEvents()
	{
	}

	private void SwitchToState(EWindowState newState)
	{
	}

	private void RefreshStateUI()
	{
	}

	private void ShowNoneState()
	{
	}

	private void ShowSearchingState()
	{
	}

	private void ShowResultState()
	{
	}

	private void ShowNoResultState()
	{
	}

	private void UpdatePersistentUI()
	{
	}

	private void UpdateOwnAvatar()
	{
	}

	private void UpdateSearchLabel(EWindowState state)
	{
	}

	private void RefreshPlayerList()
	{
	}

	private void StartSearch()
	{
	}

	private void DelayShowSearchResult(bool hasResult)
	{
	}

	private void ShowSearchResult(bool hasResult)
	{
	}

	private void CancelSearchDelay()
	{
	}

	private void OnNearbyPlayersRequestSuccess()
	{
	}

	private void OnNearbyPlayersRequestFailed()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnSettingBtnClick()
	{
	}

	private void OnQuestionBtnClick()
	{
	}

	private void OnNearbySearchBtnClick()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnAddAllBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
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
