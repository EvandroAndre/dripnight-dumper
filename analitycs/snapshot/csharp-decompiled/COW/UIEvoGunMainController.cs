using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunMainController : UINavigationController, IUIModelDataChangeObserver, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public uint uniqueToken;

		public uint generalToken;

		internal void _003CRefreshTopBarTokens_003Eb__0()
		{
		}

		internal void _003CRefreshTopBarTokens_003Eb__1()
		{
		}

		internal void _003CRefreshTopBarTokens_003Eb__2()
		{
		}
	}

	private bool m_FlagOwnedToggle;

	private UIEvoGunMainView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelEvoPass m_ModelEvoPass;

	private List<int> m_ListPage;

	private UIBaseController[] m_OpenedController;

	private ResourceID m_BgResID;

	private string m_BgCDNStr;

	private ResourceID m_BgEffectResID;

	private UIPrivilegePreviewController.SwitchType m_SwitchType;

	private UINavigationData m_EvoGunNavData;

	private UINewDownloadInfoController m_WeaponModelDownloader;

	private List<SkinOwnAndOpenInfo> m_ShowSkinList;

	private List<EvoGunLevelPickItemData> m_LevelPickItemList;

	private uint m_NaviToSkinID;

	public int m_NaviToWeaponSkinFeature;

	private UIEvoGunKillCountController m_SharedKillCountCtrl;

	private UIEvoGunKillCountController m_MainKillCountCtrl;

	private UIEvoGunTokenChangeSecondConfirm m_TokenChangeSecondConfirmCtrl;

	public int LastClickIndex;

	private bool m_CurrentPreviewIsSpecialToggle;

	private int m_CurrentPreviewWeaponSKinFeature;

	private Dictionary<uint, BaseItemInfo> m_RemainExchangeSkinIdToItemInfoDict;

	private GameObject m_RenameVFX;

	private ResourceID m_RenameVFXResId;

	private readonly uint m_GeneralTokenId;

	private GameObject m_WeaponNameVer2Vfx;

	private UIEvoGunSpecialGiftPopupWndController m_SpecialGiftPopupWndCtrl;

	private UIEVOGunPrevieweController m_UIEVOGunPrevieweCtrl;

	private int m_CurLevelItemIndex;

	private WeaponSkinFeature m_CurWPSkinFeature;

	private SkinOwnAndOpenInfo m_SkinOwnAndOpenInfo;

	private bool m_FirstOpenPage;

	private UIFrontEndPreviewCollectionOnTrialController m_CollectionTrialBtnCtrl;

	private UIWishListBtnController m_WishListBtnController;

	private UIModelWishList m_ModelWishList;

	public UIEvoGunPageState CurrentPageState => UIEvoGunPageState.None;

	public UIBaseController CurPageStateCtrl => null;

	public UIPrivilegePreviewController.SwitchType CurSwitchType => UIPrivilegePreviewController.SwitchType.Gun;

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

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public void RefreshTopBarTokens(uint uniqueToken = 0u, uint generalToken = 0u)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void RefreshHelpButtonView()
	{
	}

	private void RefreshKillCounterCardView()
	{
	}

	private void RefreshSpecialGiftView()
	{
	}

	private bool CheckWeaponModelABReady(uint skinID)
	{
		return false;
	}

	private void SetDefaultUIState()
	{
	}

	private void RequestProto()
	{
	}

	private Type GetClassTypeFromPageState(UIEvoGunPageState pageState)
	{
		return null;
	}

	private void DebugText(string para)
	{
	}

	private void RegisterDelegate()
	{
	}

	private void ShowOwnPickListStateChange()
	{
	}

	private void RefreshPickList(bool flagOwnedToggle, int index = 0, bool forceRefreshListData = true, bool NeedRefreshNoClearAndClick = true)
	{
	}

	private void SyncSkinAndOwnInfoInPreview(SkinOwnAndOpenInfo info)
	{
	}

	private void UpdatePreviewUIState(int wpSKinFeature)
	{
	}

	public void RefreshCollectionTrialBtn()
	{
	}

	private void RefreshNewPrivilege()
	{
	}

	private void RefreshWishListBtn()
	{
	}

	private void SetWishListNodeActive(bool v)
	{
	}

	private void RefreshWeaponName(bool isRestName = false)
	{
	}

	private void RefreshGunKillView()
	{
	}

	private void RefreshWeaponRenameBtn()
	{
	}

	private void OnBtnExchangeRemainToken()
	{
	}

	private void ProcessRenameVFX(ResourceID curRenameVFXResID)
	{
	}

	private void DestroyRenameVFX()
	{
	}

	private void NaviToEasyListItem()
	{
	}

	private uint GetFirstSkinWithFeature(uint skinID, WeaponSkinFeature targetFeature)
	{
		return 0u;
	}

	public void OpenPage(UIEvoGunPageState PageState)
	{
	}

	public void RefreshPreviewComponent(int wpSKinFeature, bool isSpecialToggle = true)
	{
	}

	public void SetSightReskinScopeId(uint scopeId)
	{
	}

	public void SetUIMaskState(bool isShow)
	{
	}

	public void SetSkinAndOwnInfo(SkinOwnAndOpenInfo info)
	{
	}

	public void OnSelectedItem(SkinOwnAndOpenInfo infoData)
	{
	}

	public void ClickLastClickEasyList()
	{
	}

	public void SelectLastClickEasyList()
	{
	}

	public void SwitchChange(UIPrivilegePreviewController.SwitchType type)
	{
	}

	public void RotateWeaponByPageChange(bool isBackButtonClick = false)
	{
	}

	public void ShowTabBrd(UIEvoGunPageState pageState)
	{
	}

	public void SetScreenshotObjActive(bool isBefore)
	{
	}

	public void RefreshShareLabel(SkinOwnAndOpenInfo info)
	{
	}

	public uint GetDetailConWpSkinID()
	{
		return 0u;
	}

	public uint GetNaviConWpSkinID()
	{
		return 0u;
	}

	public void SetRenameVFX()
	{
	}

	public void SetTopBarTokensState()
	{
	}

	public void RefreshRemainTokenForAllWeaponSkins(List<SkinOwnAndOpenInfo> skinList)
	{
	}

	public void SetCloseButtonSprite(string spriteName)
	{
	}

	public void SetCloseButtonBGActive(bool flag)
	{
	}

	private void OnInterfaceMaskClick()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void OnUpgradePopupFinish(uint skinID)
	{
	}

	private void OnZoomBtnClick()
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	public void OnRenameBtnClick()
	{
	}

	private void OnSpecialGiftBtnClick()
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

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
