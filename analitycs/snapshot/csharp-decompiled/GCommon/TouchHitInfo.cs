using UnityEngine;

namespace GCommon;

public class TouchHitInfo : ObjectPoolCallbackBase
{
	public Touch touch;

	public GameObject hitObj;

	public bool hitCalled;

	public bool hasHit;

	public override void OnCollected()
	{
	}
}
