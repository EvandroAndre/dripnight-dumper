using GCommon;
using message;

namespace COW;

public class UIHudMetropolisChooseFactionController : UIBaseController
{
	private UIHudMetropolisChooseFactionView m_View;

	private AFBOKKIDEAB m_SelectFaction;

	private bool m_ForceChooseFaction;

	private UIModelMetropolis m_ModelMetropolis;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnFactionCountUpdate(object[] data)
	{
	}

	private void RefreshFactionVisiable()
	{
	}

	private void OnClickToPoliceBtn()
	{
	}

	private void OnClickToCriminalBtn()
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	public void SetForceChooseFaction(bool forceChooseFaction)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
