using UnityEngine;

namespace COW;

public class UILeaderBoardTitleProfileTable2Item : MonoBehaviour, UITable2.IUITable2Item
{
	public UILabel Text;

	public UIButton ButtonClick;

	public UILabel Text2;

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}
}
