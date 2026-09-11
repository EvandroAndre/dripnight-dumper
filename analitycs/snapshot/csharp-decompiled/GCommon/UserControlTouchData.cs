using UnityEngine;

namespace GCommon;

public class UserControlTouchData
{
	public UserControlTouchInfo TouchInfo;

	public UserControlTouchInfo LastTouchInfo;

	private bool m_IsTouched;

	private bool m_IsActuallyMoved;

	private Vector3 m_StartScreenPos;

	private Vector3 m_CurrentScreenPos;

	private float m_ActuallyMovedDistance;

	private Vector3 m_CachedScreenPos;

	public UserControlTouchData(float actually_move_dist)
	{
	}

	public void OnBegin(Vector3 startPos)
	{
	}

	public void OnEnd()
	{
	}

	public void OnStationary(Vector3 curPos)
	{
	}

	public void OnMove(Vector3 lastPos, Vector3 curPos)
	{
	}

	public bool HaveCachedTouchPos()
	{
		return false;
	}

	public bool IsTouched()
	{
		return false;
	}

	public Vector3 GetCachedTouchPos()
	{
		return default(Vector3);
	}

	public void ClearTouchInfo()
	{
	}
}
