namespace proto;

public class CSGetPlayerPersonalShowReq
{
	public ulong account_id;

	public EAccount.CallSignSrc call_sign_src;

	public bool need_gallery_info;

	public bool need_blacklist;

	public bool need_spark_info;

	public bool need_photo_wall_ban;
}
