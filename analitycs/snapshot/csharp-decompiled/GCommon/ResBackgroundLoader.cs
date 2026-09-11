using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using FFNetwork;

namespace GCommon;

public class ResBackgroundLoader : ResMultiDownloadLoader
{
	private enum WebReqState
	{
		Running,
		Finished,
		Error,
		Cancled
	}

	private class RequestState
	{
		public FFWebRequest CurReq;

		public uint DataIndex;

		public WebReqState State;

		public HttpStatusCode StateCode;

		public string StateDescription;
	}

	private List<RequestState> m_RunningReq;

	private List<RequestState> m_FinishedReq;

	public ResBackgroundLoader(int mex_req_count, bool should_reuse_mem = false, bool should_override_with_full = false, int gc_index = 0, bool reuse_map = true)
		: base(0, should_reuse_mem: false, should_override_with_full: false, 0, reuse_map: false)
	{
	}

	public bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return false;
	}

	protected override void OnStart(float time)
	{
	}

	protected override void GetFileWithIndex(float time, uint cell_index)
	{
	}

	protected override void ClearFileStream()
	{
	}

	protected override void OnDispose()
	{
	}

	public override bool IsFinished()
	{
		return false;
	}

	protected override void OnNotify()
	{
	}

	protected override void OnUpdate(float time)
	{
	}

	private void OnResponseAsync(byte[] tmp_buffer, int data_offset, int data_size, int error_code, object extra_data_obj)
	{
	}

	protected override void OnRequestComplete(byte[] buffer, uint index, int download_size)
	{
	}

	protected override void OnUpdateInThread(float time)
	{
	}

	public override bool IsSupportBackground()
	{
		return false;
	}
}
