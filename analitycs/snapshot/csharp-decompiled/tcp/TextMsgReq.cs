namespace tcp;

public class TextMsgReq
{
	public ulong sender_id;

	public ulong channel_id;

	public uint channel_type;

	public string content;

	public ulong send_at;

	public ulong group_id;

	public EChannel.MsgType msg_type;

	public string extra_info;

	public BriefProfile profile;

	public string channel_lang;

	public bool is_sixthb_distributor;

	public ExternalIconInfo external_icon_info;

	public LeaderboardTitleInfo leaderboard_titles;

	public ulong message_id;

	public string original_content;

	public bool is_seventhb_distributor;

	public bool is_eighthb_distributor;

	public AntiAddictionAgeAuthInfo br_auth_info;

	public GuardianTextChatSetting br_text_chat_setting;

	public string target_age_type;
}
