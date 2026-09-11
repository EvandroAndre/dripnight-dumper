using ProtoBuf;

namespace proto;

public class PatchOptionalResManagerUpdateDesc : IMessage
{
	public uint optional_re_def_id;

	public bool is_download;

	public bool is_show;

	public long show_time;

	public long end_time;

	public bool hide_after_download;

	public bool is_delete;

	public bool hide_in_login;

	public uint download_hardware;

	public uint auto_download_hardware;

	public uint download_sort_id;

	public uint gopos;

	public string sub_gopos;

	public bool force_download;

	public bool not_auto_download_old_resource;

	public uint hot_sort;

	public bool map_download;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
