using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinMenuThirdItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UIWeaponSkinMenuThirdItemController _003C_003E4__this;

		public UISprite tempspr;

		public DiscolorationCollectionData DisData;

		internal void _003CSetWeaponShowIcon_003Eb__0()
		{
		}

		internal void _003CSetWeaponShowIcon_003Eb__1()
		{
		}
	}

	private UIWeaponSkinMenuThirdItemView m_View;

	private UIModelInventory m_ModelInventory;

	private UIModelCollection m_ModelCollection;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelWeaponSkinCustom m_ModelWeaponSkinCustom;

	private UIModelClan m_ModelClan;

	private object m_Data;

	private bool m_IsABReady;

	private bool m_IsIconAbReady;

	private ResourceID m_LastResourseId;

	private uint m_ItemIconGrey;

	private GameObject m_GODiscolorItem;

	private UIModelRandomCollection m_ModelRandomCollection;

	private CollectionBaseInfo m_DataAsCollectionBaseInfo => null;

	private WeaponSkinBaseInfo m_DataAsWeaponSkinBaseInfo => null;

	public uint WeaponSkinId => 0u;

	public UIWidget GuideWidget => null;

	public UIButton GuideButton => null;

	public void RefreshMultiSelectEquipState()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshNewTipsEffect(bool flag)
	{
	}

	public void DisableDiscoloration(UISprite spr)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetWeaponShowIcon(UIUtils.SpriteScaleType scaleType)
	{
	}

	private void DisColorDataSet(UISprite tempspr, DiscolorationCollectionData DisData)
	{
	}

	private void RefreshChangeWeaponStatIcon(uint skinId)
	{
	}

	private void OnItemDownloadUpdate(object[] param)
	{
	}

	private void OnItemUpdate(object[] param)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnClickGoToMallWeapon()
	{
	}

	private void OnCustomLockMaskClick()
	{
	}

	public bool IsCustomWeaponUnLock()
	{
		return false;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
