using GCommon;

namespace COW;

public class UITwentySixSeasonYearPopUpController : UISeasonYearPopUpController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override float GetAnimLength()
	{
		return 0f;
	}

	public float _003C_003EiFixBaseProxy_GetAnimLength()
	{
		return 0f;
	}
}
