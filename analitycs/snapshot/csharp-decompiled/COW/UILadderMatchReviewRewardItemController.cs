using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILadderMatchReviewRewardItemController : UIBaseController, UITable2.IUITable2Item
{
	private LadderMatchReviewRewardItemView m_View;

	private UIModelLadderMatch m_Model;

	private UICSRankIconController m_CSRankIconController;

	private UIBRRankIconController m_BRRankIconController;

	private UIHippoCrisisRankIconController m_HCRankIconController;

	private List<UILadderMatchReviewMiniItemController> m_MiniItemCtrlList;

	private UILadderMatchReviewMiniItemController m_FirstRankRewardItemCtr;

	private uint m_DelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(object data, int data_index)
	{
	}

	private void OnEnable()
	{
	}

	private void InitTrans()
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
