using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UILadderMatchSeasonInfoMissionItemController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<uint> _003C_003E9__5_1;

		public static Converter<uint, object> _003C_003E9__5_2;

		public static Predicate<uint> _003C_003E9__6_1;

		public static Converter<uint, object> _003C_003E9__6_2;

		internal bool _003CSetRewardData_003Eb__5_1(uint i)
		{
			return false;
		}

		internal object _003CSetRewardData_003Eb__5_2(uint s)
		{
			return null;
		}

		internal bool _003CSetRewardData_003Eb__6_1(uint i)
		{
			return false;
		}

		internal object _003CSetRewardData_003Eb__6_2(uint s)
		{
			return null;
		}
	}

	private UILadderMatchSeasonInfoMissionItemView m_View;

	public int MissionIndex;

	private List<UIStandardItemMiniController> m_RewardItemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetRewardData(RankingTaskInfo taskInfo)
	{
	}

	public void SetRewardData(CSRankingTaskInfo taskInfo)
	{
	}

	private void SetReward(List<BaseItemInfo> lst)
	{
	}

	private void RefreshBRMissionInfo()
	{
	}

	private void RefreshCSMissionInfo()
	{
	}

	private void _003CSetRewardData_003Eb__5_0()
	{
	}

	private void _003CSetRewardData_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
