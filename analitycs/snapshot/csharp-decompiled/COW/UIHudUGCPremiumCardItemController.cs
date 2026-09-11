using System;
using GCommon;
using proto;

namespace COW;

public class UIHudUGCPremiumCardItemController : UIBaseController
{
	private UIHudUGCPremiumCardItemView m_View;

	private StoreDesc m_StoreDesc;

	private CSSharedItemData m_ItemData;

	private Action<UIHudUGCPremiumCardItemController> m_SelectedCallback;

	private bool m_Selected;

	private bool m_Subscribe;

	public bool Subscribe
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Selected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(StoreDesc storeDesc, Action<UIHudUGCPremiumCardItemController> selectedCallback)
	{
	}

	public void RefreshVipControlDesc()
	{
	}

	public StoreDesc GetStoreDesc()
	{
		return null;
	}

	public CSSharedItemData GetItemData()
	{
		return null;
	}

	public uint GetItemID()
	{
		return 0u;
	}

	public ResourceID GetBigIcon()
	{
		return default(ResourceID);
	}

	public string GetName()
	{
		return null;
	}

	public CSSharedItemDataManager.ItemSubType GetCardType()
	{
		return CSSharedItemDataManager.ItemSubType.ItemSubType_NONE;
	}

	public uint GetRealPrice()
	{
		return 0u;
	}

	private void OnClickItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
