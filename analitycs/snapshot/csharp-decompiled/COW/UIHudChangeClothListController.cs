using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudChangeClothListController : UIPopupWindowController
{
	private UIHudChangeClothListView m_View;

	private UIModelInventory m_InventoryModel;

	private UIModelAvatar m_ModelAvatar;

	private AvatarManager m_amManager;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitClothesData()
	{
	}

	private void OnCloseClick()
	{
	}

	private void On1PShowClick()
	{
	}

	private void On3PShowClick()
	{
	}

	private void OnSearchInputChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
