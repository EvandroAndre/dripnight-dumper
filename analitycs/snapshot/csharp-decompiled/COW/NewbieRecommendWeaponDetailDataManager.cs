using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class NewbieRecommendWeaponDetailDataManager : SingletonModule<NewbieRecommendWeaponDetailDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<NewbieWeaponRecommendData> _003C_003E9__18_0;

		internal int _003CRefreshNewbieShowWeapon_003Eb__18_0(NewbieWeaponRecommendData x, NewbieWeaponRecommendData y)
		{
			return 0;
		}
	}

	private List<NewbieWeaponRecommendData> m_NewbieWeaponRecommendDataLists;

	private CSVAsyncDataMap<uint, NewbieWeaponRecommendData> m_CsvData;

	private CSVAsyncDataMap<uint, NewbieWeaponRecommendDetailData> m_NewbieWeaponConfigDict;

	private Dictionary<uint, List<NewbieWeaponRecommendData>> m_ShowTypeToRecommendWeaponTypes;

	private List<NewbieWeaponRecommendData> m_NewbieRecommendWeaponTypes;

	private List<NewbieWeaponRecommendData> m_OtherWeaponTypeShow;

	private Dictionary<uint, List<NewbieWeaponRecommendDetailData>> m_WeaponTypeToRecommendWeapon;

	private bool m_Init;

	public const int MAX_DETAIL_DATA_COUNT = 2;

	public const int WEAPONTYPES_MAX_COUNT = 9;

	private bool m_HaveRefreshAnyWeaponType;

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

	public void ReSetInit()
	{
	}

	public void InitCsvData()
	{
	}

	public List<NewbieWeaponRecommendData> GetNewbieWeaponRecommendDatas()
	{
		return null;
	}

	public NewbieWeaponRecommendDetailData GetNewWeaponRecommendDetailData(uint weaponId)
	{
		return null;
	}

	public void RefreshNewbieShowWeapon()
	{
	}

	public List<NewbieWeaponRecommendData> GetNewbieRecommendWeaponTypes()
	{
		return null;
	}

	public List<NewbieWeaponRecommendData> GetOtherShowWeaponTypes()
	{
		return null;
	}

	public List<NewbieWeaponRecommendDetailData> GetNewbieRecommendWeaponByType(uint weaponType)
	{
		return null;
	}

	private bool IsOverNewbieRecommendWeaponExp(uint weaponId)
	{
		return false;
	}

	private bool IsAnyWeaponOverNewbieRecommendWeaponExp(NewbieWeaponRecommendData data)
	{
		return false;
	}

	public bool IsNewbieRecommendWeapon(uint weaponId)
	{
		return false;
	}

	public bool HaveRefreshWeaponType()
	{
		return false;
	}

	private int _003CRefreshNewbieShowWeapon_003Eb__18_1(NewbieWeaponRecommendData x, NewbieWeaponRecommendData y)
	{
		return 0;
	}

	private int _003CRefreshNewbieShowWeapon_003Eb__18_2(NewbieWeaponRecommendDetailData x, NewbieWeaponRecommendDetailData y)
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
