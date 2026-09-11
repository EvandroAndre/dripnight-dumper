using proto;

namespace COW;

public class WorkshopCreatorPrivilegeWarp
{
	public uint id;

	public string name;

	public string icon;

	public uint tips_type;

	public string tips_text;

	public string tips_pic;

	public uint go_pos;

	public string sub_go_pos;

	public bool is_hide;

	public uint unlock_level;

	public uint weight;

	public string value;

	public int important;

	public bool prefers_external;

	public WorkshopCreatorPrivilegeWarp()
	{
	}

	public WorkshopCreatorPrivilegeWarp(WorkshopCreatorPrivilegeDesc privilege)
	{
	}
}
