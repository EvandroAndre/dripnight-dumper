using GCommon;
using proto;

namespace COW;

public class UIGachaPreviewItemController : UIBaseController
{
	private UIGachaShowRewardItemView m_View;

	private GachaShowItem m_GachaShowItem;

	private BaseItemInfo m_Data;

	private UIModelGacha m_ModelGacha;

	private static bool m_IsShowDropUp;

	private static uint m_CurrentGachaID;

	public static uint CurrentGachaID
	{
		set
		{
		}
	}

	public static bool IsShowDropUp
	{
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

	public void OnItemBtnUnSelect()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void SetViewData(GachaShowItem gachaShowItem)
	{
	}

	private void RefreshDataItem(BaseItemInfo data)
	{
	}

	public void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
