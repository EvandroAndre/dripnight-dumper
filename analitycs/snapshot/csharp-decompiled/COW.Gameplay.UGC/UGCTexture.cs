using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTexture : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Action<bool, bool, Texture2D> callback;

		public OnUGCResourceChanged _003C_003E9__1;

		internal void _003CGetTextureFromString_003Eb__0(bool succ, UGCTexture resObj)
		{
		}

		internal void _003CGetTextureFromString_003Eb__1(UGCResource res)
		{
		}
	}

	private Texture m_texture;

	private bool m_isDynamicCreatedTexture;

	private TextureLoadParams _003CLoadParams_003Ek__BackingField;

	public TextureLoadParams LoadParams
	{
		get
		{
			return _003CLoadParams_003Ek__BackingField;
		}
		private set
		{
			_003CLoadParams_003Ek__BackingField = value;
		}
	}

	public override void SetLoadParams(IUGCResourceLoadParams loadParams)
	{
	}

	public Texture2D GetTexture2D()
	{
		return null;
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, UnityEngine.Object resObject)
	{
	}

	public override void ReleaseUnityResRef()
	{
	}

	public static void GetTextureFromString(string resIDOrUUID, Action<bool, bool, Texture2D> callback)
	{
	}

	public void _003C_003EiFixBaseProxy_SetLoadParams(IUGCResourceLoadParams P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, UnityEngine.Object P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ReleaseUnityResRef()
	{
	}
}
