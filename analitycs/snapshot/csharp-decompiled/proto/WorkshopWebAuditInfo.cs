using System.Collections.Generic;

namespace proto;

public class WorkshopWebAuditInfo
{
	public uint[] toxic_idx;

	public string toxic_content;

	public List<string> toxic_reasons;

	public uint toxic_location;
}
