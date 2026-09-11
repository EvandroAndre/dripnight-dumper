using COW;
using GCommon;

public class WeaponExpRankDataManager : SingletonModule<WeaponExpRankDataManager>
{
	private CSVAsyncDataMap<uint, WeaponExpRankConfig> m_DictIdToWeaponExpRankConfig;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void LoadCSVData()
	{
	}

	public bool GetWeaponRankColor(uint rank, out string color)
	{
		color = null;
		return false;
	}
}
