using GCommon;
using proto;

namespace COW;

public class UIGachaDoubleWheelGrandPrizeItemController : UIBaseController
{
	protected uint m_GachaID;

	protected UIGachaDoubleWheelGrandPrizeItemView m_View;

	private UIModelGacha m_ModelGacha;

	protected GachaShowItem m_GachaShowItem;

	protected BaseItemInfo m_Info;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnButtonClick()
	{
	}

	public void SetViewData(uint gachaID, GachaShowItem info)
	{
	}

	public bool IsFinished()
	{
		return false;
	}

	private void SetQualityBG(uint Quality, UISprite QualityBG)
	{
	}

	private void SetVFX(uint Quality)
	{
	}

	private void ResetHighlight()
	{
	}

	public void SetHighlight(bool highlight, bool final = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
