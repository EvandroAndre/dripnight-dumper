using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIUGCRoomListController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<RoomBasicInfo> _003C_003E9__75_0;

		internal bool _003CRefreshRoomList_003Eb__75_0(RoomBasicInfo roomInfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UIUGCRoomListController _003C_003E4__this;

		public bool solo;

		public ECustomRoomJoinType joinType;

		internal void _003CJoinProcess_003Eb__0(string code, string group, string groupAbbr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIUGCRoomListController _003C_003E4__this;

		public bool solo;

		internal void _003CSpectateProcess_003Eb__0(string code, string group, string groupAbbr)
		{
		}
	}

	private sealed class _003CInfoTableReposition_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCRoomListController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInfoTableReposition_003Ed__87(int _003C_003E1__state)
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

	private sealed class _003CRefreshTags_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCRoomListController _003C_003E4__this;

		public uint[] limitTagsInfo;

		public uint[] tagsInfo;

		private int _003CMaxTagNum_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTags_003Ed__88(int _003C_003E1__state)
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

	private UIUGCRoomListView m_View;

	private ERoom.TabType m_RoomTabType;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCModeEdit m_ModelUGCModeEdit;

	private bool m_IsRefreshCountDown;

	private bool m_PlayedItemTweenAnim;

	private bool m_IsQuickJoinCountDown;

	private uint m_MaxRefreshTime;

	private uint m_CurrentRefreshTime;

	private UIPopMenuSmallControler m_GroupPopMenuCtrl;

	private UIPopMenuSmallControler m_ModePopMenuCtrl;

	protected List<PopMenuData> m_PopMenuDataList;

	private RoomBasicInfo m_CurrentQuickJoinRoomInfo;

	protected UIUGCHotIndicatorController m_HotCtrl;

	protected UIUGCLikeIndicatorController m_LikeCtrl;

	private UIWorkShopMapInfoDetailController m_WorkshopMapInfoCtrl;

	private List<UIWorkshopModeTagController> m_Tags;

	private SceneEditSlotInfo m_Info;

	private string m_WorkshopCode;

	private EUGCScene m_Scene;

	private EOpenWorkshopDetailFrom m_From;

	private UISceneEditUGCCenterController.ETabIndex m_SourceTabIndex;

	private EUGCWndFrom m_WndFrom;

	private bool m_OpenQuickJoin;

	private UICommonGuideController m_CommonGuideCtrl;

	private int m_Index;

	private SceneEditSlotInfo m_RoomDetailInfo;

	private RoomBasicInfo m_RoomInfo;

	private string m_SharedCode;

	private uint m_HideVFXDelayCall;

	private ECustomRoomJoinScene m_CustomRoomJoinScene;

	private EUGCScene m_CustomRoomMapScene;

	private bool needRefreshRoomInfo;

	private uint COOLDOWN_SECONDS => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public int GetModeFilter()
	{
		return 0;
	}

	public int GetGroupFilter()
	{
		return 0;
	}

	public string GetSearchFilter()
	{
		return null;
	}

	public string GetWorkShopCode()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public void OnRoomCtrlShow(bool resetRefreshCountDown = true)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void RefreshPasteRoomIDBtn()
	{
	}

	private void OnPasteEnableBtnClick()
	{
	}

	private void OnBtnDetailsClick()
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

	private void UpdatePopMenu()
	{
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

	private void RefreshRoomListByModeAndGroup()
	{
	}

	private void OnQuickJoinCountDownStarted()
	{
	}

	private void OnQuickJoinCountDownEnded()
	{
	}

	private bool HaveSameTag(int targetTag, uint[] workshopTags)
	{
		return false;
	}

	private void QuickJoinRoom()
	{
	}

	private void OnBtnQuickJoin()
	{
	}

	private void OnBtnBack()
	{
	}

	public void ResetQuickJoinData()
	{
	}

	private void RecordJoinFailRoom(object[] param)
	{
	}

	private void OnBtnRoomSearch()
	{
	}

	public void SetQuickJoinData(string ShareCode, EUGCScene scene, EOpenWorkshopDetailFrom from, UISceneEditUGCCenterController.ETabIndex sourceTabIndex, EUGCWndFrom wndFrom)
	{
	}

	private void OnBtnRoomRefresh()
	{
	}

	private void OnBtnRoomCreate()
	{
	}

	private void RefreshRoomList(List<RoomBasicInfo> roomList)
	{
	}

	private void OnCountDownStarted()
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void CheckBackGuide()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshRoomTemplateID(List<RoomBasicInfo> roomList)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SelectRoomByIndex(int index)
	{
	}

	private void RefreshRoomDetailInfo()
	{
	}

	private void RefreshRoomCDNMap(string workshopcode, SceneEditSlotInfo roomDetailInfo)
	{
	}

	private IEnumerator InfoTableReposition()
	{
		return null;
	}

	private IEnumerator RefreshTags(uint[] tagsInfo, uint[] limitTagsInfo)
	{
		return null;
	}

	private void OnFullScreenClick()
	{
	}

	private void OnJoinRoom()
	{
	}

	private void OnJoinSpectate()
	{
	}

	public void JoinRoom(ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal)
	{
	}

	private void JoinProcess(bool solo = true, ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal)
	{
	}

	public void JoinSpectate()
	{
	}

	private void SpectateProcess(bool solo = true)
	{
	}

	private void _003CJoinSpectate_003Eb__94_0()
	{
	}

	private void _003CJoinSpectate_003Eb__94_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
