using UnityEngine;

public class ClientHitFlyTrigger : MonoBehaviour
{
	public float HitFlySpeedXZ;

	public float HitFlySpeedY;

	public float HitFlyTime;

	private Transform m_CachedTransform;

	private Vector3 m_LastTickPos;

	private Vector3 m_CurTickMoveDir;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
