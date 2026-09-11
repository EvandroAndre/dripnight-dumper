using UnityEngine;

namespace COW;

public class UIDragEventForwarder : MonoBehaviour
{
	public GameObject Target;

	private void OnPress(bool isPressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnDragEnd()
	{
	}

	private void OnDragStart()
	{
	}

	private bool IsSuspendedHierarchy(GameObject go)
	{
		return false;
	}
}
