using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFeedbackPopOverItem : MonoBehaviour
{
	public UISprite Icon;

	public UILabel Name;

	public UILabel Desc;

	public void SetData(uint id)
	{
	}

	public void SetShowData(ResourceID iconRes, string name, string desc2)
	{
	}

	public int GetContentHeight()
	{
		return 0;
	}
}
