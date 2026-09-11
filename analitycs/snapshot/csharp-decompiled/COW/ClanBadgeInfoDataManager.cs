using GCommon;

namespace COW;

internal class ClanBadgeInfoDataManager : SingletonModule<ClanBadgeInfoDataManager>
{
	public CSVAsyncDataMap<uint, ClanBadgeInfoData> DictClanBadgeInfo;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}
}
