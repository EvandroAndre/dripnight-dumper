using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class AutoTaskPeriodicLadderRankUpReward : AutoPopupTask
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__9_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__9_2;

		internal BaseItemInfo _003CShowPeriodicLadderRankUpReward_003Eb__9_1(AwardDesc item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CShowPeriodicLadderRankUpReward_003Eb__9_2(BaseItemInfo item)
		{
			return null;
		}
	}

	private List<PeriodicRankData> m_PeriodicRankUpRewardList;

	private bool isPeriodicDone;

	private string rankName;

	private ResourceID RankIconRes;

	private uint rank;

	private OptionalRewardRankInfoWndCfg m_CurrentCfg;

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

	private void ShowPeriodicLadderRankUpReward()
	{
	}

	private void OnLadderRewardWndClose(object[] param)
	{
	}

	private void _003CShowPeriodicLadderRankUpReward_003Eb__9_0()
	{
	}
}
