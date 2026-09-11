using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class PersonaUpdateContextRequestJsonObject
{
	public string context;

	public string nickname;

	public string persona_id;

	public List<string> observer;

	public string user_id;

	public string room_id;

	public bool is_streaming;

	public string should_reply;

	public string usage_group;
}
