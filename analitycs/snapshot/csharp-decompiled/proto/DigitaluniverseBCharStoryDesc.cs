using System.Collections.Generic;

namespace proto;

public class DigitaluniverseBCharStoryDesc
{
	public uint story_id;

	public uint story_group_id;

	public List<DigitaluniverseBStoryBranchDesc> branches;

	public uint story_content_type;

	public uint character_pose;

	public string story_content_key;

	public uint character_left;

	public uint character_right;
}
