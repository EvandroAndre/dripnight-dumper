using GCommon;

namespace COW;

public class UIBRMatchReviewMapContentController : UIMapContentController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public new static bool DontDestroy()
	{
		return false;
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}
}
