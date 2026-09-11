using GCommon;

namespace COW;

public class UIHudLobbySocialAreaTitleCarryHitController : UIBaseController
{
	private static readonly string[] s_HitSpriteNames;

	private UIHudLobbySocialAreaTitleCarryHitView m_View;

	private uint m_IconLoadTicket;

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

	public void SetHitCount(uint hitCount)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
