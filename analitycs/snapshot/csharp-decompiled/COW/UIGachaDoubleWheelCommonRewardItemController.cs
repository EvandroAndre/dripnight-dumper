using GCommon;
using proto;

namespace COW;

public class UIGachaDoubleWheelCommonRewardItemController : UIBaseController
{
	private uint m_GachaID;

	private UIGachaDoubleWheelCommonRewardItemView m_View;

	private UIModelGacha m_ModelGacha;

	private GachaShowItem m_GachaShowItem;

	private BaseItemInfo m_Info;

	private bool m_IsLeft;

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

	public GachaShowItem GetGachaShowItem()
	{
		return null;
	}

	public void SetViewData(uint gachaID, GachaShowItem info, bool isLeft)
	{
	}

	public bool IsFinished()
	{
		return false;
	}

	private void ResetHighlight()
	{
	}

	private void ResetVFX()
	{
	}

	public void SetHighlight(bool highlight, bool final = false)
	{
	}

	public void ShowRefreshVFX()
	{
	}

	public void SetFinished(bool finished)
	{
	}

	public void SetComplimentary(bool complimentary)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
