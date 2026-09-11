using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using WorldStreamer;

namespace COW;

public class StreamerFuncImpl : IStreamerFunc
{
	public Transform GetTargetPlayer()
	{
		return null;
	}

	public AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode, bool forceSync = false)
	{
		return null;
	}

	public AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	public Dictionary<int, List<CFIJFGBBLON>> GetStreamScenePatchAB()
	{
		return null;
	}

	public byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	public void OnLoadSceneFinish(bool result, string sourcePath = null)
	{
	}

	public void RepeatAction(float interval, Action action)
	{
	}

	public void NotifySceneEvent(StreamerType type, string name, GameObject go, bool loaded)
	{
	}
}
