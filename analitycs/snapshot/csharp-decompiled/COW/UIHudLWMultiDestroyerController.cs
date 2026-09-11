using GCommon;

namespace COW;

internal class UIHudLWMultiDestroyerController : UIBaseController
{
	private UIHudLWMultiDestroyerView m_View;

	private uint m_DelayCall;

	private float m_DelayTime;

	private float m_Time;

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

	public void ShowDelay(float delay, float showTime)
	{
	}

	private void DelayClose()
	{
	}

	public float GetEndTimeDuration()
	{
		return 0f;
	}

	private void _003CShowDelay_003Eb__7_0()
	{
	}

	private void _003CDelayClose_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
