using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudUGCMultiTeamMatchResultTeamItemController : UIEasyListItemController
{
	private UIHudUGCMultiTeamMatchResultTeamItemView m_View;

	private UIHudUGCMultiTeamMatchResultController m_parentController;

	private UIDetailTipsInUGCMatchResultController m_Tips;

	private int[] m_RankToScoreRule;

	private List<UIHudUGCMultiTeamMatchResultPlayerItemController> m_items;

	private static float playerItemHeight;

	private static float selfHeight;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	internal void SetParentController(UIHudUGCMultiTeamMatchResultController parentController)
	{
	}

	public void SetRankToScoreRule(int[] rankToScoreRule)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public static int CalculateContainerHeight(int numOfPlayerItem)
	{
		return 0;
	}

	private void OnQuestionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
