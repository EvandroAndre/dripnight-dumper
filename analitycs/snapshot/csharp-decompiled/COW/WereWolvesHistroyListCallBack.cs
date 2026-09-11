using GCommon;
using UnityEngine;

namespace COW;

public class WereWolvesHistroyListCallBack : IEasyList
{
	private Transform m_content;

	public UIHudWereWolvesVoteController m_controller;

	public WereWolvesHistroyListCallBack(UIHudWereWolvesVoteController controller, Transform content)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}
}
