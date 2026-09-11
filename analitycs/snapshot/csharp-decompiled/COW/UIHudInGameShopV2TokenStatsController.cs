using GCommon;

namespace COW;

public class UIHudInGameShopV2TokenStatsController : UIBaseController, IPlayerFundStatsController
{
	private UIHudInGameShopV2TokenStatsView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnInGameShopTokenChanged(int tokenCount)
	{
	}

	private void RegisterEvents()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void UpdateCoinValue(int value)
	{
	}

	public void UpdateFundStats()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
