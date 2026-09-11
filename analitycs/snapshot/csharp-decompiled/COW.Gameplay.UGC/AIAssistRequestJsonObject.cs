using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class AIAssistRequestJsonObject
{
	public string utterance;

	public string audio;

	public string user_id;

	public string room_id;

	public string channel;

	public string usage_group;

	public string region;

	public List<string> knowledge_domain;

	public List<string> langs;

	public List<string> tools;
}
