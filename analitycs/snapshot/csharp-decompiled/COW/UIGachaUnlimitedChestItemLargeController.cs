using GCommon;

namespace COW;

public class UIGachaUnlimitedChestItemLargeController : UIGachaUnlimitedChestItemController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void SetQualityBG(int Quality, UISprite QualityBG, bool bRareItem)
	{
	}

	public void _003C_003EiFixBaseProxy_SetQualityBG(int P0, UISprite P1, bool P2)
	{
	}
}
