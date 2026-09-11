using GCommon;

namespace COW;

public class UILobbyV2ShoppingMallBannerCarouselItemController : UIStandardAdsItemController
{
	public enum BannerTag
	{
		None,
		TagNew,
		BreakingNews,
		DiscountTag,
		MostLikeTag
	}

	private UILobbyV2ShoppingMallBannerCarouselItemView m_View;

	private UIModelVeteran m_ModelVeteran;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void RefreshUIData(UIModelLobbyAds.AdInfo info)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshUIData(UIModelLobbyAds.AdInfo P0)
	{
	}
}
