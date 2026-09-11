using System;
using COW.OpSysExt;
using UnityEngine;

namespace COW;

public class AlbumScreenShotImageTexture : MediaMgr.IAlbumImageTexture, IDisposable
{
	private Texture2D _003CTexture_003Ek__BackingField;

	public string NativeIdentifier => null;

	public Texture2D Texture
	{
		get
		{
			return _003CTexture_003Ek__BackingField;
		}
		private set
		{
			_003CTexture_003Ek__BackingField = value;
		}
	}

	public AlbumScreenShotImageTexture(byte[] bytes)
	{
	}

	public void Dispose()
	{
	}
}
