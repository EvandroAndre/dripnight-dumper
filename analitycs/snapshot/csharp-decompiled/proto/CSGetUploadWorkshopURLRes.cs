using System.Collections.Generic;

namespace proto;

public class CSGetUploadWorkshopURLRes
{
	public uint slot_id;

	public long update_time;

	public string project_settings_url;

	public string export_settings_url;

	public string open_attributes_ext_url;

	public string map_cover_url;

	public List<string> map_screenshot_urls;

	public List<string> customize_resource_screenshot_urls;

	public bool is_map_cover_need_audit;
}
