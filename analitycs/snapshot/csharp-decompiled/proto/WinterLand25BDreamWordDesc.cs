using System.Collections.Generic;

namespace proto;

public class WinterLand25BDreamWordDesc
{
	public class TagInfo
	{
		public uint tag;

		public string tag_name;

		public string tag_icon;

		public string tag_res_id;

		public uint tag_type;

		public uint tag_weight;

		public string tag_effect;

		public string label_color;
	}

	public uint dream_stage;

	public List<TagInfo> tag_list;
}
