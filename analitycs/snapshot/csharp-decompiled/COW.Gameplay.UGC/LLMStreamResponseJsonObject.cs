using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class LLMStreamResponseJsonObject
{
	public string msg_id;

	public string content;

	public List<string> actions;

	public List<int> warnings;

	public int tokens;

	public string audio_bytes;

	public string audio_url;

	public int error;
}
