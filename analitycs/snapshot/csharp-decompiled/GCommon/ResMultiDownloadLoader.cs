using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEngine.Networking;

namespace GCommon;

public class ResMultiDownloadLoader : ResWithTempFileLoader, ICopyToBackground
{
	public ResDownloadType DownloadType;

	public Action<UnityWebRequest, ResWithTempFileLoader> OnLoaded;

	public bool NeedInitFileLength;

	public static readonly string ERR_CELL_DOWNLOAD_FAILED;

	protected FileStream m_TempFileStream;

	protected readonly object m_TempFileLock;

	protected long m_TempFileLength;

	protected long m_DownloadingSize;

	protected long m_LastDownloadedSize;

	protected SHA1CryptoServiceProvider m_HashWorker;

	protected byte[] m_HashBuffer;

	protected bool m_NeedHashTemp;

	protected FileStream m_FlagStream;

	protected BitArrayRich m_TempFlag;

	protected BitArrayRich m_RunningFlag;

	protected int m_MaxReqCount;

	protected uint m_CellCount;

	protected int m_CellDownloadRetryCount;

	private List<UnityWebRequest> m_RunningReq;

	private List<UnityWebRequest> m_FinishedReq;

	protected uint m_NextDownloadIndex;

	protected bool m_Started;

	protected const float REQ_TIMEOUT_SECOUNDS = 60f;

	protected const float TIMEOUT_SECOUNDS = 90f;

	protected float m_GCIndex;

	public static int Loader_Count;

	protected bool m_ShouldReuseMemory;

	protected bool m_ShouldOverrideWithFull;

	protected bool m_ShouldReuseMap;

	public override long CELL_SIZE => 0L;

	public ResMultiDownloadLoader(int mex_req_count, bool should_reuse_mem = false, bool should_override_with_full = false, int gc_index = 0, bool reuse_map = true)
	{
	}

	protected override void OnStart(float time)
	{
	}

	protected virtual void GetFileWithIndex(float time, uint cell_index)
	{
	}

	protected void PrepareHashAndTempIndex()
	{
	}

	public override bool HasStarted()
	{
		return false;
	}

	public override bool IsFinished()
	{
		return false;
	}

	public override long GetDownloadingSize()
	{
		return 0L;
	}

	protected override void OnDispose()
	{
	}

	protected override void OnUpdate(float time)
	{
	}

	protected void SaveFlagFile()
	{
	}

	protected virtual void OnRequestComplete(byte[] buffer, uint index, int download_size)
	{
	}

	protected void CollectDataAndClearFileStream()
	{
	}

	protected virtual void ClearFileStream()
	{
	}

	protected void ClearHashWorker()
	{
	}

	protected void ClearFlagFile()
	{
	}

	protected override void OnNotify()
	{
	}

	public override long NeedDownloadSize()
	{
		return 0L;
	}

	public override void OnPause()
	{
	}

	public ResFileLoader CopyToBackGroundLoader()
	{
		return null;
	}
}
