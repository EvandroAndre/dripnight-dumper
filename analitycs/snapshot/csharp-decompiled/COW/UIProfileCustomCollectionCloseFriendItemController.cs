using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionCloseFriendItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomCollectionCloseFriendItemView m_View;

	private ProfileCustomCloseFriendData m_InfoData;

	private UIModelRelationShip m_ModelRelationShip;

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
