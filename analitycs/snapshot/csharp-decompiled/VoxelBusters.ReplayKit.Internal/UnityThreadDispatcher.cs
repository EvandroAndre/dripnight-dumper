using System;
using System.Collections.Generic;
using VoxelBusters.ReplayKit.Common.DesignPatterns;

namespace VoxelBusters.ReplayKit.Internal;

public class UnityThreadDispatcher : SingletonPattern<UnityThreadDispatcher>
{
	private Queue<Action> m_queue;

	private static void OnBeforeSceneLoad()
	{
	}

	private void Update()
	{
	}

	public static void Enqueue(Action action)
	{
	}
}
