using System;
using System.IO;
using System.Security.Cryptography;
using UnityEngine.Networking;

namespace GCommon;

public class ResDownloadFileLoader : ResWithTempFileLoader
{
	public UnityWebRequest HttpReq;

	public ResDownloadType DownloadType;

	public Action<UnityWebRequest, ResWithTempFileLoader> OnLoaded;

	private long m_DataIndex;

	protected FileStream m_TempFileStream;

	protected readonly object m_TempFileLock;

	protected long m_TempFileLength;

	protected SHA1CryptoServiceProvider m_HashWorker;

	protected byte[] m_HashBuffer;

	protected bool m_NeedHashTemp;

	protected const int GETDATA_TIKECOUNT = 5;

	private int m_curTick;

	public override long CELL_SIZE => 0L;

	protected override void OnStart(float time)
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

	protected override void OnNotify()
	{
	}

	protected override void OnUpdate(float time)
	{
	}

	private void GetFileByReq()
	{
	}

	protected virtual void ClearFileStream()
	{
	}

	protected void ClearHashWorker()
	{
	}

	protected virtual void CollectDataAndClearFileStream()
	{
	}

	public override void OnPause()
	{
	}

	public override long NeedDownloadSize()
	{
		return 0L;
	}
}
