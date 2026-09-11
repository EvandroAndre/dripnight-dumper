using System;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

internal class ShowPreview : IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__13_0;

		internal void _003CSetPreview_003Eb__13_0()
		{
		}
	}

	private UGCSimpleDownloadTask m_DownloadTask;

	private UINewDownloadInfoController mDownloadCtrl;

	private UGCPreview m_Preview;

	private UINetworkTexture m_NetworkTexture;

	private UISprite m_Sprite;

	private UITexture m_Texture;

	private UISprite m_cornerMark;

	private IHDACHNBFNG m_ResourceType;

	public Vector2Int DownloadIconSize;

	private Vector2Int m_PreviewTextureSize;

	public ShowPreview(UINewDownloadInfoController downloadCtrl, UINetworkTexture NetworkTexture, UISprite Sprite, UITexture Texture, UISprite cornerMark, Vector2Int downloadIconSize)
	{
	}

	public bool Show(UGCPreview preview, IHDACHNBFNG resourceType)
	{
		return false;
	}

	public void Destroy()
	{
	}

	public bool SetPreview()
	{
		return false;
	}

	private bool SetDefaultPreview()
	{
		return false;
	}

	private bool CheckResResDownloader(UGCPreview preview)
	{
		return false;
	}

	private void OnUGCResDownloaderClickForTexture()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}
}
