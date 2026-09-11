using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UILauncherPopupMessageController : UIBaseController
{
	public enum EButtonStyle
	{
		None,
		OK,
		Update
	}

	public enum ELauncherMessageType
	{
		SystemError,
		Maintenance,
		HotUpdate,
		VersionUpdate,
		DownloadRetry
	}

	private sealed class _003CAutoScrollItem_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILauncherPopupMessageController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoScrollItem_003Ed__35(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILauncherPopupMessageView m_View;

	private EButtonStyle m_ButtonStyle;

	private ELauncherMessageType m_MessageType;

	private string m_Info;

	private string[] m_CDNUrlList;

	private string m_PatchNoteUrl;

	private string m_WebViewUrl;

	private WebView m_WebView;

	private string m_BGUrl;

	private bool m_HasMaxHint;

	private Action m_OnOK;

	private bool m_AllowCompatibleLogin;

	private Action m_OnCompatibleLogin;

	private Action m_OnRetry;

	private int m_selectedIndex;

	private List<UILobbyDotController> m_DotCtrls;

	private List<UINetworkTexture> m_NetworkTextures;

	private UICenterOnChild m_centerOnChild;

	private UIOfflinePlayTipsController m_OfflinePlayTipsCtrl;

	private static string defaultCDN;

	private static string defaultBGCDN;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void ShowMessageBox(string info, ELauncherMessageType mbType, Action onOK = null, EButtonStyle buttonStyle = EButtonStyle.OK, string[] urlList = null, string patchNoteUrl = null, Action onRetry = null, string webViewUrl = null, string bgUrl = null, string maxUrl = null, bool allowCompatibleLogin = false, Action onCompatibleLogin = null)
	{
	}

	private void OnPatchNoteBtnClick()
	{
	}

	private void OnBtnOKClick()
	{
	}

	private void OnBtnCompatibleLoginClick()
	{
	}

	private void OnBtnPlayOfflineClick()
	{
	}

	private void UpdateView()
	{
	}

	private IEnumerator AutoScrollItem()
	{
		return null;
	}

	private void OnAutoScrollAdItem()
	{
	}

	public override void Show()
	{
	}

	private UILobbyDotController CreateDot()
	{
		return null;
	}

	private void GetCenterItem(GameObject centeredObject)
	{
	}

	public void SetOfflineTipsVisible(bool visible)
	{
	}

	public void OpenOfflinePlayTips()
	{
	}

	private UIBaseController CreateUI(Transform root, string path, Type classType)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
