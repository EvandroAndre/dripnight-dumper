using System.Collections.Generic;
using COW;
using GCommon;

public class ChannelGoposSummaryDataManager : SingletonModule<ChannelGoposSummaryDataManager>
{
	private Dictionary<uint, ChannelGoposSummaryData> m_Settings;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public ChannelGoposSummaryData GetDataByChannel(uint channel)
	{
		return null;
	}
}
