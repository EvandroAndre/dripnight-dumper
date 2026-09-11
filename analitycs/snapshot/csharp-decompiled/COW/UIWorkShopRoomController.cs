using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class UIWorkShopRoomController : UIRoomBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__17_0;

		public static Action<string> _003C_003E9__18_0;

		public static Action _003C_003E9__30_0;

		public static Action<string> _003C_003E9__63_0;

		internal void _003CMatchMaking_003Eb__17_0(string s)
		{
		}

		internal void _003CMatchMakingWithOutPreCheck_003Eb__18_0(string s)
		{
		}

		internal void _003CShowDownLoadFailedWnd_003Eb__30_0()
		{
		}

		internal void _003CStartRoomWithOutTips_003Eb__63_0(string s)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UGCCreatorLabelConfig authorLabelConfig;

		internal void _003CRefreshUIData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UIWorkShopRoomController _003C_003E4__this;

		public UIRoomMatchMakingWaitingController ctrl;

		internal void _003COnUGCWaitDownloadMap_003Eb__0()
		{
		}
	}

	private List<CommonPopMenuData> m_PopMenuDataList;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCPremium m_ModelUGCPremium;

	private List<UIRoomParamsInRoomItemController> m_ParamsCtrls;

	private bool hasOpenChildMapInfo;

	private List<UIWorkshopModeTagController> m_Tags;

	private static readonly string UGCAutoMathSwitch;

	private UIWorkShopMapInfoDetailController m_WorkshopMapInfoCtrl;

	private UnityWebRequestAsyncOperation m_UnityWebRequest;

	private Vector2 m_WorkshopDesc1DefaultPos;

	private Vector2 m_WorkShopInfoTableDefaultPos;

	private Vector2 m_CustomParamsDefaultPos;

	private Vector2 m_CustomPanelDefaultSize;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void MatchMaking()
	{
	}

	public void MatchMakingWithOutPreCheck()
	{
	}

	private void OnAutoMatchClick()
	{
	}

	private void InitPopMenuDataList()
	{
	}

	protected override bool IsShowInviteBtn()
	{
		return false;
	}

	protected override bool IsShowOB()
	{
		return false;
	}

	protected override bool IsShowInfoPanelOpenBtn()
	{
		return false;
	}

	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return false;
	}

	protected override bool IsShowLoadOut()
	{
		return false;
	}

	protected override EInventory.ItemSubType RoomCardType()
	{
		return EInventory.ItemSubType.ItemSubType_NONE;
	}

	protected override void RefreshRoomCard()
	{
	}

	protected override void OnBtnGameStartCallBack()
	{
	}

	private void DownLoadFailed(object[] data)
	{
	}

	private void ShowDownLoadFailedWnd()
	{
	}

	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	protected override void OnBtnCustomize()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void RefreshUIData(bool mapModeChanged)
	{
	}

	private void OnAuthorBtnClick()
	{
	}

	private void OnPreviewClick()
	{
	}

	protected void OnShowDisclaimer()
	{
	}

	private void OnWorkShopShareClick()
	{
	}

	private void ShareWorkShopCode(object data)
	{
	}

	private bool HasCustomParaRoom()
	{
		return false;
	}

	private void OnSubscriptionBtnClick()
	{
	}

	private void ShowConfirmWindow()
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnCopyCodeBtnClick()
	{
	}

	private void OnOtherBtnClick()
	{
	}

	protected override void OnInfoPanelOpenClick()
	{
	}

	protected override void OnInfoPanelCloseClick()
	{
	}

	private void Report(object data)
	{
	}

	private void RefreshWorkShopView()
	{
	}

	public new void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public new uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void InitItemWidthAndHeight()
	{
	}

	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	private bool NeedSkipTag(string tagKey)
	{
		return false;
	}

	private bool RefreshTags(uint[] tagsInfo, uint[] limitTagsInfo)
	{
		return false;
	}

	public void OnCloseMatchMaking()
	{
	}

	public void OnAutoDisableCodeAndMatchMaking(object[] data)
	{
	}

	protected override void OnBtnMatchMakingCallBack()
	{
	}

	protected override void StartRoom()
	{
	}

	protected override void RefreshAdvRoomSetting()
	{
	}

	protected void StartRoomWithOutTips()
	{
	}

	public void RefreshRoomParams()
	{
	}

	public void RefreshRoomParamsKey()
	{
	}

	public void OnRoomCustomParamsChanged(object[] data)
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

	private void OnUGCWaitDownloadMap(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_MatchMaking()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshRoomCard()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInfoPanelOpenClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInfoPanelCloseClick()
	{
	}

	public new bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitItemWidthAndHeight()
	{
	}

	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnBtnMatchMakingCallBack()
	{
	}

	public void _003C_003EiFixBaseProxy_StartRoom()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshAdvRoomSetting()
	{
	}
}
