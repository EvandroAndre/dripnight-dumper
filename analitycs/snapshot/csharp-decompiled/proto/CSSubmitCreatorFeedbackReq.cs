using System.Collections.Generic;

namespace proto;

public class CSSubmitCreatorFeedbackReq
{
	public uint feedback_type;

	public string description;

	public string language;

	public string platform;

	public string device_model;

	public string os_version;

	public string project_id;

	public string project_name;

	public string project_url;

	public List<string> screenshot_urls;

	public List<string> video_urls;

	public uint template_type;

	public uint group_mode;

	public string editor_version;

	public string game_version;

	public string resource_version;

	public string network_type;

	public uint module_selection;

	public string report_log;
}
