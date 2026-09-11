using UnityEngine;

namespace COW;

public class InGameEclipseManKillEffect : MonoBehaviour
{
	public GameObject MoveObject;

	public GameObject StartPoint;

	public float m_Duration;

	private Vector3 m_StartPos;

	private float m_MoveDistance;

	private float m_ElapsedTime;

	private bool m_IsMoving;

	public void Play(Vector3 startPos, float moveDistance)
	{
	}

	private void Update()
	{
	}
}
