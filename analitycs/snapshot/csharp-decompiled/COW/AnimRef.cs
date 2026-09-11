using System;
using UnityEngine;

namespace COW;

[Serializable]
public class AnimRef : ScriptableObject
{
	public AnimationClip[] Clips;

	public AnimationClip GetClip0()
	{
		return null;
	}
}
