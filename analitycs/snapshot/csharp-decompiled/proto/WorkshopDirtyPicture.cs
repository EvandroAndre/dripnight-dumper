using System.Collections.Generic;

namespace proto;

public class WorkshopDirtyPicture
{
	public uint map_cover_id;

	public List<string> ban_reasons;

	public string model_result;

	public uint[] toxic_idx;

	public List<string> toxic_reasons;
}
