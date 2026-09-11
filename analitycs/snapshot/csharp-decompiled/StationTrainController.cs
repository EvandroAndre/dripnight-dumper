using System.Collections.Generic;
using UnityEngine;

public class StationTrainController : MonoBehaviour
{
	public enum EState
	{
		EState_None,
		EState_Enter,
		EState_Idle,
		EState_Leave
	}

	public Animator TrainAnimator;

	public Animator EffectAnimator;

	public List<Renderer> TrainRenderList;

	public Transform PortalStart;

	public Transform PortalEnd;

	public Transform TrainMoveRoot;

	private List<Material> m_TrainMatList;

	private int m_Custom_PlaneNormalID;

	private int m_Custom_PlanePosID;

	private const string EnterAnim = "Enter";

	private const string LeaveAnim = "Leave";

	private const string IdleAnim = "Idle";

	public EState m_State;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlayEnterStation()
	{
	}

	public void PlayLeaveStation()
	{
	}

	public void PlayIdle()
	{
	}

	public void CloseTeleportEffect()
	{
	}

	private void Update()
	{
	}

	private void ProcessMatEnter()
	{
	}

	private void ProcessMatLeave()
	{
	}
}
