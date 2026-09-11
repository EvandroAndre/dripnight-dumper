using GCommon;

namespace COW;

public class UIHudTechBuildPointSelectionItemController : UIBaseController
{
	private UIHudTechBuildPointSelectionItemView m_View;

	private UIHudTechBuildPointSelectionItemViewData m_ViewData;

	public bool Populated => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSelectionBtnClick()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void ToggleSufficientFundsGroup(bool sufficient)
	{
	}

	private bool UpdatePriceContent(uint tokenCount)
	{
		return false;
	}

	private void UpdateNotAvailableMask(bool shown)
	{
	}

	private void UpdateTimeoutGroup(bool shown)
	{
	}

	public void SetViewData(UIHudTechBuildPointSelectionItemViewData viewData)
	{
	}

	public void UpdateSufficientFundsGroupOnChange(int playerFunds)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
