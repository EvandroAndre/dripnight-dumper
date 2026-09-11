using UnityEngine;

namespace COW;

public interface IAIChatDraggableItem
{
	void SetContainerWidgetPosition(Vector3 location);

	Vector2 GetContainerWidgetSize();

	Transform GetContainerWidgetTransform();

	bool IsDragging();

	Vector2 GetBound();
}
