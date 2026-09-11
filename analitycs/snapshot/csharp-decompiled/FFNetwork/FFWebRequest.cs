using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;

namespace FFNetwork;

public class FFWebRequest : IDisposable
{
	private class FFWebRequestManager
	{
		private static FFWebRequestManager _Instance;

		private Queue<FFWebRequest> _request_queue;

		private FFWebRequest[] _tmp_requests;

		private Thread _web_reqeust_thread;

		public static FFWebRequestManager Instance => null;

		public void Init()
		{
		}

		public void UnInit()
		{
		}

		public void PushRequest(FFWebRequest request)
		{
		}

		private void ManagerLoop()
		{
		}
	}

	private struct RequestTransInfo
	{
		public int _response_size;

		public int _last_error_code;
	}

	public delegate void DownloadCallBack(byte[] tmp_buffer, int data_offset, int data_size, int error_code, object extra_data_obj);

	private const string Version = "1.0";

	private static byte[] _REQUEST_TMP_BUFFER;

	private static bool _Inited;

	public static int BuffSize;

	private static bool _EnableBackGroundOptimize;

	private string _url;

	private List<string> _http_headers;

	private DownloadCallBack _request_call_back;

	private unsafe RequestTransInfo* _trans_info;

	private object _extra_data_obj;

	private bool _is_valid;

	private static FFWebRequest _curRunningRequest;

	public static void Init(int tmp_buffer_size = 1048576, bool enableBackGroundOptimize = false)
	{
	}

	public static void UnInit()
	{
	}

	public static FFWebRequest Create()
	{
		return null;
	}

	public static FFWebRequest Create(string url)
	{
		return null;
	}

	public static void ClearTempBuff()
	{
	}

	public void Dispose()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	~FFWebRequest()
	{
	}

	private void CheckHttpHearder()
	{
	}

	public void AddRange(long start_point, long end_point = 0L)
	{
	}

	public void AddHeader(string key, string value)
	{
	}

	private static void PushDataToBuffer(IntPtr data, IntPtr request_ptr, int data_size, int error_code)
	{
	}

	private static void InitRequestTmpBuffer(int size)
	{
	}

	private unsafe static void UpdateErrorCode(RequestTransInfo* trans_info, int error_code)
	{
	}

	public void UpdateErrorCode(int error_code)
	{
	}

	public static HttpStatusCode ConvertCurlErrorCodeToHttpStatusCode(int error_code)
	{
		return (HttpStatusCode)0;
	}

	public void OnRequestEnd()
	{
	}

	public void BeginRequest(string url, DownloadCallBack call_back, object extra_data_obj = null)
	{
	}

	public void BeginRequest(DownloadCallBack call_back, object extra_data_obj = null)
	{
	}

	private int DoRequest()
	{
		return 0;
	}
}
