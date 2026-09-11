using System.Collections.Generic;
using GCommon;

namespace COW;

internal class RejectReasonDataManager : SingletonModule<RejectReasonDataManager>
{
	private Dictionary<uint, RejectReasonData> m_Data;

	private RejectReasonData m_TimeOutRejectData;

	private RejectReasonData m_InGameRejectData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public RejectReasonData GetRejectReasonData(uint id)
	{
		return null;
	}

	public List<RejectReasonData> GetAllData()
	{
		return null;
	}

	public RejectReasonData GetTimeOutRejectData()
	{
		return null;
	}

	public RejectReasonData GetInGameRejectData()
	{
		return null;
	}
}
