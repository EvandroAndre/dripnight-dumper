using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UITournamentListController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private class RoomTabInfo
	{
		public string Key;

		public Action CB;

		public Func<bool> ShowCondition;

		public ERoom.TabType TabType;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<bool> _003C_003E9__28_0;

		internal bool _003CInitTabInfo_003Eb__28_0()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public ERoom.TabType tabType;

		internal bool _003CGetTabIndexByTabType_003Eb__0(StandardTabItemViewData x)
		{
			return false;
		}
	}

	private CountDownConfig config;

	private UIModelMall m_ModelMall;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelQRCode m_ModelQRCode;

	private UITournamentListView m_View;

	private ERoom.TabType m_RoomTabType;

	private ulong m_EsportsId;

	private bool m_HasTournamentRequested;

	private UIPopMenuSmallControler m_StatePopMenuCtrl;

	protected List<PopMenuData> m_PopMenuDataList;

	private UIStandardDrawerTabController m_DrawerTabCtrl;

	private List<RoomTabInfo> m_RoomTabInfoList;

	private List<StandardTabItemViewData> m_StandatdTabDataList;

	private UIRoomListSettingPreviewController m_RoomListSettingPreviewCtrl;

	private uint COOLDOWN_SECONDS => 0u;

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

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void RefreshPasteRoomIDBtn()
	{
	}

	private void OnPasteEnableBtnClick()
	{
	}

	private void OnQRScanBtnClick()
	{
	}

	private ERoom.TabType ChangeRoomType2TabType(ERoom.Type roomType)
	{
		return ERoom.TabType.TabType_NONE;
	}

	private void InitTabInfo()
	{
	}

	private void CreateTabs()
	{
	}

	private void OnInputChanged()
	{
	}

	private void OnInputSubmit()
	{
	}

	private void OnBtnInputClear()
	{
	}

	private void GenerateGameModeMenuData()
	{
	}

	private void OnStateSelected(object obj)
	{
	}

	private List<EMatch.GameMode> GetCurrentModes()
	{
		return null;
	}

	public void SearchRoomById(ERoom.Type roomType, string roomId)
	{
	}

	private void OnShowRoomListSettingPreview(object[] param)
	{
	}

	private int GetTabIndexByTabType(ERoom.TabType tabType)
	{
		return 0;
	}

	private void SelectTabByRoomTabType(ERoom.TabType tabType)
	{
	}

	private void SelectTournament()
	{
	}

	private void OnBtnRoomSearch()
	{
	}

	private void OnRoomToggleSelect(ERoom.TabType roomType)
	{
	}

	private void UpdatePopMenu()
	{
	}

	private void RefreshRoomListByFilters()
	{
	}

	private void OnBtnRoomRefresh()
	{
	}

	private void RefreshRoomList(List<RoomBasicInfo> tournamentList)
	{
	}

	private void OnCountDownStarted()
	{
	}

	private void OnCountDownFinished()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
