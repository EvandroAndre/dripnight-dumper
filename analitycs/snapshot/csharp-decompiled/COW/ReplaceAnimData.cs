using GCommon;
using UnityEngine;

namespace COW;

public class ReplaceAnimData
{
	public bool Enabled;

	public bool Replaced;

	public bool Dirty;

	public AnimationClip DefaultAnim;

	public ResourceID OverrideAnimID;

	public ResourceID EffectID;

	public string OverrideSlotName;

	public bool HasOverrideAnim => false;

	public bool EnableAndReplaced => false;

	public void ResetDefaultAnim()
	{
	}

	public void ResetOverrideAnim()
	{
	}

	public void SetOverrideAnim(ResourceID id)
	{
	}

	public void SetEffect(ResourceID id)
	{
	}
}
