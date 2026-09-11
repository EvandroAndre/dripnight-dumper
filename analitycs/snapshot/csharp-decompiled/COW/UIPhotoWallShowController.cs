using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

public class UIPhotoWallShowController : UINavigationController
{
	private sealed class _003CLoadPhotoWallTexture_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string photoWallUrl;

		public uint loadVersion;

		public UIPhotoWallShowController _003C_003E4__this;

		private UnityWebRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadPhotoWallTexture_003Ed__18(int _003C_003E1__state)
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

	private UIPhotoWallShowView m_View;

	private const string DefaultNavigationTitle = "Photo Wall";

	private ulong m_AccountId;

	private AccountInfoBasic m_AccountInfoBasic;

	private AccountPersonalShowInfo m_AccountPersonalShowInfo;

	private Texture m_LocalSavedPhotoWallTexture;

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

	private void OnEditBtnClick()
	{
	}

	private void RefreshPhotoWallTexture()
	{
	}

	private void OnPhotoWallSaveSuccessEvent(object[] data)
	{
	}

	private void ReleaseLocalSavedPhotoWallTexture()
	{
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

	private string GetPhotoWallUrl()
	{
		return null;
	}

	private void RefreshBanTipState()
	{
	}

	private void RefreshBanCountDown(bool isBanned)
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
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

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
