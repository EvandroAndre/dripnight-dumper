using UnityEngine;

public interface ILayoutTableItem
{
	Vector2 GetSize();

	void Init();

	void UnInit();

	bool SkipPadding();
}
