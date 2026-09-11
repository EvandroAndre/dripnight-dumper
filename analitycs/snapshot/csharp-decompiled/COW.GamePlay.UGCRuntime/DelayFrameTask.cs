using System;

namespace COW.GamePlay.UGCRuntime;

public class DelayFrameTask
{
	public int delayFrames;

	public Action action;

	public int taskId;

	public DelayFrameTask(int frames, Action callback, int id)
	{
	}
}
