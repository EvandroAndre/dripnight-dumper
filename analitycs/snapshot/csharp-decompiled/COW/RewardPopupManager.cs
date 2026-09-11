using System.Collections.Generic;
using GCommon;

namespace COW;

public class RewardPopupManager : SingletonModule<RewardPopupManager>
{
	private const int MAX_ITEM_SHOWED_PER_POPUP = 5;

	private List<BaseItemInfo> m_CachedBaseItemInfo;

	private RewardPopupData m_RewardData;

	private int m_CurrentPopupIndex;

	private int m_RewardItemCount;

	private bool m_Finished;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void PopupNextRewards(object[] data)
	{
	}
}
