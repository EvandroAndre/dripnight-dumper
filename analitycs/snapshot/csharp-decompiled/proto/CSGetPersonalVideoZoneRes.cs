using System.Collections.Generic;

namespace proto;

public class CSGetPersonalVideoZoneRes
{
	public string nickname;

	public EInventory.GenderType sex;

	public uint fan_count;

	public uint head_pic;

	public ELive.FollowerType follower_type;

	public List<VideoDetail> video_list;
}
