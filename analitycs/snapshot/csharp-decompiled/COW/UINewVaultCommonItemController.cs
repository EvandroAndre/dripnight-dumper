using GCommon;
using UnityEngine;

namespace COW;

public class UINewVaultCommonItemController : UIEasyListItemController, IUINewVaultLovableItem
{
	protected UINewVaultCommonItemView m_View;

	protected UINewVaultItemViewData m_data;

	protected UIStandardItemMAXBController m_standardItemCtrl;

	protected GameObject m_FistGetEffect;

	private GameObject m_LoveNode;

	private GameObject m_LoveNodeVFX;

	protected UIModelNewVault m_ModelNewVault;

	private bool m_FreshMultiSelectFromClick;

	private bool m_OptionalBundle;

	private bool m_IsOwned;

	private bool m_IsMultiSelectEuiped;

	private INewVaultMultiSelectComponent m_IParentNultiSelectComponent;

	private INewVaultMultiSelectComponent IParentNultiSelectComponent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual void AfterDataReady()
	{
	}

	protected virtual void CheckIsNewGet()
	{
	}

	protected virtual void SetLoveNodeState()
	{
	}

	public void RefreshABReady()
	{
	}

	public virtual void RefreshEquipState()
	{
	}

	public void RefreshNewGetState()
	{
	}

	public virtual void RefreshIsLoved(bool playVFX = false)
	{
	}

	public virtual void RefreshMultiSelectState()
	{
	}

	public virtual void RefreshLockState()
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

	public virtual void OnClickMultiSelectForEquip()
	{
	}

	public virtual void RefreshMultiSelectEquipState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
