using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionVaultLoadingCardItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomCollectionVaultLoadingCardItemView m_View;

	private UILaunchTagFrameController m_LaunchTag;

	private UIModelInventory m_ModelInventory;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	private void ShowLaunchTagOrIPTag(uint itemID, uint serialNumber)
	{
	}

	private void ShowIPTag(uint itemID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}
}
