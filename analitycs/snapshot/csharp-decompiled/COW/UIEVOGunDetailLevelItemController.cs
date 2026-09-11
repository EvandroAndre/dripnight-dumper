using GCommon;

namespace COW;

public class UIEVOGunDetailLevelItemController : UIBaseController
{
	private int m_index;

	private UIEVOGunDetailLevelItemView m_View;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelEvoPass m_MoldeEvoPass;

	private SkinOwnAndOpenInfo m_OwnAndOpenInfo;

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

	private void SetupDefaultState()
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshDynamicContent(bool playAnim = false)
	{
	}

	private void OnSelectBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	public void OnSelectNotify()
	{
	}

	public void SetViewData(uint skinID, int index, uint weaponSetID)
	{
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
