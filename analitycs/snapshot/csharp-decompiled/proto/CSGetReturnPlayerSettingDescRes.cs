using System.Collections.Generic;

namespace proto;

public class CSGetReturnPlayerSettingDescRes
{
	public ReturnPlayerSettingDesc return_player_setting_desc;

	public CallbackOpenInfoDesc callback_open_info_desc;

	public List<CallbackTaskDesc> callback_task_descs;

	public CallbackPointDesc callback_point_desc;

	public List<CallbackProcessDesc> callback_process_descs;
}
