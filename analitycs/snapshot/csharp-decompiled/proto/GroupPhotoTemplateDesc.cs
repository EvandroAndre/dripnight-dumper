using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GroupPhotoTemplateDesc : IMessage
{
	public uint id;

	public uint sort_id;

	public string name;

	public string desc;

	public uint member_count;

	public string camera;

	public List<GroupPhotoTemplatePosition> group_photo_template_position;

	public string preview_icon;

	public bool is_vertical;

	public uint output_channel;

	public string grand_prize_preview_cdn;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
