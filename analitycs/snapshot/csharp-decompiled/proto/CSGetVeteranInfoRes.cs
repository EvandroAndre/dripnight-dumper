using System.Collections.Generic;

namespace proto;

public class CSGetVeteranInfoRes
{
	public CSGetVeteranConfigDescRes config_desc;

	public CSGetVeteranTaskDescRes task_desc;

	public CSGetVeteranTaskInfoRes task_info;

	public List<VeteranRightsDesc> rights_desc;

	public List<VeteranModeDesc> mode_desc;

	public uint cs_rank;
}
