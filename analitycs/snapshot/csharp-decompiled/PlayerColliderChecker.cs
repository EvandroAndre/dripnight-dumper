using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderChecker : MonoBehaviour
{
	public enum HitPart
	{
		Head,
		Neck,
		Chest,
		Hips,
		LeftArm,
		LeftForeArm,
		RightArm,
		RightForeArm,
		LeftUpLeg,
		LeftLeg,
		RightUpLeg,
		RightLeg,
		LeftFoot,
		RightFoot,
		LeftHand,
		RightHand,
		LeftClav,
		RightClav,
		NoFlag,
		WeakPoint,
		None
	}

	public enum ViewBoxPart
	{
		Chest,
		Head,
		Neck,
		Arm,
		ForeArm,
		UpLeg,
		Leg,
		Foot
	}

	public List<ColliderInfo> m_colliderInfoList;

	~PlayerColliderChecker()
	{
	}

	public void Start()
	{
	}

	public void ActiveColliders()
	{
	}

	public void FindColliders()
	{
	}

	public HitPart GetPartByCollider(Collider c)
	{
		return HitPart.Head;
	}

	public static int GetPartsMask(List<int> checkPartList)
	{
		return 0;
	}
}
