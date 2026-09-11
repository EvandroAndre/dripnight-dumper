using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentSquadTreasureInviteItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIPaymentSquadTreasureInviteItemView m_View;

	private UIModelFriends m_ModelFriends;

	private TopUpTeamInvitation m_Info;

	private UIPaymentSquadTreasureInviteItemDetailController m_DetailCtrl;

	private Vector3 m_DefaultRankScale;

	private Vector3 m_GrandmasterRankScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(TopUpTeamInvitation info)
	{
	}

	private void RefreshBaseInfo()
	{
	}

	private void RefreshInvitationDetail()
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
}
