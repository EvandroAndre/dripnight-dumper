using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class BirthdayConfigDataManager : SingletonModule<BirthdayConfigDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BirthdayConfigData> _003C_003E9__5_0;

		internal int _003CGetBirthdayConfigDataList_003Eb__5_0(BirthdayConfigData a, BirthdayConfigData b)
		{
			return 0;
		}
	}

	private CSVAsyncDataMap<uint, BirthdayConfigData> m_Dict;

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

	public BirthdayConfigData GetBirthdayConfigDataById(uint id)
	{
		return null;
	}

	public List<BirthdayConfigData> GetBirthdayConfigDataList()
	{
		return null;
	}

	public List<uint> GetBirthdayConfigAchievementIdList()
	{
		return null;
	}

	public uint GetAnniversaryYear(uint days)
	{
		return 0u;
	}

	public uint GetRegisterDays()
	{
		return 0u;
	}

	public DateTime GetAnniversaryDatTime(uint anniversary)
	{
		return default(DateTime);
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
