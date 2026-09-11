using GCommon;

namespace COW;

public class UIHudSlideSwitchMoveController : UIBaseController
{
	public const uint VISIBILITY_STATE_NoSighting = 1073741824u;

	public const float const_cd = 0.6f;

	private UIHudSlideSwitchMoveView m_View;

	private float m_CDEndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void EnterCD(bool isEnterCD)
	{
	}

	private bool IsInCD()
	{
		return false;
	}

	private void SwitchMove()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
