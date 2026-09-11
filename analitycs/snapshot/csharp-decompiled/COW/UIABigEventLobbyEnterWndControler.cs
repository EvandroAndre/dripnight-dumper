using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public abstract class UIABigEventLobbyEnterWndControler : UIPopupWindowController
{
	public abstract void TransferEndTimeStamp(uint end_timestamp);

	public abstract void TransferEntryDesc(List<BigEventEntryDesc> entryDesc);

	public abstract void TransferTemplateEntryDes(uint useType, List<CustomEventEntryDesc> entryDesc);
}
