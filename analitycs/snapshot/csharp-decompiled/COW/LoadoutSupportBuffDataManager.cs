using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class LoadoutSupportBuffDataManager : SingletonModule<LoadoutSupportBuffDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LoadoutSupportBuffData> _003C_003E9__3_0;

		internal int _003COnInit_003Eb__3_0(LoadoutSupportBuffData a, LoadoutSupportBuffData b)
		{
			return 0;
		}
	}

	public List<LoadoutSupportBuffData> m_LoadoutSupportBuffDataList;

	public Dictionary<uint, LoadoutSupportBuffData> m_LoadoutSupportBuffDataDic;

	private List<uint> m_LoadoutSupportBuffSlotUnlockCosts;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<LoadoutSupportBuffData> GetAllLoadoutSupportBuffData()
	{
		return null;
	}

	public LoadoutSupportBuffData GetLoadoutSupportBuffData(uint id)
	{
		return null;
	}

	public uint GetLoadoutSupportBuffSlotUnlockCost(int index)
	{
		return 0u;
	}
}
