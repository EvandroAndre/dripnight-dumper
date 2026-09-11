using System;
using System.IO;
using System.Security.Cryptography;

namespace GCommon;

public class ResHashFileLoader : ResFileLoader
{
	public Action<string, ResHashFileLoader> OnLoaded;

	private FileStream m_FileStream;

	private long m_SizeHashed;

	private byte[] m_Buffer;

	private bool m_IsFinished;

	private SHA1CryptoServiceProvider m_HashWorker;

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

	private void ClearHashWorker()
	{
	}
}
