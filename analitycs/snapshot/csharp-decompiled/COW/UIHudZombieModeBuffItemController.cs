using GCommon;

namespace COW;

internal class UIHudZombieModeBuffItemController : UIBaseController
{
	private UIHudZombieModeBuffItemView m_View;

	private uint m_CurBuffIndex;

	public const uint Buff1ID = 120u;

	public const uint Buff2ID = 121u;

	public const uint Buff3ID = 122u;

	public const uint Buff4ID = 123u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetView(uint buffIndex)
	{
	}

	private void OnBtnSelectClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
