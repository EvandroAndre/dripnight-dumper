using System;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.GZip;

namespace GCommon;

public class ResUnzipFileLoader : ResFileLoader, ICopyToBackground
{
	public string OutputPath;

	public Action<string, ResUnzipFileLoader> OnLoaded;

	public int BufferSize;

	private GZipInputStream m_GZipStream;

	private FileStream m_OutputStream;

	private bool m_ReadOptimize;

	private long m_SizeUnzipped;

	private byte[] m_Buffer;

	private bool m_IsFinished;

	private SHA1CryptoServiceProvider m_HashWorker;

	public ResUnzipFileLoader(bool OptimizeRead)
	{
	}

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

	protected override void OnUpdate(float time)
	{
	}

	protected override void OnUpdateInThread(float time)
	{
	}

	protected override void OnNotify()
	{
	}

	protected override void OnDispose()
	{
	}

	public override bool IsTimeout(float time)
	{
		return false;
	}

	public void CloseInput()
	{
	}

	private void CloseOutput()
	{
	}

	private void ClearHashWorker()
	{
	}

	public ResFileLoader CopyToBackGroundLoader()
	{
		return null;
	}
}
