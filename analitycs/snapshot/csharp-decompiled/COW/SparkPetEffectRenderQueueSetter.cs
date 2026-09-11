using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class SparkPetEffectRenderQueueSetter : MonoBehaviour
{
	private struct RendererQueueInfo
	{
		public Material material;

		public int originalQueue;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<RendererQueueInfo> _003C_003E9__7_0;

		internal int _003CApplyRenderQueue_003Eb__7_0(RendererQueueInfo a, RendererQueueInfo b)
		{
			return 0;
		}
	}

	public GameObject[] effectRoots;

	public int baseRenderQueue;

	public bool applyOnStart;

	private bool m_HasApplied;

	private List<RendererQueueInfo> m_QueueInfoList;

	private void Start()
	{
	}

	public void ApplyRenderQueue()
	{
	}

	public void SetEffectRoots(GameObject[] roots)
	{
	}

	public void ResetState()
	{
	}

	public void ForceApply()
	{
	}
}
