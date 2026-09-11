using UnityEngine;

public class HangCollider : MonoBehaviour
{
	public bool RemoveWhenUMARebuild;

	public virtual HangColliderType GetColliderType()
	{
		return HangColliderType.eNone;
	}
}
