using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISceneEditUGCRankRewardItemController : UIEasyListItemController
{
	private UISceneEditUGCRankRewardItemView m_View;

	private List<UISceneEditRankRewardReviewMiniItemController> m_MiniItemCtrlList;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
