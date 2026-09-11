namespace COW;

public interface ICommonSettingDragItem
{
	uint GetItemId();

	uint GetItemType();

	void SetDraggedUI(bool showDragged);
}
