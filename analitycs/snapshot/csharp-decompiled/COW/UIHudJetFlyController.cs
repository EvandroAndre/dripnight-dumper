using GCommon;

namespace COW;

internal class UIHudJetFlyController : UIHudButtonBaseController
{
	private UIHudJetFlyView m_View;

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

	protected override string GetMappingName()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnEnergyChange(object[] data)
	{
	}

	private void OnShow(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
