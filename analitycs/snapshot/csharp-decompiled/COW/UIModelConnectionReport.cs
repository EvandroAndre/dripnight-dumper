using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelConnectionReport : UIBaseModel
{
	private enum EPingNodeState
	{
		Waiting,
		Running,
		Paused
	}

	private delegate void OnCollectComplete();

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static NetworkDetection.MultiTaskComplete _003C_003E9__36_0;

		internal void _003CCollectCDNDownloadReportAndSend_003Eb__36_0(List<NetDetectionResult> results, object extra_data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public Report_Ping report_ping;

		public UIModelConnectionReport _003C_003E4__this;

		internal void _003CLogin_003Eb__2(List<NetDetectionResult> trace_results, object trace_extra_data)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIModelConnectionReport _003C_003E4__this;

		public int index;

		internal void _003CPingGSNode_003Eb__0(List<NetDetectionResult> result, object extra_data)
		{
		}
	}

	public static string[] CHECK_IP_LIST;

	public bool IsRunningCollectionTraceReport;

	private uint m_LoginNetworkErrCount;

	private uint m_ClearCountDelayCallID;

	private int m_LastDisconnectReason;

	public const uint PropID_TraceRouteReportSendingFlagUpdate = 2u;

	private bool _003CIsInSendingTraceRouteReport_003Ek__BackingField;

	private List<PingAddrDesc> m_PingServerIPList;

	private List<GSNodeInfo> m_GSNodeList;

	private int m_NextPingIndex;

	private EPingNodeState m_PingNodeState;

	private int m_MaxDetectionCount;

	private float m_NextDetectionTime;

	private Dictionary<string, Report_SelfDetection> m_DetectionResults;

	public bool IsInSendingTraceRouteReport
	{
		get
		{
			return _003CIsInSendingTraceRouteReport_003Ek__BackingField;
		}
		private set
		{
			_003CIsInSendingTraceRouteReport_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public void SetGSNodePing(int ping, string IDCName)
	{
	}

	public void SetFakeGSIDCPing()
	{
	}

	public void OnFrontEndGameDestroy()
	{
	}

	public void ConstractIDCPingResult(List<tcp.AccountIDCPingInfo> ping_list)
	{
	}

	public void ConstractProxyIDCPingResult(List<tcp.AccountIDCPingInfo> ping_list)
	{
	}

	private void PingGSNode(int index)
	{
	}

	private void TrimPort(ref string[] strAddress)
	{
	}

	public static bool HasNeedCheckIP()
	{
		return false;
	}

	public bool CheckNeedShowWhenLoginFailed()
	{
		return false;
	}

	public void OnServiceDisconnect(tcp.EAccount.Proto reason)
	{
	}

	public void CheckLastDisconnectReason()
	{
	}

	public void CollectNetworkReportAndSend(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void SelfNetworkDetection(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	private void OnModuleDetectionTaskFinished(List<NetDetectionResult> results, object extra_data)
	{
	}

	private void OnDectectionTaskFinished()
	{
	}

	public static void CollectCDNDownloadReportAndSend(string url)
	{
	}

	private void OnSendedReport()
	{
	}

	private void SendPingReport(Report_Ping report_Ping)
	{
	}

	private void SendTraceReport(Report_TraceRoute report_TraceRoute)
	{
	}

	private void SendUDPPingReport(Report_UDP_Ping report_udp_ping)
	{
	}

	private static void SendCDNTestReport(Report_CDNDownload report)
	{
	}

	private void _003CLogin_003Eb__20_0(List<NetDetectionResult> ping_results, object extra_data)
	{
	}

	private void _003CLogin_003Eb__20_1(List<NetDetectionResult> udp_ping_results, object extra_data)
	{
	}

	private void _003CCheckNeedShowWhenLoginFailed_003Eb__29_0()
	{
	}

	private void _003CCollectNetworkReportAndSend_003Eb__32_0(List<NetDetectionResult> ping_results, object ping_extra_data)
	{
	}

	private void _003CSelfNetworkDetection_003Eb__33_0(HttpErrorCode error_code, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
