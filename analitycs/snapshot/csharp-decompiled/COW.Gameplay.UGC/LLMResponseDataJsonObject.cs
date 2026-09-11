using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class LLMResponseDataJsonObject
{
	public string role;

	public string content;

	public int tokens;

	public int completion_tokens;

	public int prompt_tokens;

	public int total_tokens;

	public string status;

	public List<string> actions;

	public string msg_id;
}
