using System.Collections.Generic;

namespace proto;

public class CSFilterWorkshopDirtyWordReq
{
	public string language;

	public List<WorkshopWordFilter> filter_contents;
}
