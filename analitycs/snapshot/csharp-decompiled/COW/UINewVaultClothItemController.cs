using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINewVaultClothItemController : UIEasyListItemController, IUINewVaultLovableItem
{
	protected UIStandardItemMAXBController m_standardItemCtrl;

	protected UINewVaultCommonItemView m_View;

	protected UINewVaultItemViewData m_data;

	private UINewVaultController m_UINewVaultController;

	private FrontEndPreviewComponent_NewVault m_FrontEndPreviewComponent;

	private AvatarWardrobeData m_clothWardrobe;

	private InventoryClothSeriesInfo m_curClothSeriesInfo;

	private Item m_curProtoItem;

	private CSSharedItemData m_curCSSharedItemData;

	private UIModelInventory m_ModelInventory;

	private UIModelAvatar m_ModelAvatar;

	private UIModelTailor m_ModelTailor;

	private UIModelNewVault m_ModelNewVault;

	private bool m_IsItemABReady;

	private bool m_IsInvalid;

	private bool m_IsInvalidForAvatar;

	private bool m_IsInvalidForSpecialAvatar;

	private bool m_SkipClothesForAvatar;

	private bool m_IsInvalidForTailor;

	private GameObject m_FistGetEffect;

	private GameObject m_LoveNode;

	private GameObject m_LoveNodeVFX;

	public UINewVaultItemViewData GetData()
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent_NewVault comp)
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void OnlyShowPreviewItem(bool needRefreshAvatar = true)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private void ClickDefaultClothStyle()
	{
	}

	private void UpdateLocalAvatarCloth(List<uint> checkOptionalIds)
	{
	}

	private void OnSeriesItemChangeIndex(object[] data)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private AvatarWardrobeData CurrentClothWardrobe()
	{
		return null;
	}

	private void HideIconAndBG()
	{
	}

	public void RefreshEquipState()
	{
	}

	public void RefreshNewGetState()
	{
	}

	public void RefreshIsLoved(bool playVFX = false)
	{
	}

	public void SetFirstGetEffectActive(bool active)
	{
	}

	public void SetLoveNodeActive(bool active)
	{
	}

	public void SetLoveNodeVFXActive(bool active)
	{
	}

	private void BatchRemoveNewGet()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
