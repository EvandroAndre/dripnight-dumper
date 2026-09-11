using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class FullscreenCgDesc : IMessage
{
	public uint id;

	public uint anim_id;

	public uint anim_type;

	public uint system_pos;

	public uint go_pos;

	public string fullscreen_resource_id;

	public uint first_model_id;

	public uint first_model_cloth1;

	public uint first_model_cloth2;

	public uint first_model_cloth3;

	public uint first_model_cloth4;

	public uint first_model_cloth5;

	public uint second_model_id;

	public uint second_model_cloth1;

	public uint second_model_cloth2;

	public uint second_model_cloth3;

	public uint second_model_cloth4;

	public uint second_model_cloth5;

	public string first_model_female_idle;

	public string first_model_female_special;

	public string first_model_male_idle;

	public string first_model_male_special;

	public string second_model_female_idle;

	public string second_model_female_special;

	public string second_model_male_idle;

	public string second_model_male_special;

	public List<string> skin_resource_list;

	public bool not_auto_play;

	public string show_pose_anim_id;

	public string show_pose_anim_id_idle;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
