using UnityEngine;

namespace GCommon;

public class LCapsuleCollider : LCollider
{
	public Vector3 center;

	public float radius;

	public float height;

	public int direction;

	public override void OnRelease()
	{
	}
}
