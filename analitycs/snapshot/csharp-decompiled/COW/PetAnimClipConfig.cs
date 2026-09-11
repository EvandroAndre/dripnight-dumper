using System;
using UnityEngine;

namespace COW;

[Serializable]
public class PetAnimClipConfig
{
	public PetActionTag AnimType;

	public AnimationClip AnimClip;

	public static implicit operator PetAnimClipInfo(PetAnimClipConfig conf)
	{
		return null;
	}
}
