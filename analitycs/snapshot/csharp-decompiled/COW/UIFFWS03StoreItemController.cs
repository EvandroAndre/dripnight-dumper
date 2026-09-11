using GCommon;

namespace COW;

public class UIFFWS03StoreItemController : UIBigEventStoreItemBaseController
{
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override uint GetTokenEnoughColor()
	{
		return 0u;
	}

	public override uint GetTokenNotEnoughColor()
	{
		return 0u;
	}

	public override bool IsStoreLock()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetTokenEnoughColor()
	{
		return 0u;
	}

	public uint _003C_003EiFixBaseProxy_GetTokenNotEnoughColor()
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_IsStoreLock()
	{
		return false;
	}
}
