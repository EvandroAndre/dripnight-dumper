using System;
using UnityEngine;

namespace COW.OpSysExt;

public class WallpaperMgr : OpSysExt
{
	public static class Target
	{
		public const int HOMESCREEN = 1;

		public const int LOCKSCREEN = 2;

		public const int BOTH = 3;
	}

	private class Impl_Android : WallpaperMgr
	{
		private class WallpaperMgrCallback : AndroidJavaProxy
		{
			private sealed class _003C_003Ec__DisplayClass2_0
			{
				public WallpaperMgrCallback _003C_003E4__this;

				public long id;

				public string resource;

				public string result;

				internal void _003ConSetWallpaper_003Eb__0()
				{
				}
			}

			private Impl_Android _Mgr;

			public WallpaperMgrCallback(Impl_Android mgr)
				: base((string)null)
			{
			}

			public void onSetWallpaper(long id, string resource, string result)
			{
			}
		}

		private AndroidJavaClass _JavaClass;

		private WallpaperMgrCallback _Callback;

		private static LongSeqPool<Action<string, string>> _SetWallpaperCallbacks;

		public override bool CanSetWallpaper => false;

		public override string SetWallpaper(string resource, int target, Action<string, string> callback)
		{
			return null;
		}

		private void OnSetWallpaper(long id, string resource, string result)
		{
		}

		public bool _003C_003EiFixBaseProxy_get_CanSetWallpaper()
		{
			return false;
		}

		public string _003C_003EiFixBaseProxy_SetWallpaper(string P0, int P1, Action<string, string> P2)
		{
			return null;
		}
	}

	private static WallpaperMgr _I;

	public static WallpaperMgr I => null;

	public virtual bool CanSetWallpaper => false;

	protected WallpaperMgr()
	{
	}

	public virtual string SetWallpaper(string resource, int target, Action<string, string> callback)
	{
		return null;
	}
}
