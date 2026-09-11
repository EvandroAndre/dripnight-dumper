using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

internal class PetsPawn : MonoBehaviour, JECKDOPHBBJ, IPetsPawnAnimPlayer
{
	public float PawnHeight;

	public List<PetAnimation> animationList;

	public Transform BipBoneTransform;

	private uint skinID;

	private Animation m_Animation;

	public ResourceID WalkSFXResId;

	public float AnimationBaseSpeed;

	private Dictionary<string, Transform> m_Bones;

	public void Init(uint skinid)
	{
	}

	public List<PetAnimation> BindAnimation()
	{
		return null;
	}

	private void SetAnimtionSpeed(string name, float scale)
	{
	}

	public void SetAnimtionEnable(bool enable)
	{
	}

	public GameObject GameObject()
	{
		return null;
	}

	public void OnEnterTransform()
	{
	}

	public void OnExitTransform()
	{
	}

	public void SetColliderEnable(bool isEnable, int layerMask)
	{
	}

	public Transform GetBoneByName(string boneName)
	{
		return null;
	}

	public bool IsUseTransformCameraBackOffset()
	{
		return false;
	}

	public void SetUseTransformCameraBackOffset(bool isUse)
	{
	}

	public void PlayAnim(string animName, float speed = 1f)
	{
	}

	public void PlayAnim(GJCFANLGPJN petAction)
	{
	}

	public void SetVisible(bool isVisible)
	{
	}
}
