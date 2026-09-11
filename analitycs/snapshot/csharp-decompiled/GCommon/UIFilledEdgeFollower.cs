using UnityEngine;

namespace GCommon;

public class UIFilledEdgeFollower : MonoBehaviour
{
	public UIBasicSprite targetSprite;

	public Vector3 offset;

	public bool keepLocalZ;

	private void LateUpdate()
	{
	}

	private bool TryGetFillEdgeCenter(out Vector3 worldPosition)
	{
		worldPosition = default(Vector3);
		return false;
	}
}
