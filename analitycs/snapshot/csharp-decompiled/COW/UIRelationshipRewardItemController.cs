using GCommon;
using proto;

namespace COW;

internal class UIRelationshipRewardItemController : UIBaseController
{
	private IntimacyAwardDesc m_desc;

	private IntimacyRankAwardInfo m_info;

	private UIRelationshipRewardItemView m_View;

	private ulong m_AccountID;

	private AwardItemState m_CurState;

	private const uint SpecialRankWithSpecialAwards = 5u;

	private EFriend.IntimacyAwardType m_IntimacyAwardType;

	public EFriend.IntimacyAwardType IntimacyAwardType => EFriend.IntimacyAwardType.IntimacyAwardType_ITEM;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetRewardItemInfo(IntimacyAwardDesc desc, IntimacyRankAwardInfo info, ulong accountID, AwardItemState state, EFriend.IntimacyAwardType intimacyAwardType)
	{
	}

	private void RefreshRewardState(AwardItemState state)
	{
	}

	private void ReceeiveRewards()
	{
	}

	public void SetLocalPosition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
