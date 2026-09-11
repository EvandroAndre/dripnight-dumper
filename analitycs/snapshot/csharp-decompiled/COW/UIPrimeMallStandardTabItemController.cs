using GCommon;

namespace COW;

public class UIPrimeMallStandardTabItemController : UIStandardTabItemController
{
	public const string PRIME_CLICK_ANIM_NAME = "UIPrimeMallStandardTabItem_Click";

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override string GetClickAniName()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetClickAniName()
	{
		return null;
	}
}
