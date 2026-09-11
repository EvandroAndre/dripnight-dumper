using GCommon;

namespace COW;

internal class UIHudLobbySocialAreaCarryHitController : UIBaseController
{
	private static readonly string[] s_HitSpriteNames;

	private const float AUTO_HIDE_DURATION = 5f;

	private UIHudLobbySocialAreaCarryHitView m_View;

	private uint m_HideDelayCallID;

	private uint m_IconLoadTicket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void ShowHitResult(uint hitCount)
	{
	}

	private void ResetHideTimer()
	{
	}

	private void CancelHideDelay()
	{
	}

	private void _003CResetHideTimer_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
