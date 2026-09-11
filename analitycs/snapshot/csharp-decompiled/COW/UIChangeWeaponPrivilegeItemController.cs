using GCommon;

namespace COW;

internal class UIChangeWeaponPrivilegeItemController : UIEasyListItemController
{
	private UIChangeWeaponPrivilegeItemView m_View;

	private int m_FeatureID;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIChangeWeaponPreviewMainController m_MainController;

	private uint UNSELECT_LABEL_COLOR;

	private uint SELECT_LABEL_COLOR;

	private string m_NewTagKey;

	private int m_NewTagKeyValue;

	private UIChangeWeaponPreviewMainController MainController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshViewForWeapon()
	{
	}

	private void RefreshViewForFinalShot()
	{
	}

	private void RefreshViewForFlight()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}
}
