using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay;

public class BlueTearsWhale : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public BlueTearsWhale _003C_003E4__this;

		public Vector3 endPos;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	public TweenPosition tweenPosAnim;

	public float EndPortalStayTime;

	private bool IsPlayEndEffect;

	public List<Renderer> RenderList;

	private List<Material> m_MatList;

	private int m_Custom_PlaneNormalID;

	private int m_Custom_PlanePosID;

	private Vector3 mPortalStartPos;

	private Vector3 mPortalEndPos;

	private Vector3 mMoveDir;

	private uint mEndPortalTicketID;

	private uint mDelayCallTicket;

	private uint mWhaleID;

	private EventDelegate mOnTweenFinished;

	private void Awake()
	{
	}

	private void Start()
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

	public void OnRecycle()
	{
	}

	public void SetData(uint id, float progress, Vector3 startPos, Vector3 endPos, float moveSpeed)
	{
	}

	private void OnTweenPlayEnd()
	{
	}

	private void OnPlayEnd(uint id)
	{
	}

	public bool NeedPlayEndEffect()
	{
		return false;
	}

	public Vector3 GetMoveDir()
	{
		return default(Vector3);
	}
}
