using GCommon;
using proto;

namespace COW;

public class UINinthSYSRulesItemController : UIBigEventRulesItemController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetEventID()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override UIModelBigEvent.EBigEventEntranceID GetEntranceID()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetEventID()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceID()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}
}
