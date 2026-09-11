namespace COW;

public class PhotoBackGroundData
{
	public enum EPhotoBackGroundType
	{
		Default,
		BigEvent,
		Goto
	}

	public uint template_id;

	public EPhotoBackGroundType bg_type;

	public string name;

	public string dream_file_name;

	public ulong end_time;

	public string preview_icon_cdn;

	public string bg_cdn;

	public bool is_own;

	public uint go_pos;

	public string sub_go_pos;

	public bool is_apply_dream;

	public string front_bg_cdn;

	public uint progress_value;
}
