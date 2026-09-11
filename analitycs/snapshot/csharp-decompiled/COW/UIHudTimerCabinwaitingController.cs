using GCommon;

namespace COW;

public class UIHudTimerCabinwaitingController : UIBaseController
{
	private UIHudTimerViewExt m_View;

	private bool m_HasShowInEffect;

	private bool m_HasPlayCutSceneSound;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void UpdatePos(float x, float y)
	{
	}

	public void SetTime(int time)
	{
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void SetTimeColor()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}
}
