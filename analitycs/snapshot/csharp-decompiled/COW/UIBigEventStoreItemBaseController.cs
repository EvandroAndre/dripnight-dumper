using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEventStoreItemBaseController : UIEasyListItemController
{
	private UIBigEventStoreItemBaseView m_View;

	private UIModelInventory m_ModelInventory;

	private UIModelBigEvent m_ModelBigEvent;

	protected BigEventStoreCommodityDesc m_Data;

	private UIStandardItemMiniController m_ItemCtrl;

	private ELimitedEvent.EventID m_EventId;

	private ELimitedEvent.StoreType m_StoreType;

	private Vector3 m_LimitBtnPos;

	public UIBigEventStoreItemBaseView BaseView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual uint GetTokenEnoughColor()
	{
		return 0u;
	}

	public virtual uint GetTokenNotEnoughColor()
	{
		return 0u;
	}

	public virtual uint GetTokenEnoughBgColor()
	{
		return 0u;
	}

	public virtual uint GetTokenNotEnoughBgColor()
	{
		return 0u;
	}

	public uint GetStoreId()
	{
		return 0u;
	}

	public virtual UIStandardItemMiniController GetItemController()
	{
		return null;
	}

	public void SetStoreData(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetAwardView()
	{
	}

	private void SetTokenView()
	{
	}

	private void SetLimitView()
	{
	}

	protected virtual void OnBtnCanBuyClick()
	{
	}

	protected virtual void OnBtnSoldOutClick()
	{
	}

	protected virtual void OnBtnOwndClick()
	{
	}

	public virtual bool IsStoreLock()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
