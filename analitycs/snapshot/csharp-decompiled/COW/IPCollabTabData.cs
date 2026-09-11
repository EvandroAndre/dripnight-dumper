using System.Collections.Generic;
using proto;

namespace COW;

public class IPCollabTabData
{
	public string tabName;

	public uint ip_id;

	public uint detailed_type;

	public uint priority;

	public List<CollabDesc> subTabList;
}
