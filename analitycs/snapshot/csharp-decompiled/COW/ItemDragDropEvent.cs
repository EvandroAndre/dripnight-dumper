using GCommon;
using UnityEngine;

namespace COW;

internal class ItemDragDropEvent : GEvent
{
	public Vector2 DeltaMove;

	public void Reset(Vector2 delta)
	{
	}
}
