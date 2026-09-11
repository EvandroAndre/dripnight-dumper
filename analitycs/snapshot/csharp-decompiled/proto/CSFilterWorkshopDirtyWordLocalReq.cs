using System.Collections.Generic;

namespace proto;

public class CSFilterWorkshopDirtyWordLocalReq
{
	public string language;

	public List<WorkshopWordFilter> filter_contents;
}
