using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudCannonInfoController : UIBaseController
{
	private UIHudCannonInfoView m_View;

	private bool m_IsInCannon;

	private int m_CannonTotalShot;

	private int m_CurrentCannonShot;

	private uint m_AsyncLoadUIAtlasTicket;

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

	private void Update()
	{
	}

	protected void OnPlayerInOrOutCannon(object[] data)
	{
	}

	private bool ShouldUpdateCannon(Player player)
	{
		return false;
	}

	private void SetVisibleState(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
