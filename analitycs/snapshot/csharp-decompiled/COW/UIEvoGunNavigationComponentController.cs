using GCommon;
using UnityEngine;

namespace COW;

public class UIEvoGunNavigationComponentController : UIBaseController, IUIModelDataChangeObserver, IUIEvoGunComponent
{
	private UIEvoGunNavigationComponentView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIEVOGunPropertyController m_UINotOwnedEvoGunPropertyCtrl;

	private UIEVOGunPropertyController m_UIOwnedEvoGunPropertyCtrl;

	private UIEvoGunMainController m_MainController;

	private UIEvoGunCarouselController m_CarouselController;

	private SkinOwnAndOpenInfo m_CurOwnAndOpenInfoData;

	private UIModelCollection m_ModelCollection;

	private UIEvoGunNavigationPrivilegeController m_PrivilegeListController;

	private LogNavigationNotOwnedWeapon m_LogNavigationNotOwnedWeapon;

	private UICommonGuideController m_CommonGuidController;

	private Vector3 m_TopRightLinePosForCommon;

	private Vector3 m_TopRightLinePosForShare;

	private UIModelInventory m_ModelInventory;

	private UICommonGuideController CommonGuidController => null;

	private UIEvoGunMainController MainPageController => null;

	private UIEVOGunPropertyController UINotOwnedEvoGunPropertyCtrl => null;

	private UIEVOGunPropertyController UIOwnedEvoGunPropertyCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RegisterDelegate()
	{
	}

	private void InitView()
	{
	}

	private void RefreshViewByPageState()
	{
	}

	private void DebugText(string log)
	{
	}

	private void RefreshTopRightLine()
	{
	}

	private void RefreshCarousel()
	{
	}

	private void OnObtainBtnClick()
	{
	}

	private void OpenDetailPage()
	{
	}

	private void RefreshObtain()
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetScreenshotObjActive(bool isBefore)
	{
	}

	private void ShowGuidWithWidgetAndTime(UIWidget widget, float time, UIAnchor.Side side, int depth)
	{
	}

	private void RefreshLevel()
	{
	}

	private void OnUpgradeBtnClick()
	{
	}

	private void OnQuickEquipBtnClick()
	{
	}

	private void OnDetailsBtnClick()
	{
	}

	private void RefreshQuickEquip()
	{
	}

	private void RefreshNotOwnedProperty()
	{
	}

	private void RefreshOwnedProperty()
	{
	}

	private void ProcessPropertyCtrl(uint weaponSkinIDInProperty, uint weaponSkinIDInSkill)
	{
	}

	private void RefreshOwnedUpgrade(int maxLevel)
	{
	}

	private void RefreshUpgradeRedPoint()
	{
	}

	private void RefreshNotOwnedPriviliages()
	{
	}

	private void RefreshPrivilegeList()
	{
	}

	private void LogUnOwnedViewTime()
	{
	}

	private void DispatchLogUnOwnedViewTime()
	{
	}

	private void Update()
	{
	}

	private void RefreshShareButton()
	{
	}

	public uint GetWpSkinID()
	{
		return 0u;
	}

	public bool IsCoveredByPopupWnd()
	{
		return false;
	}

	public void RefreshPreview(int type = 1, bool isSpecialToggle = true)
	{
	}

	public void SetSightReskinScopeId(uint scopeId)
	{
	}

	public bool ShowNotOwnedPropertyByState(bool state)
	{
		return false;
	}

	public void OnChangeFeatureClick()
	{
	}

	public void ChangeNotOwnedPropertyActiveState(bool state)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEvoGunPageState GetPageState()
	{
		return UIEvoGunPageState.None;
	}

	public void OnSelectPickItem(SkinOwnAndOpenInfo infoData)
	{
	}

	public void SyncSkinOwnAndOpenInfoInMain(SkinOwnAndOpenInfo infoData)
	{
	}

	private void _003CShowGuidWithWidgetAndTime_003Eb__39_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
