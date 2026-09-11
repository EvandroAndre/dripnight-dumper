using System;
using GCommon;
using UnityEngine;

namespace COW;

public class BaseIconCDNResource : ObjectPoolCallbackBase
{
	public string TextureUrl;

	public string AlphaTextureUrl;

	public int TextureOriginalX;

	public int TextureOriginalY;

	public int TextureSizeX;

	public int TextureSizeY;

	public int TexturePosX;

	public int TexturePosY;

	public bool HasPending;

	public int TexturePaddingLeft;

	public int TexturePaddingRight;

	public int TexturePaddingTop;

	public int TexturePaddingBottom;

	public Texture2D AlphaTextureResult;

	public Texture2D NormalTextureResult;

	public ResourceID CDNICONResID;

	public bool DownloadSuccess;

	protected Action<bool> OnTextureDownloadFinished;

	protected bool alpahDownloadSuccess;

	protected bool normalDownloadSuccess;

	public bool AlphaCache;

	public bool NormalCache;

	private bool m_HasAlpha;

	public bool HasAlpha
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void ReturnToPool()
	{
	}

	public override void OnAllocated()
	{
	}

	public virtual void OnAlphaStateSet(bool value)
	{
	}

	public virtual void CollectRes()
	{
	}

	public void CollectNormalTexture()
	{
	}

	public void CollectAlphaTexture()
	{
	}

	protected virtual void OnNormalTextureInfoDownloaded(ResultTextureInfo info)
	{
	}

	protected virtual void OnAlphaTextureInfoDownloaded(ResultTextureInfo info)
	{
	}

	protected virtual void OnNormalTextureInfoDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	protected virtual void OnAlphaTextureInfoDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	protected NetworkDownloadEngine.OnDowloadFinished GetNormalTextureInfoDownloaded()
	{
		return null;
	}

	protected NetworkDownloadEngine.OnDownloadFailed GetNormalDownloadFailedCallBack()
	{
		return null;
	}

	public virtual NetworkDownloadEngine.OnDownloadFailed GetAlphaDownloadFailedCallBack()
	{
		return null;
	}

	protected virtual void OnTextureDownloadFailed()
	{
	}

	public NetworkDownloadEngine.OnDowloadFinished GetAlphaTextureInfoDownloaded()
	{
		return null;
	}

	protected virtual void OnTextureLoaded()
	{
	}

	private void _003CGetNormalTextureInfoDownloaded_003Eb__36_0(ResultTextureInfo result)
	{
	}

	private void _003CGetNormalDownloadFailedCallBack_003Eb__37_0(CDNDownloadFailedInfo info)
	{
	}

	private void _003CGetAlphaDownloadFailedCallBack_003Eb__38_0(CDNDownloadFailedInfo info)
	{
	}

	private void _003CGetAlphaTextureInfoDownloaded_003Eb__40_0(ResultTextureInfo result)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAllocated()
	{
	}
}
