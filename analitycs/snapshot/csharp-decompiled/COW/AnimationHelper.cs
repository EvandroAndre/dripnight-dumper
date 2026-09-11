using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class AnimationHelper : MonoBehaviour
{
	private Animation m_Animation;

	private List<string> m_AnimStateNames;

	private string[] m_AnimClipNameArray;

	private void Awake()
	{
	}

	public AnimationState GetAnimStateByIndex(int index)
	{
		return null;
	}

	public string[] GetAnimClipNamesArray()
	{
		return null;
	}

	public void PlayByIndexSetDuration(int index, float duration)
	{
	}

	public void PlayByIndex(int index)
	{
	}

	public void SampleByIndex(int clipIndex, float samplePercentage)
	{
	}

	public void PlayQueuedByIndex(int index, QueueMode queue = QueueMode.CompleteOthers)
	{
	}
}
