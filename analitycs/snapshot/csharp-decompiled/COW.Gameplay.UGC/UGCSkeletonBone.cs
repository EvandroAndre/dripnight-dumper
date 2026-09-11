using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSkeletonBone
{
	public enum EBoneControlPriority
	{
		none,
		buildin,
		property,
		controller,
		max
	}

	private UGCSkeletonBoneOwner m_owner;

	private bool m_isBoneMissed;

	public string BoneName;

	public Transform BoneTransform;

	public int BoneDepth;

	public Vector3 IKAxis;

	public int localScaleFlag;

	public EBoneControlPriority localScalePriority;

	public Vector3 localScale;

	public int worldPositionFlag;

	public EBoneControlPriority worldPositionPriority;

	public Vector3 worldPosition;

	public int localOffsetFlag;

	public EBoneControlPriority localOffsetPriority;

	public Vector3 localPositionOffset;

	public int worldRotationFlag;

	public EBoneControlPriority worldRotationPriority;

	public Quaternion worldRatation;

	private string ugcEntityID;

	private string m_gsUGCEntityID;

	public UGCSkeletonBoneOwner Owner => null;

	public void Create(UGCSkeletonBoneOwner owner, string boneName)
	{
	}

	public void RebindTransform()
	{
	}

	public void ValidateBoneGameObject()
	{
	}

	public void DisableAll()
	{
	}

	public bool IsNeedLateUpdate()
	{
		return false;
	}

	private void removeFlagAndPriority(EBoneControlPriority priority, ref int flag, ref EBoneControlPriority priorityRef)
	{
	}

	private void addFlagAndPriority(EBoneControlPriority priority, ref int flag, ref EBoneControlPriority priorityRef)
	{
	}

	public void RemoveLocalScale(EBoneControlPriority priority)
	{
	}

	public void RemoveWorldPosition(EBoneControlPriority priority)
	{
	}

	public void RemoveLocalPositionOffset(EBoneControlPriority priority)
	{
	}

	public void RemoveWorldRotation(EBoneControlPriority priority)
	{
	}

	public void AddLocalScale(EBoneControlPriority priority)
	{
	}

	public void AddWorldPosition(EBoneControlPriority priority)
	{
	}

	public void AddLocalPositionOffset(EBoneControlPriority priority)
	{
	}

	public void AddWorldRotation(EBoneControlPriority priority)
	{
	}

	public bool SetLocalScale(Vector3 scale, EBoneControlPriority priority = EBoneControlPriority.property)
	{
		return false;
	}

	public bool SetWorldPosition(Vector3 pos, EBoneControlPriority priority = EBoneControlPriority.property)
	{
		return false;
	}

	public bool SetLocalPositionOffset(Vector3 offset, EBoneControlPriority priority = EBoneControlPriority.property)
	{
		return false;
	}

	public bool SetWorldRotation(Quaternion rot, EBoneControlPriority priority = EBoneControlPriority.property)
	{
		return false;
	}

	public void ApplyTransformOnLateUpdate()
	{
	}

	public void AttachGSUGCEntity(string ugcEntityID)
	{
	}

	public void ReAttachUGCEntity(UGCRuntime runtime)
	{
	}

	public void AttachUGCEntity(UGCRuntime runtime, string ugcEntityID)
	{
	}

	public void Destroy()
	{
	}

	public UGCLogicEntity GetEntity()
	{
		return null;
	}

	private void fetchUGCEntityProperty()
	{
	}

	public void OnRepChange(long propID, UGCSimpleValue value)
	{
	}
}
