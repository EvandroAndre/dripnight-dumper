using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIClanTrendMemberTrendController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanTrendMemberTrendView m_View;

	private ClanTrendMsgInfo m_TrendInfo;

	private UIModelClan m_ModelClan;

	private UIModelClanTrend m_ModelClanTrend;

	private List<UIClanTrendMemberReactItemController> m_replyCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(object data, int index = 0)
	{
	}

	private void InitReactEmoteBtnShowState()
	{
	}

	private void RefreshEmoteReactShowState()
	{
	}

	private void InitReasonShowState()
	{
	}

	private void SetLadderSprite(ClanMember memberInfo)
	{
	}

	private void OnInfoLikeClickBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
