using UnityEngine;

namespace COW;

public interface IUIActivityContent
{
	GameObject Root { get; }

	void SetData(object data);

	void Reload();

	void OnPopUpWindowListChange(bool isCovered);

	void OnVisibilityChange(bool isVisible, bool needRefresh);

	void HideContent();

	void CloseContent();

	void ShowContent();
}
