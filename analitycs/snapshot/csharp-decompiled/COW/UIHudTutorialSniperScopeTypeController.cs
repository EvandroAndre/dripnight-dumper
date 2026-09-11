using System;
using GCommon;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

internal class UIHudTutorialSniperScopeTypeController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Action videoPrepareAction;

		public Action videoStartAction;

		internal void _003CPrepareVideo_003Eb__0(VideoPlayer source)
		{
		}

		internal void _003CPrepareVideo_003Eb__1(VideoPlayer source, long frameIdx)
		{
		}
	}

	private UIHudTutorialSniperScopeTypeView m_View;

	private Action m_HideAction;

	private float m_Time;

	private int m_Second;

	private bool m_PressFireScope;

	private uint m_DelayCallPauseType2Video;

	private RenderTexture m_RenderTexture1;

	private RenderTexture m_RenderTexture2;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private void OnPressFireScopeBtn()
	{
	}

	private void OnClickScopeBtn()
	{
	}

	public void SetHideAction(Action hideAction)
	{
	}

	private void PrepareAllVideo()
	{
	}

	private void PrepareVideo(ResourceID videoResID, VideoPlayer videoPlayer, Action videoPrepareAction, Action<RenderTexture> cacheRenderTexture, Action videoStartAction = null)
	{
	}

	private void OnVideoPreparedType1()
	{
	}

	private void OnVideoPreparedType2()
	{
	}

	private void OnVideoStartedType2()
	{
	}

	public void SetRenderer(UITexture videoTexture, VideoPlayer videoPLayer, RenderTexture renderTexture)
	{
	}

	private void CacheRenderTexture1(RenderTexture renderTexture)
	{
	}

	private void CacheRenderTexture2(RenderTexture renderTexture)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
