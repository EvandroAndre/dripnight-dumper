using System.Collections.Generic;

namespace proto;

public class WorkshopTagMatchDesc
{
	public uint type_id;

	public string language;

	public uint[] tags;

	public uint[] recommend_maps;

	public uint sort_id;

	public string title;

	public string desc;

	public string cdn_url;

	public bool is_new;

	public bool force_resource_download;

	public List<string> workshop_codes;
}
