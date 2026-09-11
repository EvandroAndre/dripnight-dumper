using System.Collections.Generic;
using GCommon;

namespace COW;

public class FriendTagRuleDataManager : SingletonModule<FriendTagRuleDataManager>
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public RecommendedFriendTag tag;

		internal bool _003CGetTagData_003Eb__0(FriendTagRuleData x)
		{
			return false;
		}
	}

	public List<FriendTagRuleData> m_FriendTagRoleDataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public FriendTagRuleData GetTagData(RecommendedFriendTag tag)
	{
		return null;
	}
}
