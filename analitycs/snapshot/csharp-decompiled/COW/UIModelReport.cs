using System;
using GCommon;
using message;
using tcp;

namespace COW;

public class UIModelReport : UIBaseModel
{
	public enum EReportMethod
	{
		Common,
		Ingame_MannualReport,
		Ingame_QuickReport,
		Ingame_MannualReportAfterQuickReport
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__4_0;

		internal void _003CSendHackerReportRequest_003Eb__4_0(HttpErrorCode errCode, object obj)
		{
		}
	}

	private const string ClanReportTimesKey = "ClanReportTimesKey";

	public uint ClanReportTimes
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	internal void SetFeedBackUDP(BBFHOBBBEKK msg)
	{
	}

	internal void SetFeedbackTCP(ReportFeedbackNtf msg)
	{
	}

	public void SendHackerReportRequest(ulong m_ReporteeUserId, string m_NickName, uint m_HeadPic, ulong m_MatchID, uint m_GameMode, uint m_MatchMode)
	{
	}

	public void ConsumeClanReportQuota()
	{
	}
}
