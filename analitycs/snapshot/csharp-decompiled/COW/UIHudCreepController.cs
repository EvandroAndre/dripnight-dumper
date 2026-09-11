using GCommon;

namespace COW;

internal class UIHudCreepController : UIHudButtonBaseController
{
	private UIHudCreepView m_View;

	private bool m_IsHighlight;

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	public const uint VISIBILITY_STATE_DANCEPOOL = 268435456u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void SetHightlight(bool highlight)
	{
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnLocalSnowSlideChanged()
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
