using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCResourceUIAtlas : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public Action<UGCResourceUIAtlas, string> callback;

		public string spriteName;

		internal void _003CGetAtlasResAndSprite_003Eb__0(bool succ, UGCResourceUIAtlas resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UGCResourceUIAtlas virtualAtlas;

		public string virtualResUUID;

		public AtlasIconCDNResource tempRes;

		internal void _003CGetBuiltInCDNAtlas_003Eb__0(bool succ)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public Action<UIAtlas, string> callback;

		public UISprite sp;

		internal void _003CSetAtlasAndSprite_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public string spriteName;

		public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals1;

		internal void _003CSetAtlasAndSprite_003Eb__0(bool succ, UGCResourceUIAtlas resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_2
	{
		public string spriteName;

		public ResourceID resID;

		public _003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals2;

		internal void _003CSetAtlasAndSprite_003Eb__2(uint tid, bool ret, UnityEngine.Object ffRes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Action<UIAtlas, string, string> callback;

		public string atlasAndSpriteStr;

		public UISprite sp;

		internal void _003CSetAtlasAndSprite_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_1
	{
		public string spriteName;

		public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals1;

		internal void _003CSetAtlasAndSprite_003Eb__0(bool succ, UGCResourceUIAtlas resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_2
	{
		public string spriteName;

		public ResourceID resID;

		public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals2;

		internal void _003CSetAtlasAndSprite_003Eb__2(uint tid, bool ret, UnityEngine.Object ffRes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public Action<UIAtlas, string> callback;
	}

	private sealed class _003C_003Ec__DisplayClass20_1
	{
		public string spriteName;

		public _003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals1;

		internal void _003CGetAtlasAndSprite_003Eb__0(bool succ, UGCResourceUIAtlas resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_2
	{
		public string spriteName;

		public ResourceID resID;

		public _003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals2;

		internal void _003CGetAtlasAndSprite_003Eb__1(uint tid, bool ret, UnityEngine.Object ffRes)
		{
		}
	}

	private AtlasIconCDNResource cdnAtlasRes;

	private UIAtlas m_atlas;

	private GameObject m_atlasResObj;

	private UGCMaterial m_material;

	private Material m_noZMaterial;

	private UIAtlas m_noZAtlas;

	private static Dictionary<string, List<Action<UGCResourceUIAtlas, string>>> s_CDNLoadingCallbacks;

	public static string S_ItemIconPrefix;

	public UIAtlas Atlas => null;

	private Material GetNoZMaterial()
	{
		return null;
	}

	public UIAtlas GetNoZAtlas()
	{
		return null;
	}

	private void ClearOtherResDependence()
	{
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

	public static string GetAtlasResAndSprite(string atlasAndSpriteStr, Action<UGCResourceUIAtlas, string> callback)
	{
		return null;
	}

	public static string GetBuiltInCDNAtlas(ResourceID resourceID, Action<UGCResourceUIAtlas, string> callback)
	{
		return null;
	}

	public static string SetAtlasAndSprite(UISprite sp, string atlasAndSpriteStr, Action<UIAtlas, string> callback)
	{
		return null;
	}

	public static string SetAtlasAndSprite(UISprite sp, string atlasAndSpriteStr, Action<UIAtlas, string, string> callback)
	{
		return null;
	}

	public static string GetAtlasAndSprite(string atlasAndSpriteStr, Action<UIAtlas, string> callback)
	{
		return null;
	}

	public static string GetUGCAtlasOfSprite(string atlasAndSpriteStr)
	{
		return null;
	}

	private void _003CLoadFromData_003Eb__11_0(bool succ, UGCMaterial resObj)
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
