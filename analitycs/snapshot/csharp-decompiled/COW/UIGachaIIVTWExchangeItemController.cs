using GCommon;
using proto;

namespace COW;

public class UIGachaIIVTWExchangeItemController : UIBaseController
{
	public UIGachaIIV1_TWIIVExchangeItemView m_View;

	public StatndardItemMiniData m_Data;

	private uint m_GachaID;

	private ChestSpecialExchangeDesc m_ExchangeItemInfo;

	public uint ExchangeNum;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewInfo(uint gachaID, ChestSpecialExchangeDesc info)
	{
	}

	private bool CanSpecialExchangePurchase(ChestSpecialExchangeDesc item)
	{
		return false;
	}

	public void RefreshView()
	{
	}

	private void SetExchangeInfo()
	{
	}

	public void ShowHideExchangeContainer(bool active)
	{
	}

	private void ShowHideExchangeContainerInternal(bool active)
	{
	}

	public void OnItemBtnClicked()
	{
	}

	private void OnBtnTipClick()
	{
	}

	public void SetQualityBG()
	{
	}

	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	public void SetLimitTitleState(bool show)
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetLadderGotState(bool show)
	{
	}

	public void SetHighLightState(bool show)
	{
	}

	public void SetGreyBGState(bool show)
	{
	}

	public void SetOwnedState(bool show)
	{
	}

	public override void Hide()
	{
	}

	public override void Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
