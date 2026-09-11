using System.Collections.Generic;

namespace proto;

public class CSUpdatePresetLoadoutInfoReq
{
	public List<PresetLoadoutSchema> preset_schema;

	public ulong group_id;
}
