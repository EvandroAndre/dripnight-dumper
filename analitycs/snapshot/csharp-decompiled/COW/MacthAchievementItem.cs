using System.Collections.Generic;
using UnityEngine;
using proto;

namespace COW;

internal class MacthAchievementItem
{
	public class ReplayFeedbackItemData
	{
		public IngameFeedbackData data;

		public int count;

		public ReplayFeedbackItemData(IngameFeedbackData feedData, int item)
		{
		}
	}

	public class ReplayMatchAchievementItemData
	{
		public ReplayMatchAchievementData data;

		public int count;

		public List<string[]> args;

		private int _003Cargs_count_003Ek__BackingField;

		public int args_count
		{
			get
			{
				return _003Cargs_count_003Ek__BackingField;
			}
			private set
			{
				_003Cargs_count_003Ek__BackingField = value;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		public string[] get_Item(int index)
		{
			return null;
		}

		public void AddArgs(string[] parmas)
		{
		}

		internal static List<ReplayMatchAchievementItemData> GetReplayMatchAchievementItemDatas(List<ReplayAchievementData> achievementList, List<ReplayAchievementArgs> achievementArgsList)
		{
			return null;
		}

		internal static List<ReplayMatchAchievementItemData> GetReplayMatchAchievementItemDatas(uint[] achievements, List<MatchEventAchievementArgs> args_list)
		{
			return null;
		}

		private static ReplayMatchAchievementItemData GetReplayMatchAchievementItemData(uint id, List<ReplayMatchAchievementItemData> list)
		{
			return null;
		}

		private static string[] GetAchievementArgs(int index, List<MatchEventAchievementArgs> list)
		{
			return null;
		}

		private static string[] GetAchievementArgs(uint serial, List<ReplayAchievementArgs> list)
		{
			return null;
		}

		private static int MatchAchievementSort(ReplayMatchAchievementItemData left, ReplayMatchAchievementItemData right)
		{
			return 0;
		}

		internal static string GetAchievementDesc(ReplayMatchAchievementItemData achievement_data)
		{
			return null;
		}
	}

	private ReplayMatchAchievementItemData mAchievementItemData;

	private ReplayFeedbackItemData feedbackData;

	private GameObject go;

	private UIButton button;

	private GameObject effect;

	public MacthAchievementItem(ReplayMatchAchievementItemData aData, GameObject sprite)
	{
	}

	public MacthAchievementItem(ReplayFeedbackItemData data, GameObject sprite)
	{
	}

	private void OnClickMedal()
	{
	}

	private void OnClick()
	{
	}

	public void Clear()
	{
	}
}
