using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class EffectObject
{
	public EEffectType effectType;

	public bool isLoop;

	public GameObject gameObject;

	public SkinnedMeshRenderer[] effectHeadRenderers;

	public int resHash;

	public bool isTailor;

	public bool isSoloEffectTrigger;

	public uint multiEffectTrigerType;

	public uint ClothID;

	public bool extraEffect;

	public bool ControlBySkeleton;

	public bool ControlByMultiStateSkeleton;

	public bool ProcessedMultiStateBoneNameRef;

	public List<GameObject> BoneObjects;

	public bool VFXMandatoryDisplay;

	public uint EffectsTriggerID;
}
