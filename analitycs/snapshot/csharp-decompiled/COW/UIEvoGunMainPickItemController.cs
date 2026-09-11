using GCommon;

namespace COW;

public class UIEvoGunMainPickItemController : UIEasyListItemController
{
	private SkinOwnAndOpenInfo m_Data;

	private SkinOwnAndOpenInfo m_RealNextLevelData;

	private UIEvoGunMainPickItemView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelEvoPass m_ModelEvoPass;

	private UIEvoGunMainController m_MainPageController;

	private UIEvoGunMainController MainPageController => null;

	public SkinOwnAndOpenInfo WeaponData => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void InitView()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshRedPoint()
	{
	}

	private void RefreshSkinOwnAndOpenInfoCache(uint skinID)
	{
	}

	private void NotifySelectedItem()
	{
	}

	private void RefreshItemWeaponNameAndLevel()
	{
	}

	private void RefreshLockState()
	{
	}

	private void RefreshIcon()
	{
	}

	private void RefreshVIPIcon()
	{
	}

	private void SetNaviIconActive(bool state)
	{
	}

	private void RefreshBG()
	{
	}

	private void RefreshSelectedState(bool state)
	{
	}

	private void RefreshByPageState()
	{
	}

	private void DebugText(string para)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
