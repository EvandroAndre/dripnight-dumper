using GCommon;

namespace COW;

public class UINinth_GachaItemSuperLargeMaleController : UINinth_GachaItemController
{
	protected override bool IsBigRewardType => false;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public bool _003C_003EiFixBaseProxy_get_IsBigRewardType()
	{
		return false;
	}
}
