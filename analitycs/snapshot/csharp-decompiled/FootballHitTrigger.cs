using UnityEngine;

public class FootballHitTrigger : MonoBehaviour
{
	private SphereCollider m_HitTrigger;

	private Vector3 m_CurMoveVelocity;

	private Transform m_CachTransform;

	public void InitTrigger(float triggerRadius)
	{
	}

	public void UpdateRadius(float triggerRadius)
	{
	}

	public void UpdateMoveVelocity(Vector3 velocity)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
