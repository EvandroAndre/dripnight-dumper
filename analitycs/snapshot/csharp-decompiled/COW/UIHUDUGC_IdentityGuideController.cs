using GCommon;

namespace COW;

internal class UIHUDUGC_IdentityGuideController : UIBaseController
{
	private UIHUDUGC_IdentityGuideView m_View;

	private uint m_DelayCall;

	private int m_CurrentIdentity;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SetViewData(int identity)
	{
	}

	private void OnFactionChanged(object[] data)
	{
	}

	private void _003CSetViewData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
