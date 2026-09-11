using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionVaultItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomCollectionVaultItemView m_View;

	private UILaunchTagFrameController m_LaunchTag;

	private UIModelInventory m_ModelInventory;

	private const float QUICK_MESSAGE_Bundle_SCALE = 0.7f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
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

	private void RefreshSuperEmote(uint itemID)
	{
	}

	private void RefreshBundle(uint itemID)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}
}
