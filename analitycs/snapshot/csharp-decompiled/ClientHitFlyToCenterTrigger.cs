using COW.GamePlay;
using UnityEngine;

public class ClientHitFlyToCenterTrigger : MonoBehaviour
{
	public Vector3 TargetFlyPostion;

	public float HitFlySpeedXZ;

	public float HitFlySpeedY;

	public float HitFlyTime;

	private Transform m_CachedTransform;

	private float m_lastHitFlyTime;

	private void Awake()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void HitFly(Player player)
	{
	}
}
