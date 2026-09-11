using GCommon;

namespace COW;

internal class UIHudCrouchController : UIHudButtonBaseController
{
	private UIHudCrouchView m_View;

	private bool m_IsHighlight;

	private float m_ForbidCrouchingEndTime;

	public const uint VISIBILITY_STATE_SNOWSLIDE = 67108864u;

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	public const uint VISIBILITY_STATE_DANCEPOOL = 268435456u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	private void OnFixedUpdate()
	{
	}

	private void InitIsNewUI()
	{
	}

	public void SetForbidCrouchEndTime(float crouchingEndTime)
	{
	}

	private void FakeClick()
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void Update()
	{
	}

	private void SetHightlight(bool highlight)
	{
	}

	private void OnLocalSnowSlideChanged()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void OnPlayerStatsKnockDownChange(object[] param)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnVerticalCameraModeChanged(bool isVertical)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
