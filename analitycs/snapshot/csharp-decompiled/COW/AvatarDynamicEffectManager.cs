using GCommon;
using UnityEngine;

namespace COW;

public class AvatarDynamicEffectManager
{
	private Entity m_OwnerAvatar;

	private DynamicBone m_HairDynamicBone;

	private DynamicBone m_HairDynamicBone_L;

	private DynamicBone m_HairDynamicBone_R;

	private DynamicBone m_TailDBL;

	private DynamicBone m_TailDBR;

	private DynamicBone m_ClownHatDB;

	private bool m_IsHairDescending;

	private ITransformNode m_ChestL;

	private ITransformNode m_TailL;

	private ITransformNode m_TailR;

	private ITransformNode m_ClownHat;

	private ITransformNode m_ChestR;

	private ITransformNode m_HairNode;

	private ITransformNode m_HairNode_L;

	private ITransformNode m_HairNode_R;

	private DynamicBone[] m_DynamicBones;

	public Entity OwnerAvatar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected Transform ChestL => null;

	protected Transform TailL => null;

	protected Transform TailR => null;

	protected Transform ClownHat => null;

	protected Transform ChestR => null;

	protected Transform HairTransform => null;

	protected Transform HairTransform_L => null;

	protected Transform HairTransform_R => null;

	private void SetUpChestDynamicBone(DynamicBone dBone)
	{
	}

	public void SetUpHairDBStatus(bool isDescending)
	{
	}

	public void AddDynamicChest()
	{
	}

	public void OnPlayerGetOnFastMovePlatform()
	{
	}

	public void OnPlayerGetOffFastMovePlatform()
	{
	}

	public void SetupDynamicBoneForIngameMode()
	{
	}
}
