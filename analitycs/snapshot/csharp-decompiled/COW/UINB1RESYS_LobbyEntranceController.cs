using GCommon;
using proto;

namespace COW;

public class UINB1RESYS_LobbyEntranceController : UIBigEventLobbyEntranceBaseController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}
}
