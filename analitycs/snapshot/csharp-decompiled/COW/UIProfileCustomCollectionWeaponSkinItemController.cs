using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCollectionWeaponSkinItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIProfileCustomCollectionWeaponSkinItemView m_View;

	private WeaponSkinBaseInfo m_Data;

	private ResourceID m_LastSetSprite;

	private bool m_IsIconReady;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIDestory()
	{
	}

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	private void SetWeaponSprite()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	protected override void CaclulateItemOffset()
	{
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

	public void _003C_003EiFixBaseProxy_CaclulateItemOffset()
	{
	}
}
