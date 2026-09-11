using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelShare : UIBaseModel
{
	private const string FALLBACK_INVITE_STR = "http://www.freefiremobile.com/mobile/ff/deeplink";

	private List<ShareSettingDesc> m_ShareSettingList;

	public override uint GetModelType()
	{
		return 0u;
	}

	private string ModifyTitleKey(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return null;
	}

	private string ModifyCaptionKey(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return null;
	}

	private string ModifyContentKey(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return null;
	}

	private string ModifySystemKey(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return null;
	}

	private static string MakeInviteUrl(UIUtils.ShareUrlType shareUrlType, string url, object[] data)
	{
		return null;
	}

	private static bool CheckIsValidToShare(UIUtils.ShareUrlType shareUrlType)
	{
		return false;
	}

	internal bool ShareLine(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return false;
	}

	internal bool ShareWhatsApp(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return false;
	}

	internal bool ShareInstagram(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return false;
	}

	internal bool ShareLoginPlatform(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return false;
	}

	internal bool ShareOther(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return false;
	}

	internal bool ShareCopyLink(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
		return false;
	}

	public void ProcessShareSetting(CSShareSettingDescRes res)
	{
	}

	public ShareSettingDesc GetShareSetting(uint shareID)
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public static string GetSystemTextKey(ShareSettingDesc data)
	{
		return null;
	}

	public static string MakeInviteUrl(uint shareType, string url, object[] data)
	{
		return null;
	}

	public void ShareActivity(EActivity.Event shareEvent)
	{
	}

	public void ShareCommon(EActivity.ShareType shareType)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
