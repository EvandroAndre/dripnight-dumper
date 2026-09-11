using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopDataStorageRes
{
	public string workshop_code;

	public List<WorkshopDataStorage> data_storage;

	public uint size;
}
