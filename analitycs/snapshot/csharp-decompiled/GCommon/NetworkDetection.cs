using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

public class NetworkDetection : MonoBehaviour
{
	public delegate void MultiTaskComplete(List<NetDetectionResult> results, object extra_data);

	private class PingInfo
	{
		public float PingTime;

		public bool IsTimeOut;

		public string Address;

		public string IDCName;
	}

	private class TaskInfo
	{
		public List<string> TargetIPList;

		public List<NetDetectionResult> Results;

		public int IPCount;

		public ETaskType TaskType;

		public ETaskFunction TaskFunc;

		public uint ThreadCount;

		public object ExtraData;

		public string[] IDCNames;

		public int PingCount;

		private MultiTaskComplete call_back;

		public TaskInfo(string[] target_ip_list, ETaskType type, ETaskFunction func, MultiTaskComplete complete_callback, uint thread_count = 1u, object extra_data = null, string[] idc_name = null)
		{
		}

		public string GetNextPingAddress()
		{
			return null;
		}

		public void InvokeComplete()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public TracerouteResult result;

		internal void _003COnTraceRouteCompleted_003Eb__0()
		{
		}
	}

	private sealed class _003CLobbyMultiplePingTask_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDetection _003C_003E4__this;

		public TaskInfo task_info;

		public List<PingInfo> infos;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLobbyMultiplePingTask_003Ed__24(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CLobbyPingInternal_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string address;

		public string idcName;

		public List<PingInfo> infos;

		public NetworkDetection _003C_003E4__this;

		public TaskInfo task_info;

		public bool oneTargetIp;

		private Ping _003Cping_003E5__2;

		private float _003Cused_time_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLobbyPingInternal_003Ed__26(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CLobbyPingTask_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDetection _003C_003E4__this;

		public string address;

		public string idcName;

		public List<PingInfo> infos;

		public TaskInfo task_info;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CLobbyPingTask_003Ed__25(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CMultiPing_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string address;

		public List<PingInfo> infos;

		public NetworkDetection _003C_003E4__this;

		public TaskInfo task_info;

		private Ping _003Cping_003E5__2;

		private float _003Cused_time_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMultiPing_003Ed__23(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CMultiUDPPing_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TaskInfo task_info;

		public NetworkDetection _003C_003E4__this;

		private string _003Cping_address_003E5__2;

		private float _003Cstart_time_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMultiUDPPing_003Ed__20(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CTestCDN_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NetworkDetection _003C_003E4__this;

		public string url;

		private UnityWebRequest _003CwebRequest_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTestCDN_003Ed__34(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const float PING_TIMEOUT = 3f;

	private const int PING_COUNT = 5;

	public const int LOBBY_PING_COUNT = 5;

	public const float LOBBY_PING_TIMEOUT = 3f;

	private const string ERROR_CODE_START = "ErrorCode:";

	private const int UDP_PING_MAXVALUE = 1000;

	private static NetworkDetection m_Instance;

	private float m_StartTime;

	private LinkedList<TaskInfo> m_PendingTaskList;

	private TaskInfo m_RunningTask;

	private NetworkDetectionClient m_UdpClient;

	public static NetworkDetection Instance => null;

	private void Init()
	{
	}

	private void OnDestroy()
	{
	}

	public void Clear(uint include_task = uint.MaxValue)
	{
	}

	public void UDPPing(ETaskType type, string[] address_list, MultiTaskComplete call_back, object extra_data = null)
	{
	}

	private IEnumerator MultiUDPPing(TaskInfo task_info)
	{
		return null;
	}

	public void Ping(ETaskType type, string[] address_list, MultiTaskComplete call_back, object extra_data = null, string idc_name = null)
	{
	}

	public void LobbyPing(ETaskType type, string[] address_list, MultiTaskComplete call_back, object extra_data = null, string[] idc_name = null, ETaskFunction eTaskFunction = ETaskFunction.eLobbyPing)
	{
	}

	private IEnumerator MultiPing(string address, List<PingInfo> infos, TaskInfo task_info)
	{
		return null;
	}

	private IEnumerator LobbyMultiplePingTask(List<PingInfo> infos, TaskInfo task_info)
	{
		return null;
	}

	private IEnumerator LobbyPingTask(string address, string idcName, List<PingInfo> infos, TaskInfo task_info, bool needAverageResult = true)
	{
		return null;
	}

	private IEnumerator LobbyPingInternal(string address, string idcName, List<PingInfo> infos, TaskInfo task_info, bool oneTargetIp = true)
	{
		return null;
	}

	private void TryOnPingCompleted(List<PingInfo> infos, TaskInfo task_info, bool oneTargetIp = true)
	{
	}

	private void OnPingCompleted(string address, List<PingInfo> infos, TaskInfo task_info)
	{
	}

	public void TraceRoute(ETaskType type, string[] address_list, uint thread_count, MultiTaskComplete call_back, object extra_data = null, bool need_add_first = false)
	{
	}

	private void TraceRoute(string address, int thread_count)
	{
	}

	private void OnTraceRouteTaskComplete(TracerouteResult result)
	{
	}

	public void OnTraceRouteCompleted(string data)
	{
	}

	public void CDNDownload(string url, MultiTaskComplete call_back)
	{
	}

	private IEnumerator TestCDN(string url)
	{
		return null;
	}

	private void OnTaskComplete(TaskInfo task_info)
	{
	}

	private void Update()
	{
	}
}
