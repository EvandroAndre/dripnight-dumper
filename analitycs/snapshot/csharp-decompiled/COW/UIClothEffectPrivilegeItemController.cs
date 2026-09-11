using GCommon;

namespace COW;

public class UIClothEffectPrivilegeItemController : UIEasyListItemController
{
	private UIChangeWeaponPrivilegeItemView m_View;

	private uint m_EventID;

	private ClothTriggerEffectPreviewData m_Data;

	private UIModelTailor m_ModelTailor;

	private UIChangeWeaponPreviewMainController m_MainController;

	private uint UNSELECT_LABEL_COLOR;

	private uint SELECT_LABEL_COLOR;

	private bool m_HackNB2;

	private UIChangeWeaponPreviewMainController MainController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshHackView()
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
