namespace proto;

public class PlatformRegisterReq
{
	public string nickname;

	public string access_token;

	public string open_id;

	public string region;

	public uint avatar_id;

	public uint platform_type;

	public uint platform_sdk_id;

	public EAccount.DownloadType source;

	public string editor_register_key;

	public EAccount.NewbieChoice newbie_choice;

	public byte[] platform_register_info;

	public string language;

	public EAuth.ClientUsingVersion using_version;

	public bool is_newbie_choice;

	public byte[] register_signature;

	public long register_time;

	public string client_version;

	public uint plat_id;
}
