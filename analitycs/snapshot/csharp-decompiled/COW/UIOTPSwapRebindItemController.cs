using System.Collections.Generic;
using GCommon;
using GarenaMSDK;

namespace COW;

public class UIOTPSwapRebindItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public UIOTPSwapRebindItemController _003C_003E4__this;

		public AccountPlatform type;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UIOTPSwapRebindItemView m_View;

	private UIModelLogin m_ModelLogin;

	private UIModelOTP m_ModelOTP;

	public static Dictionary<int, string> SpriteMap;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(AccountPlatform type)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
