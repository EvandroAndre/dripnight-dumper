using UnityEngine;

namespace COW;

public interface ICommonSettingDragParent
{
	void OnItemDragMove(Vector3 pos);

	void OnItemDragStart(uint itemId, uint itemFromWhere);

	void OnItemDragRelease();

	GameObject GetDragItem(uint itemid);

	UIWidget GetDragBounds(uint itemId, uint itemType);

	void OnItemDragHover(int index);
}
