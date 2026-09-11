using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;

namespace COW;

public class UIBindAccountController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static SDKBind.GetBindSessionFaildCb _003C_003E9__17_1;

		internal void _003CBindGarena_003Eb__17_1(BindSessionResp rsp)
		{
		}
	}

	private UIBindAccountView m_View;

	private UIModelLogin m_ModelLogin;

	private Dictionary<int, bool> m_DicPlatformShowBig;

	private Dictionary<int, bool> m_PlatformSupportSignin;

	private Action m_CloseAction;

	public Action ClosAction
	{
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	private void InitPlatformBtns()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SetCDNTexture()
	{
	}

	public void SetShowLabel(bool isGameModeCall, string labelInfo = null, int guestRank = 0, int normalRank = 0, string titleKey = null)
	{
	}

	public void ShowAwardItem()
	{
	}

	private void Bind(PlatformType platform)
	{
	}

	private void BindGarena(PlatformType platform)
	{
	}

	private void PlatformLoginDone(PlatformType platformType, string userId, string accessToken)
	{
	}

	private void OnFacebookBindClick()
	{
	}

	private void OnVKontakteBindClick()
	{
	}

	private void OnHuaweiBindClick()
	{
	}

	private void OnGoogleBindClick()
	{
	}

	private void OnAppleBindClick()
	{
	}

	private void OnTwitterBindClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void InitBindPlatformDict()
	{
	}

	private void CheckPlatformBtnState(PlatformType platformType)
	{
	}

	private bool CheckPlatformBindBtnCanShow(bool showBigIcon, PlatformType platformType)
	{
		return false;
	}

	private void _003CBindGarena_003Eb__17_0(BindSessionResp rsp)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
