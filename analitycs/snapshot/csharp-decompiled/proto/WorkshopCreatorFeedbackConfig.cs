using System.Collections.Generic;

namespace proto;

public class WorkshopCreatorFeedbackConfig
{
	public uint desc_max_len;

	public uint screenshot_max_num;

	public ulong screenshot_max_size;

	public List<string> screenshot_format;

	public uint video_max_num;

	public ulong video_max_size;

	public List<string> video_format;

	public uint submit_interval_sec;
}
