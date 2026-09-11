using System.Collections.Generic;
using GCommon;

namespace COW;

internal class SkipRewardPopupItemDataManager : SingletonModule<SkipRewardPopupItemDataManager>
{
	private HashSet<uint> m_SkpiRewardPopupItemIdSet;

	protected override void OnInit()
	{
	}

	public bool HasItemId(uint itemId)
	{
		return false;
	}

	protected override void OnCleanup()
	{
	}
}
