using System.Collections.Generic;

namespace proto;

public class SeventhBAccountInfo
{
	public enum SocialType
	{
		NONE,
		SOLO,
		TEAM
	}

	public SocialType social_type;

	public List<SeventhBChatper> chapters;

	public uint send_msg_id;

	public string other_message;

	public uint[] claimed_progress;

	public ulong signature_time;

	public string signature;
}
