using ProtoBuf;

namespace proto;

public class GroupPhotoTemplatePosition : IMessage
{
	public string pose_male;

	public string pose_female;

	public string name_bar_position;

	public string pose_position;

	public string pose_cdn;

	public uint name_bar_target;

	public string switch_position;

	public string season_replay_name_bar_position;

	public uint season_replay_name_bar_target;

	public string pose_light;

	public string chosen_pose_cdn;

	public string switch_btn_center;

	public string switch_btn_size;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
