using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class LobbyAvatarLookAtComponent : MonoBehaviour
{
	[Serializable]
	public class BaseParam
	{
		public float angleMin;

		public float angleMax;

		public float angleInMin;

		public float angleInMax;

		public float turnSpeed;

		public float inLerpSpeed;

		public float NewFrameAngleWeight;

		public bool UseSpeedCurve;

		public AnimationCurve AngleToSpeed;
	}

	[Serializable]
	public class HeadParam : BaseParam
	{
		public float neckRatio;
	}

	private class BaseState
	{
		public int m_LastFrame;

		public float m_LastFrameAngles;

		public float m_lastAngle;

		public float m_curAngle;
	}

	private class HeadState : BaseState
	{
		public float m_curNeck;

		public float m_tarNeck;

		public float m_curSpine1;

		public float m_tarSpine1;
	}

	private class EyesState : BaseState
	{
		public float m_curEye;

		public float m_tarEye;
	}

	public float angleMin;

	public float angleMax;

	public float angleInMin;

	public float angleInMax;

	public float turnSpeed;

	public float inLerpSpeed;

	public float NewFrameAngleWeight;

	private float m_DefaultAngleMin;

	private float m_DefaultAngleMax;

	private float m_DefaultAngleInMin;

	private float m_DefaultAngleInMax;

	private float m_DefaultTurnSpeed;

	private float m_DefaultInLerpSpeed;

	private float m_DefaultNewFrameAngleWeight;

	private Animator m_Animator;

	private Transform m_character;

	private static HashSet<int> m_Idle;

	public bool RotHead;

	public HeadParam HeadParams;

	private HeadState HeadStates;

	private Transform m_boneNeck;

	private Transform m_boneSpine1;

	public bool RotEyes;

	public BaseParam LeftEyeParams;

	public BaseParam RightEyeParams;

	private EyesState LeftEyeStates;

	private EyesState RightEyeStates;

	private Transform m_boneEyeL;

	private Transform m_boneEyeR;

	private Transform m_3DCamera;

	private int m_UIType;

	private void Start()
	{
	}

	public void Init(CSSharedAvatarData aData, AvatarLookAtData ldata, int uiType = -1, FrontEndPreviewComponent frontEndPreviewComponent = null)
	{
	}

	private static bool Contains(uint[] array, uint val)
	{
		return false;
	}

	public void Init(bool enable)
	{
	}

	private void InitHeadParams()
	{
	}

	private void InitHeadCurve(ref AnimationCurve AngleToSpeed)
	{
	}

	private void LateUpdate()
	{
	}

	private bool CheckAnimState()
	{
		return false;
	}

	private void UpdateHeadState(HeadParam p, HeadState s, bool animStateOk, float characterY)
	{
	}

	private void UpdateHeadStateInstant()
	{
	}

	private float UpdateBaseState(BaseParam p, BaseState s, bool animStateOk, float localEulerAngle, bool isHead)
	{
		return 0f;
	}

	private static void LerpToTargetByCurve(ref float cur, ref float tar, float scale, AnimationCurve angleToSpeed)
	{
	}

	private static void LerpToTarget(ref float cur, ref float tar, float step)
	{
	}

	private static void RotateTransform(Transform tr, float angle)
	{
	}
}
