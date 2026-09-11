using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class AchievementSubTypeDataManager : SingletonModule<AchievementSubTypeDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<AchievementSubTypeData, uint> _003C_003E9__2_0;

		public static Comparison<AchievementSubTypeData> _003C_003E9__7_0;

		internal uint _003COnInit_003Eb__2_0(AchievementSubTypeData value)
		{
			return 0u;
		}

		internal int _003CGetBigEventSubTypeDataListForAchievement_003Eb__7_0(AchievementSubTypeData a, AchievementSubTypeData b)
		{
			return 0;
		}
	}

	private CSVAsyncDataMap<uint, AchievementSubTypeData> m_Dict;

	private List<CSVBaseData> m_List;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public AchievementSubTypeData GetAchievementSubTypeDataBySubTypeId(uint subTypeId)
	{
		return null;
	}

	public List<AchievementSubTypeData> GetAchievementSubTypeDataListByTypeId(uint typeId)
	{
		return null;
	}

	public List<AchievementSubTypeData> GetBigEventSubTypeDataListForAchievement()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
