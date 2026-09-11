using System;
using GCommon;
using UnityEngine;

namespace COW;

public class AtlasIconCDNResource : BaseIconCDNResource
{
	public GameObject AtlasGO;

	public UIAtlas AtlasCom;

	public string SpriteName;

	public UnityEngine.Object NeedAddAtlasGo;

	protected ObjectPool<AtlasIconCDNResource> OwnedPool;

	public override void OnAllocated()
	{
	}

	public override void OnAlphaStateSet(bool value)
	{
	}

	public override void OnCollected()
	{
	}

	public override void ReturnToPool()
	{
	}

	protected override void OnTextureDownloadFailed()
	{
	}

	protected override void OnTextureLoaded()
	{
	}

	public void RegisterInsGoAtlasDownload(ResourceID resID, ObjectPool<AtlasIconCDNResource> objectPool, Action<bool> onTextureDownloadedCallback)
	{
	}

	protected override void OnNormalTextureInfoDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	protected override void OnAlphaTextureInfoDownloadFailed(CDNDownloadFailedInfo info)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnAllocated()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAlphaStateSet(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCollected()
	{
	}

	public void _003C_003EiFixBaseProxy_ReturnToPool()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTextureDownloadFailed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnTextureLoaded()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNormalTextureInfoDownloadFailed(CDNDownloadFailedInfo P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAlphaTextureInfoDownloadFailed(CDNDownloadFailedInfo P0)
	{
	}
}
