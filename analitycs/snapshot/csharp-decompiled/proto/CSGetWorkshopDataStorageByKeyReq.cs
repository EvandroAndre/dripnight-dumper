using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopDataStorageByKeyReq
{
	public string workshop_code;

	public List<WorkshopDataStorage> storage_data;
}
