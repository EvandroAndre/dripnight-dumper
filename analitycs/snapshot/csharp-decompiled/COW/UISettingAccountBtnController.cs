using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;

namespace COW;

public class UISettingAccountBtnController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__8_0;

		internal void _003CRefreshBindIcon_003Eb__8_0()
		{
		}
	}

	public static List<int> SpriteList;

	private UIModelLogin m_LoginModel;

	public static Dictionary<int, string> SpriteMap;

	private AccountPlatform m_Type;

	private UISettingAccountBtnView m_View;

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

	private void RefreshBindIcon()
	{
	}

	private void OnHuaweiBindClick()
	{
	}

	private void OnGoogleBindClick()
	{
	}

	public AccountPlatform GetAccountPlatform()
	{
		return AccountPlatform.None;
	}

	private void _003CSetViewData_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
