using GCommon;
using proto;

namespace COW;

public class UIActivityContentAnnouncementController : UIActivityContentController
{
	public class Data
	{
		public string introduction;

		public uint goPos;

		public string subGoPos;

		public bool prefersExternal;

		public string image_url;

		public uint NetworkTextureEndTime;

		public Data(string introduction, uint goPos, string subGoPos, bool prefersExternal, string image_url, uint networkTextureEndTime)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public ActivityGroupDesc groupDesc;

		internal bool _003CSetData_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	private UIActivityContentAnnouncementView m_View;

	private Data m_SelectInfo;

	private CommunityWebsiteData m_websiteData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override void SetData(object data)
	{
	}

	private void OnOperate()
	{
	}

	private void OpenCommunityWebsite(bool facebook = false, bool offical = false)
	{
	}

	private CommunityWebsiteData GetCommunityWebsiteData()
	{
		return null;
	}

	private void _003COnUIInit_003Eb__5_0()
	{
	}

	private void _003COnUIInit_003Eb__5_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
