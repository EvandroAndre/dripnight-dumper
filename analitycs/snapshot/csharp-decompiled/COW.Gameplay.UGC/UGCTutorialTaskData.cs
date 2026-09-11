using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialTaskData
{
	public string taskId;

	public string hintTextLocKey;

	public UGCTutorialCameraPoseData cameraPose;

	public List<UGCTutorialAtomicTaskData> atomicTasks;
}
