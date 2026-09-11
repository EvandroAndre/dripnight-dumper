using GCommon;
using proto;

namespace COW;

public class UIFastSendGiftItemController : UIMallItemBaseController
{
	private UIFastSendGiftItemView m_View;

	private UIStandardItemMAXBController m_MAXBController;

	private UIStandardItemMAXCPriceController m_ItemPriceController;

	private GiftItem m_GiftItem;

	private float m_ItemSize;

	private bool m_IsInGame;

	private EGiftItemType m_GiftItemType;

	private bool m_IsPlayPriceAnim;

	private uint m_Quality;

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

	public override void OnItemBtnSelect()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void IsIngame(bool isIngame = false)
	{
	}

	public void RefreshData()
	{
	}

	public void AdjustScale(float size)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshPrimeItemBG()
	{
	}

	private void InitCommonWidget()
	{
	}

	public void SetGiftItemType(EGiftItemType type)
	{
	}

	private void OnFastSendGiftItemClick(object[] data)
	{
	}

	public override void SetHighLightBGState(bool show)
	{
	}

	protected override bool CanShowDiscountTag()
	{
		return false;
	}

	private void SetPriceLabel(uint gemsPrice, uint coinsPrice, uint discountGemsPrice)
	{
	}

	private void SetParentWidget()
	{
	}

	private void _003CSetViewData_003Eb__17_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetHighLightBGState(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CanShowDiscountTag()
	{
		return false;
	}
}
