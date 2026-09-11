using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCResourceUIAtlasCache
{
	private class CacheData
	{
		public bool isLoaded;

		public UIAtlas atlas;

		public string spriteName;

		public List<UISprite> delaySetSpriteList;
	}

	private static UGCResourceUIAtlasCache _instance;

	private Dictionary<string, CacheData> m_cache;

	private Action<UIAtlas, string, string> m_asyncCallback;

	public static UGCResourceUIAtlasCache instance => null;

	private UGCResourceUIAtlasCache()
	{
	}

	public void Clear()
	{
	}

	private void onAsyncCallback(UIAtlas atlas, string spriteName, string atlasAndSpriteStr)
	{
	}

	public void AsyncSetSprite(UISprite sp, string atlasAndSpriteStr)
	{
	}
}
