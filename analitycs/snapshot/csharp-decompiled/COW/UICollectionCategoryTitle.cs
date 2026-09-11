using UnityEngine;

namespace COW;

public class UICollectionCategoryTitle : MonoBehaviour, UITable2.IUITable2Item
{
	public UILabel Name;

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}
}
