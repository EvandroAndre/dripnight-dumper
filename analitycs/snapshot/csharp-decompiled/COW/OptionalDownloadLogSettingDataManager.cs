using System.Collections.Generic;
using GCommon;

namespace COW;

internal class OptionalDownloadLogSettingDataManager : SingletonModule<OptionalDownloadLogSettingDataManager>
{
	private List<OptionalDownloadLogSettingData> m_OptionalDownloadLogSettingDataList;

	public List<OptionalDownloadLogSettingData> OptionalDownloadLogSettingDataList => null;

	protected override void OnInit()
	{
	}

	private void ProcessOptionalDownloadLogSettingData()
	{
	}

	protected override void OnCleanup()
	{
	}
}
