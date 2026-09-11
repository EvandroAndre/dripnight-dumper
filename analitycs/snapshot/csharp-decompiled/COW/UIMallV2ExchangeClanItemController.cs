using GCommon;

namespace COW;

public class UIMallV2ExchangeClanItemController : UIMallV2ExchangeItemController
{
	private bool m_IsReachClanLevel;

	private uint m_MyClanLevel;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void ResetState()
	{
	}

	protected override void RefreshItemView()
	{
	}

	public override void RefreshItemBGState()
	{
	}

	private void CheckIsReachClanLevel()
	{
	}

	private void RefreshClanLevelTitle()
	{
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public new void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}
}
