using GCommon;

namespace COW;

internal class UIHudBountyContractController : UIHudButtonBaseController
{
	private UIHudBountyContractView m_View;

	private bool needShow;

	private bool HasShownTutorial;

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

	private void OnUpdateLoadoutCount(object[] data)
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void OnShowCSShop(object[] data)
	{
	}

	private void RereshShow()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
