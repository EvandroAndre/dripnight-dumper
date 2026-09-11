using System.Collections.Generic;

namespace proto;

public class CollabDesc
{
	public uint ip_id;

	public string ip_string;

	public uint priority;

	public uint sub_type;

	public string sub_type_string;

	public uint detailed_type;

	public uint credit_num;

	public uint credit_item;

	public string item_type_figure;

	public string item_type_figure_prime;

	public string item_type_icon_prime;

	public string background;

	public bool is_new;

	public string joint_photo_time;

	public string material_num;

	public string linkage_icon;

	public string button_anime;

	public string collected_anime;

	public string fe_sonic;

	public string color_string;

	public string color_line;

	public string background_sp;

	public uint[] bg_sp_used;

	public string flash_effect_1;

	public string flash_effect_2;

	public List<string> joint_photo_list;
}
