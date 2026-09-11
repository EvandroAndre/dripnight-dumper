using System;

namespace proto;

public class TailorSettingDesc : IComparable<TailorSettingDesc>
{
	public uint tailor_id;

	public uint token_item_id;

	public uint token_box_item_id;

	public string token_box_bg_url;

	public string banner_url;

	public string bg_url;

	public string title;

	public string series_icon;

	public string entrance_anim;

	public uint legend_cloth_id;

	public long start_time;

	public long end_time;

	public uint sort_id;

	public uint universal_token_item_id;

	public int CompareTo(TailorSettingDesc other)
	{
		return 0;
	}
}
