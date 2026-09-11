using GCommon;

namespace COW;

internal class UIHudReviveBubbleController : UIBaseController
{
	public const uint VISIBILITY_STATE_LocalPlayerPendingRevive = 1073741824u;

	public const uint VISIBILITY_STATE_KillCamntry = 536870912u;

	private UIHudReviveBubbleView m_View;

	private VisualInstanceHolder m_UIFXInactiveProgress;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void ClaimReviveCardBubble()
	{
	}

	private void Update()
	{
	}

	private void OnBtnClaimClick()
	{
	}

	private void OnKillCamEntryVisibilityChange(bool show)
	{
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
