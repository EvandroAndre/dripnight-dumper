using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class AutoTaskCSLadderRankUpReward : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__10_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__10_1;

		internal BaseItemInfo _003CShowCSLadderRankUpReward_003Eb__10_0(AwardDesc item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CShowCSLadderRankUpReward_003Eb__10_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private List<LadderLevelData> m_CSRankUpRewardList;

	private bool isCSDone;

	private string rankName;

	private ResourceID RankIconRes;

	private uint rank;

	private OptionalRewardRankInfoWndCfg m_CurrentCfg;

	private int m_RankDataIndex;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	private void ShowCSLadderRankUpReward()
	{
	}

	private void OnLadderRewardWndClose(object[] param)
	{
	}
}
