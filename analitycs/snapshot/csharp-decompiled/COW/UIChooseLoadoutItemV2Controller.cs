using GCommon;

namespace COW;

internal class UIChooseLoadoutItemV2Controller : UIEasyListItemController
{
	private IngameBattleStyleLoadoutData m_Data;

	private UIChooseLoadoutItemV2View m_View;

	private UIBaseChooseLoadoutV2Controller m_ParentCtrl;

	private UIModelLoadout m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetParentCtrl(UIBaseChooseLoadoutV2Controller ctrl)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnCheckLoadoutV2Guide(uint step)
	{
	}

	private void OnLoadoutV2Change(uint loadoutId)
	{
	}

	private void OnBtnItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
