using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIForgeItemController : UIEasyListItemController
{
	private ChestSpecialExchangeDesc m_Info;

	private UIForgeItemView m_View;

	private CSSharedItemData m_ItemData;

	private uint m_Id;

	private UIModelMall m_ModelMall;

	private ShowBoostAvatarParams m_ShowBoostAvatarParams;

	private List<UISprite> m_Materials;

	private List<UILabel> m_MaterialsCnt;

	private bool m_ShowAvatar;

	private int PriceBGExtraWidth;

	private int PriceBGMinWidth;

	private UIForgeController m_ForgeController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void HideGameObject()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshCDNImage()
	{
	}

	private void RefreshVFX()
	{
	}

	private void RefreshOwnedTitle()
	{
	}

	private void RefreshPriceContainer()
	{
	}

	private void OnEnable()
	{
	}

	private void RefreshPriceTable()
	{
	}

	private void RefreshBigAwardIcon()
	{
	}

	private void RefreshDuration()
	{
	}

	private void InitMaterial()
	{
	}

	private void InitItemData(uint itemID, uint id)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
