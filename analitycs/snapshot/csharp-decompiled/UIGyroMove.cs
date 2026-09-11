using UnityEngine;

public class UIGyroMove : MonoBehaviour
{
	public bool m_EnableGyro;

	public float m_MoveSpeed;

	public float m_RebackSpeed;

	public float m_XLimit;

	public float m_YLimit;

	private Transform m_Transform;

	private Vector3 m_OriginPosition;

	private void Start()
	{
	}

	public bool IsEnable()
	{
		return false;
	}

	private void Update()
	{
	}
}
