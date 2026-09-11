using System.Collections.Generic;
using GCommon;

namespace COW;

internal class ReportConfigDataManager : SingletonModule<ReportConfigDataManager>
{
	private List<GameModeReportConfigData> m_GameModeReportList;

	private List<ReportMainTypeConfigData> m_ReportMainTypeList;

	private List<ReportProfileConfigData> m_ReportProfileList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<uint> GetReportMainTypes(uint gameMode, uint matchMode, uint groupMode)
	{
		return null;
	}

	public List<uint> GetReportMainTypes()
	{
		return null;
	}

	public List<uint> GetReportTypeByMainType(uint type)
	{
		return null;
	}

	public uint GetReportMainTypeByReportType(uint reportType)
	{
		return 0u;
	}

	public List<uint> GetReportMainTypeInLobbyByType(uint type)
	{
		return null;
	}
}
