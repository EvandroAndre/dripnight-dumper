using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

public class UIBooyahPassVideoPlayerController : UINavigationController
{
	private sealed class _003CLoadAndPrepare_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBooyahPassVideoPlayerController _003C_003E4__this;

		private VideoClip _003Cclip_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLoadAndPrepare_003Ed__17(int _003C_003E1__state)
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

	private RenderTexture renderTexture;

	private UIBooyahPassVideoView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private ulong m_AccountID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnVideoMaskBtnClick()
	{
	}

	private void OnVideoSkipBtnClick()
	{
	}

	private void Update()
	{
	}

	public void OnPauseVideo(bool paused)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void StartPlay()
	{
	}

	public void SetupRenderer()
	{
	}

	public bool IsPrePareSuccess()
	{
		return false;
	}

	private void CloseCallBack()
	{
	}

	private IEnumerator LoadAndPrepare()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
