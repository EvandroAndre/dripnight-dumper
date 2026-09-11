using GCommon;
using UnityEngine;

namespace COW;

public class UILadderKickOffRewardItemController : UIBaseController, UITable2.IUITable2Item
{
	private UILadderKickOffRewardItemView m_View;

	private ELadderRankTaskSubTab m_CurSubTab;

	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void SetViewData(int index, object data)
	{
	}

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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
