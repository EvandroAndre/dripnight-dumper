using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityContentController : UIBaseController, IUIActivityContent
{
	public GameObject Root => null;

	public virtual void SetData(object data)
	{
	}

	public virtual void Reload()
	{
	}

	public virtual void HideContent()
	{
	}

	public virtual void CloseContent()
	{
	}

	public void ShowContent()
	{
	}

	public virtual void OnPopUpWindowListChange(bool isCovered)
	{
	}

	public virtual void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}
}
