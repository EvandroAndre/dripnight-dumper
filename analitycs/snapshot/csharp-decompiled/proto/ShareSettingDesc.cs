using ProtoBuf;

namespace proto;

public class ShareSettingDesc : IMessage
{
	public uint share_id;

	public string share_link_fb;

	public string share_link_vk;

	public string share_link_line;

	public string share_title_key;

	public string share_content_key;

	public string share_caption_key;

	public string sys_text_key_ios;

	public string sys_text_key_android;

	public string share_picture_url;

	public string share_link_whatsapp;

	public string share_link_instgram;

	public bool is_show_frame_sticker;

	public bool is_show_qr_code;

	public uint qr_code_type;

	public uint share_title;

	public uint custom_event_id;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
