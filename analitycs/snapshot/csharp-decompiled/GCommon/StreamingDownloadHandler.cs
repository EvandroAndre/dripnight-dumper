using System.Collections.Generic;
using UnityEngine.Networking;

namespace GCommon;

public class StreamingDownloadHandler : DownloadHandlerScript
{
	private const int MEM_POOL_MAX_SIZE = 1;

	private static Queue<byte[]> m_BufferPool;

	private byte[] m_DataBuffer;

	private int m_UnreadDataLength;

	private bool m_HasUnReadData;

	public int DownloadedSize => 0;

	public byte[] AllDownloadData => null;

	public static void ClearPool()
	{
	}

	public void ClearDownloadedData()
	{
	}

	protected override byte[] GetData()
	{
		return null;
	}

	public byte[] GetUnreadData(out int size)
	{
		size = default(int);
		return null;
	}

	protected override bool ReceiveData(byte[] incomingDataSegment, int incomingDataLength)
	{
		return false;
	}

	private void EnsureCapacity(int size)
	{
	}
}
