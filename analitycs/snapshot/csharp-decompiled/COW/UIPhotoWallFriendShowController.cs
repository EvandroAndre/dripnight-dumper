using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class UIPhotoWallFriendShowController : UINavigationController
{
	private sealed class _003CLoadPhotoWallTexture_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string photoWallUrl;

		public uint loadVersion;

		public UIPhotoWallFriendShowController _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadPhotoWallTexture_003Ed__19(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIPhotoWallFriendShowView m_View;

	private const string DefaultNavigationTitle = "Photo Wall";

	private const string DefaultResourceName = "UIPhotoWallFriendShow";

	private ulong m_AccountId;

	private BaseProfileInfo m_ProfileInfo;

	private SocialBasicInfo m_SocialBasicInfo;

	private AccountInfoBasic m_AccountInfoBasic;

	private Texture2D m_RuntimePhotoWallTexture;

	private Coroutine m_LoadPhotoWallCoroutine;

	private uint m_PhotoWallLoadVersion;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnReportBtnClick()
	{
	}

	private void RefreshPhotoWallTexture()
	{
	}

	private void RefreshBanTipState()
	{
	}

	private string GetPhotoWallUrl()
	{
		return null;
	}

	private void CancelPhotoWallLoading()
	{
	}

	private IEnumerator LoadPhotoWallTexture(string photoWallUrl, uint loadVersion)
	{
		return null;
	}

	private void ReleaseRuntimePhotoWallTexture()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
