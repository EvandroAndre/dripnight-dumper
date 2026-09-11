using System.Collections.Generic;
using UMA;
using UnityEngine;

public class PrefabDynamicboneV2 : MonoBehaviour
{
	public List<DynamicBone> m_DynamicBones;

	public HangManager m_HangManager;

	public bool InitOnAwake;

	private UMAData.DynamicBoneType m_Dynamicbonetype;

	private Animator m_Animator;

	private bool m_AnimationEventOn;

	private int previousStateHash;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnAnimationStateChange()
	{
	}

	private void OnDisableDB()
	{
	}

	private void OnEnableDB()
	{
	}
}
