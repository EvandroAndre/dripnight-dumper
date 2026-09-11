using GCommon;

namespace COW;

internal class UINewPlayerV3GrowPathAwardItemController : UIBaseController
{
	private NewPlayerGrowPathData m_GrowPathData;

	private UINewPlayerV3GrowPathAwardItemView m_View;

	private UINewPlayerV3GrowPathBaseItemController m_ParentCtrl;

	private UINewPlayerV3GrowPathBaseItemController ParentCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(NewPlayerGrowPathData growPathData)
	{
	}

	private bool HideDetailIcon()
	{
		return false;
	}

	private void OnDetailButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
