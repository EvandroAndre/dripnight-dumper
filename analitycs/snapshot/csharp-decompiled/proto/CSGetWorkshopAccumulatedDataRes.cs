using System.Collections.Generic;

namespace proto;

public class CSGetWorkshopAccumulatedDataRes
{
	public string workshop_code;

	public List<WorkshopAccumulatedData> acc_data;
}
