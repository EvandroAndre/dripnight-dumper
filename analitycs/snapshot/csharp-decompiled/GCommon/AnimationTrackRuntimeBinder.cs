using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace GCommon;

public class AnimationTrackRuntimeBinder : MonoBehaviour
{
	public AnimationTrackBindingPreset[] Presets;

	private bool m_Processed;

	private PlayableDirector m_Director;

	private TimelineAsset m_TimelineAsset;

	private List<AnimationTrackProcessedBinding> m_ProcessedBindings;

	private void Awake()
	{
	}

	public void BindWithPreset()
	{
	}

	public void UnbindWithPreset()
	{
	}

	public void Restore()
	{
	}

	private bool ValidationCheck()
	{
		return false;
	}

	private void ProcessBindingPreset(TimelineAsset timelineAsset)
	{
	}
}
