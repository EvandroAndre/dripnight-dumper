using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class PersonaChatRequestJsonObject
{
	public string utterance;

	public string nickname;

	public string persona_id;

	public string user_id;

	public string room_id;

	public string role;

	public string should_reply;

	public string language;

	public string voice;

	public List<string> observer;

	public string usage_group;
}
