using GCommon;
using proto;

namespace COW;

public class UIActivityScrollViewController : UIActivityContentController
{
	public class Data
	{
		public uint goPos;

		public string subGoPos;

		public string image_url;

		public bool prefersExternal;

		public uint NetworkTextureEndTime;

		public Data(uint goPos, string subGoPos, string image_url, bool prefersExternal, uint networkTextureEndTime)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public ClientActivityDesc act;

		internal bool _003CSetData_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	private UIActivityScrollViewView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetData(object data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
