using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCUploadManager : SingletonModule<UGCUploadManager>
{
	public MonoBehaviour CoroutineRoot;

	private Dictionary<int, SceneEditUploadTask> m_UploadTaskDictionary;

	private static int m_NextTaskId;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void Init(MonoBehaviour coroutineRoot)
	{
	}

	public bool StartUploadTask(List<UploadInfo> data, Action<int> onSuccess, Action<int> onFailure, out int taskId)
	{
		taskId = default(int);
		return false;
	}
}
