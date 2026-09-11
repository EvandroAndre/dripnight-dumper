using System;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

public class LineMovePlatformController : MovePlatformController
{
	[Serializable]
	public class MoveData
	{
		public Transform m_MovePlatform;

		public float m_MoveSpeed;

		public bool m_IsNeedLoop;

		public bool m_IsFaceToFoward;

		public float m_RotSpeed;

		public bool m_IsHitKillPlayer;

		public bool EndToTurn;

		public List<Transform> m_MoveLine;

		public int curTargetNodeIndex;

		public bool isMovingForward;

		public bool isArrive;

		public Vector3 curMoveDirection;

		public Transform pathNodeRoot;
	}

	public List<MoveData> moveDataList;

	private bool CGMNGAJAMDF;

	private void Start()
	{
	}

	public void ResetMoveInEdiotr(bool LKNJJHLGJJN)
	{
	}

	private void Update()
	{
	}

	public void UpdateClientMove()
	{
	}

	public void CreateMoveData()
	{
	}

	public void RefreshPathNode()
	{
	}

	public void ClearAll()
	{
	}

	public Quaternion LookRotation(Vector3 ABLPDCDBOOC)
	{
		return default(Quaternion);
	}

	private Quaternion GKKIMFAGGBF(Vector3 BAPEDKECNLH, Vector3 GNCCIPHGLLD)
	{
		return default(Quaternion);
	}
}
