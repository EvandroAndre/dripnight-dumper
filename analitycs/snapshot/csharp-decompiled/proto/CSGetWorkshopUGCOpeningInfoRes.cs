using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopUGCOpeningInfoRes
{
	public List<WorkshopUGCOpeningInfoDesc> ugc_opening_infos;

	public List<ResourceDownloadInfo> resource_download_infos;

	public List<WorkshopBasicInfoWithExtra> workshop_infos;
}
