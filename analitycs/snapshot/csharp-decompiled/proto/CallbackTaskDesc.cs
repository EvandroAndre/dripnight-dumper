using System.Collections.Generic;

namespace proto;

public class CallbackTaskDesc
{
	public uint callback_id;

	public uint task_id;

	public string act_text;

	public EFriend.CallbackTaskCdtType cdt_type;

	public uint cdt_value;

	public List<AwardDesc> awards;

	public uint gopos;

	public string sub_gopos;

	public string language;
}
