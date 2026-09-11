using System.Runtime.InteropServices;
using GCommon;

namespace COW;

internal class UIHudBloodmoon_GP_PopupController : UIBaseController
{
	private UIHudBloodmoon_GP_PopupView m_View;

	private float m_DelayCallTime;

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

	public void SetViewData(string locKey, ResourceID showIcon, [Optional][DefaultParameterValue(2f)] float duration, object[] locArgs)
	{
	}

	private void CancelDelayCall()
	{
	}

	private void Update()
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
