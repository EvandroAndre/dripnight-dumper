using GCommon;

namespace COW;

public class UISeasonYearSwitchYearItemController : UIBaseController
{
	private UISeasonYearSwitchYearItemView m_View;

	private uint m_SeasonYearId;

	private UIModelSeasonYear m_ModelSeasonYear;

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

	public void SetYear(uint seasonYearId, string year)
	{
	}

	public void RefreshGiftIcon()
	{
	}

	public void RefreshCSLabel()
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
