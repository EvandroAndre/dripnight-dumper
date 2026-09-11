using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class PropAnimComponent : MonoBehaviour
{
	public Animation OwnedAnimation;

	public List<AnimationClip> AnimationClips;

	private void Awake()
	{
	}

	public void PlayAnim(int index, bool need_queue = false)
	{
	}

	public void PlayAnimNoBlending(int index)
	{
	}

	public void StopAnim()
	{
	}
}
