using GCommon;
using proto;

namespace COW;

public class UIPrimeFestivalPopUpController : UIPopupWindowController
{
	private UIPrimeFestivalPopUpView m_View;

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

	public void SetViewData(PrimeFestivalDesc desc, PrimeFestivalStatus status)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
