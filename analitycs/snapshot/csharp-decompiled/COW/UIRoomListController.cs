using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIRoomListController : UINavigationController, IUIModelDataChangeObserver, IEasyList
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

		public static Func<bool> _003C_003E9__46_0;

		public static Func<bool> _003C_003E9__46_1;

		internal bool _003CInitTabInfo_003Eb__46_0()
		{
			return false;
		}

		internal bool _003CInitTabInfo_003Eb__46_1()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public ERoom.TabType tabType;

		internal bool _003CGetTabIndexByTabType_003Eb__0(StandardTabItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public string guideKey;

		internal void _003CShowFreeRoomCardGuide_003Eb__0()
		{
		}
	}

	private sealed class _003CGameModeGuideCoroutine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRoomListController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CGameModeGuideCoroutine_003Ed__48(int _003C_003E1__state)
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

	private CountDownConfig config;

	private CountDownConfig configQuickJoin;

	private UIModelMall m_ModelMall;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelQRCode m_ModelQRCode;

	private UIModelUser m_ModelUser;

	private UIRoomListView m_View;

	private ERoom.TabType m_RoomTabType;

	private bool m_HasLeagueRequested;

	private bool m_HasWorkshopRequested;

	private bool m_OpenQuickJoin;

	private uint m_MaxRefreshTime;

	private uint m_CurrentRefreshTime;

	private UIRoomModeSelectPopupWindowController m_RoomModeSelectPopupWindowController;

	private UIRoomCardListController m_RoomCardCtrl;

	private bool m_IsRefreshCountDown;

	private bool m_IsQuickJoinCountDown;

	private bool m_PlayedItemTweenAnim;

	private UIPopMenuSmallControler m_GroupPopMenuCtrl;

	private UIPopMenuSmallControler m_ModePopMenuCtrl;

	protected List<PopMenuData> m_PopMenuDataList;

	private RoomBasicInfo m_CurrentQuickJoinRoomInfo;

	private List<FRoomModeSelectData> m_RoomModeSelectDatas;

	private UIStandardDrawerTabController m_DrawerTabCtrl;

	private List<RoomTabInfo> m_RoomTabInfoList;

	private List<StandardTabItemViewData> m_StandatdTabDataList;

	private UIRoomListSettingPreviewController m_RoomListSettingPreviewCtrl;

	private UIRoomListSettingPreviewMinController m_RoomListSettingPreviewMinCtrl;

	private UIModelOptionalDownload m_ModelDownload;

	private uint COOLDOWN_SECONDS => 0u;

	private List<FRoomModeSelectData> RoomModeSelectDatas => null;

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

	private void InitUGCRoomListStyle()
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

	private IEnumerator GameModeGuideCoroutine()
	{
		return null;
	}

	private void HideGameModeGuide()
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

	private uint GetFirstValidMapConfigByMode(uint modeId)
	{
		return 0u;
	}

	private void GenerateGameModeMenuData()
	{
	}

	private void GenerateGroupMenuData()
	{
	}

	private void OnModeSelected(object obj)
	{
	}

	private void OnGroupSelected(object obj)
	{
	}

	private void QuickJoinRoom()
	{
	}

	private void OnQuickJoinCountDownStarted()
	{
	}

	private void OnQuickJoinCountDownEnded()
	{
	}

	private void OnQuickJoinCountDownUpdate()
	{
	}

	private List<EMatch.GameMode> GetCurrentModes()
	{
		return null;
	}

	private void OnBtnQuickJoin()
	{
	}

	public void SearchRoomById(ERoom.Type roomType, string roomId)
	{
	}

	private void OnShowRoomListSettingPreview(object[] param)
	{
	}

	private bool IsSocialPreviewMode(uint gameMode)
	{
		return false;
	}

	private int GetTabIndexByTabType(ERoom.TabType tabType)
	{
		return 0;
	}

	private void SelectTabByRoomTabType(ERoom.TabType tabType)
	{
	}

	private void SelectCasual()
	{
	}

	private void SelectLeagueNormal()
	{
	}

	private void SelectMyRoom()
	{
	}

	private void OnBtnUGCRoomList()
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

	private void ShowFreeRoomCardGuide()
	{
	}

	private void ShowFreeRoomCardRefreshTips()
	{
	}

	private void OnBtnRoomRefresh()
	{
	}

	private void OnBtnRoomCreate()
	{
	}

	private void OnBtnBatchRoomCreate()
	{
	}

	private void RecordJoinFailRoom(object[] param)
	{
	}

	private void UpdateBatchRoom(object[] param)
	{
	}

	private void UpdateRoomCard()
	{
	}

	private void UpdateCreateRoomBtn()
	{
	}

	private void RefreshRoomList(List<RoomBasicInfo> roomList)
	{
	}

	private void OnCountDownStarted()
	{
	}

	private void OnCountDownUpdate()
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void RefreshMyRoomTab()
	{
	}

	private void SetLockState()
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

	private bool _003CInitTabInfo_003Eb__46_2()
	{
		return false;
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
