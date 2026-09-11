using System;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
public class AnimationClipInfo
{
	public DIJJJMLPHBH mAnimType;

	public AnimationClip mAnimClip;

	[NonSerialized]
	public string mAnimName;

	public string SoundResourceID;
}
