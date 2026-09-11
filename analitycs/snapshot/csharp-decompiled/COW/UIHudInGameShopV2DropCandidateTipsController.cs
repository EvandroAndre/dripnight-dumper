using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudInGameShopV2DropCandidateTipsController : UIBaseController
{
	private const string m_InAnimationName = "UIFX_UIHudInGameShopV2InventoryExchangeTips_Open";

	private const string m_DropAnimationName = "UIFX_UIHudInGameShopV2InventoryExchangeTips_Close";

	private UIHudInGameShopV2DropCandidateTipsView m_View;

	private GBFCHMLNOOC m_DisplayedCandidate;

	public GBFCHMLNOOC DisplayedCandidate => default(GBFCHMLNOOC);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void UpdateTipsContent(GBFCHMLNOOC dropCandidate, NAELPAAELNO dropInventory)
	{
	}

	public void SetViewData(GBFCHMLNOOC dropCandidate)
	{
	}

	public void InvalidateCandidate()
	{
	}

	public void PlayInAnimation()
	{
	}

	public float PlayDropAnimation()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
