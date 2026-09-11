using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIPaymentSquadTreasureTeamInfoPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TopUpMember> _003C_003E9__19_0;

		internal int _003CRefreshTeamInfo_003Eb__19_0(TopUpMember a, TopUpMember b)
		{
			return 0;
		}
	}

	private UIPaymentSquadTreasureTeamInfoPopupWindowView m_View;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private List<UIPaymentSquadTreasureTeammateItemController> m_MemberItemList;

	private TopUpTeam m_TopUpTeam;

	private TopUpTeamInvitation m_TopUpTeamInvitation;

	private ulong m_TeamId;

	private ESquadTreasureTeamInfoPopupWindowType m_ItemType;

	private uint m_SettingSquadNumber;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetViewData(TopUpTeam topUpTeam, ESquadTreasureTeamInfoPopupWindowType itemType)
	{
	}

	public void SetViewData(TopUpTeamInvitation topUpTeamInvitation, ESquadTreasureTeamInfoPopupWindowType itemType)
	{
	}

	public void SetViewData(ulong groupId, ESquadTreasureTeamInfoPopupWindowType itemType)
	{
	}

	private void OnBtnCheckClick()
	{
	}

	private void OnBtnJoinClick()
	{
	}

	private void InitView()
	{
	}

	private void InitTeammateItem(uint teammateNum)
	{
	}

	private void RefreshTeamInfo()
	{
	}

	private void RequestTeamInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
