using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using message;
using proto;

namespace COW;

internal class UIWorkshopCreateRoomController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	private enum UGCTab
	{
		None,
		Rooms
	}

	private enum UGCSubTab
	{
		None,
		AdvanceSetting,
		CustomParams
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__91_0;

		internal bool _003COnDataChanged_003Eb__91_0(SceneEditSlotInfo slotinfo)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public string wscode;

		internal bool _003CRefreshWorkShopList_003Eb__0(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003CInfoTableReposition_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWorkshopCreateRoomController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInfoTableReposition_003Ed__64(int _003C_003E1__state)
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

	private sealed class _003CInitDefaultUI_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWorkshopCreateRoomController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDefaultUI_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003CRefreshTags_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWorkshopCreateRoomController _003C_003E4__this;

		public uint[] limitTagsInfo;

		public uint[] tagsInfo;

		private int _003CMaxTagNum_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTags_003Ed__66(int _003C_003E1__state)
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

	protected UIWorkshopCreateRoomView m_View;

	protected UIModelCustomRoom m_CustomRoomModel;

	protected UIModelSceneEdit m_SceneEditModel;

	protected UIModelUGCPremium m_UGCPremium;

	protected uint m_MapConfigId;

	protected string m_Name;

	protected string m_Code;

	protected uint m_MemberNum;

	protected uint m_RoomSetting;

	protected uint m_RoomSetting2;

	protected uint m_RoomSetting3;

	protected UIUGCStandardDrawerTabController m_TabCtrl;

	protected UIRoomCardListController m_RoomCardCtrl;

	protected UIPopMenuSmallControler m_SelectWorkshopCtrl;

	protected UIWorkshopCreateRoomSettingCSAdController m_CSAdController;

	protected UIWorkShopMapInfoDetailController m_WorkshopMapInfoCtrl;

	protected UIUGCHotIndicatorController m_HotCtrl;

	protected UIRoomParamsMainController m_RoomParamsCtrl;

	protected UIUGCLikeIndicatorController m_LikeIndicatorCtrl;

	protected uint m_RoomType;

	protected bool m_IsDetermined;

	protected const int ROOM_CODE_MAX_LENGTH = 10;

	protected List<PopMenuData> m_PopMenuData;

	private List<UIWorkshopModeTagController> m_Tags;

	protected SceneEditSlotInfo m_CurWorkShopInfo;

	protected UIModelSceneEdit.EWorkShopCreateRoomSrc m_CurrentSrc;

	private int m_CurrentSrcIndex;

	protected bool m_NeedDefaultSelect;

	protected bool m_NeedCode;

	protected EUGCScene m_UGCScene;

	protected Dictionary<int, int> m_RoomSrcIndexDic;

	protected bool m_IsRoomSetting;

	protected Dictionary<string, DKPCAEMALDP> m_RoomCustomParamsDict;

	protected DKPCAEMALDP m_RoomCustomParamsSettingData;

	private Dictionary<string, string> m_RoomCustomParamLocDict;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private UnityWebRequestAsyncOperation m_UnityWebRequest;

	protected UGCSimpleDownloadTask m_ResDownloadTask;

	private bool m_IsSmallSizeResAutoDownloadStarted;

	public bool NeedSetDefaultUI;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator InitDefaultUI()
	{
		return null;
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void SetDefaultUI()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitUGCStandardTabs()
	{
	}

	private void InitDefaultGameSettings()
	{
	}

	private void RefreshRoomCard()
	{
	}

	private void InitPopMenus()
	{
	}

	protected void GenerateWorkshopMenuData()
	{
	}

	protected void OnSrcTypeSelected(object obj)
	{
	}

	protected void RefreshWorkShopList(List<SceneEditSlotInfo> mapdata)
	{
	}

	protected List<SceneEditSlotInfo> FilterWorkShopList(List<SceneEditSlotInfo> data)
	{
		return null;
	}

	private void RefreshConfirmBtn()
	{
	}

	protected virtual string GetConfirmBtnLabel()
	{
		return null;
	}

	private EInventory.ItemSubType GetCurrentRoomCardType()
	{
		return EInventory.ItemSubType.ItemSubType_NONE;
	}

	protected bool RoomTypeRelatedCheck()
	{
		return false;
	}

	protected virtual void CalMapConfig()
	{
	}

	protected uint CalWorkshopMap()
	{
		return 0u;
	}

	protected uint CalWorkshopGameMode()
	{
		return 0u;
	}

	private void RefreshMapInfo()
	{
	}

	private IEnumerator InfoTableReposition()
	{
		return null;
	}

	private bool NeedSkipTag(string tagKey)
	{
		return false;
	}

	private IEnumerator RefreshTags(uint[] tagsInfo, uint[] limitTagsInfo)
	{
		return null;
	}

	private void OnRoomSettingClick()
	{
	}

	private void OnCSAdSettingClick()
	{
	}

	private void OnCustomRoomParamsClick()
	{
	}

	private void RepositionAllSettings()
	{
	}

	private void SetGameModeSpecificUI()
	{
	}

	private void UpdateBtnGrid(object[] data)
	{
	}

	public void SetWorkShopViewData(SceneEditSlotInfo info, EUGCScene scene)
	{
	}

	public void SetUGCScene(EUGCScene scene)
	{
	}

	protected void OnWorkshopSelected(object[] data)
	{
	}

	protected bool IsCSMode()
	{
		return false;
	}

	protected void OnBtnConfirm()
	{
	}

	private void CreateRoom()
	{
	}

	protected void CheckAndRecordSelect()
	{
	}

	protected bool RefreshOptionalMapResDownloader(bool showDownloadPop = false)
	{
		return false;
	}

	private void OnUGCResDownloaderClick()
	{
	}

	private void CloseUI(object[] data)
	{
	}

	private void OnBtnFullPreview()
	{
	}

	private void OnBtnAuthor()
	{
	}

	private void OnBtnClose()
	{
	}

	private void OnBtnReset()
	{
	}

	protected void OnOFFBtnClick()
	{
	}

	protected void OnONBtnClick()
	{
	}

	protected void OnDisclaimBtnClick()
	{
	}

	private void OnClickVipIcon()
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

	private void Update()
	{
	}

	public void DownLoadOneFile(string url, string workshopCode)
	{
	}

	private bool IsCurrentWorkShopRoom(string workshopCode)
	{
		return false;
	}

	public void RefreshCurrentRoomParamsLoc(byte[] data)
	{
	}

	private bool _003COnSrcTypeSelected_003Eb__53_0(SceneEditSlotInfo slotinfo)
	{
		return false;
	}

	private void _003COnBtnReset_003Eb__86_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
