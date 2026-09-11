using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using WorldStreamer;

public interface IStreamerFunc
{
	Transform GetTargetPlayer();

	AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode, bool forceSync = false);

	AssetBundle GetStreamSceneAB();

	Dictionary<int, List<CFIJFGBBLON>> GetStreamScenePatchAB();

	byte[] GetStreamSceneABTexRefInfo();

	void OnLoadSceneFinish(bool result, string sourcePath = null);

	void RepeatAction(float interval, Action action);

	void NotifySceneEvent(StreamerType type, string name, GameObject go, bool loaded);
}
