using System;

namespace COW.Gameplay.UGC;

public class UGCVFSMemory : UGCVFSBase
{
	private byte[] _data;

	public UGCVFSMemory(byte[] data)
	{
	}

	public bool Load()
	{
		return false;
	}

	protected override string GetDataIdentifier()
	{
		return null;
	}

	protected override void ReadHeader()
	{
	}

	protected override UGCVFSIndexChunk ReadIndexChunk(long position)
	{
		return null;
	}

	protected override bool WriteDataToFile(long position, byte[] data, int offsetData = 0, int lengthData = -1)
	{
		return false;
	}

	protected override long GetEndOfFilePosition()
	{
		return 0L;
	}

	protected override bool WriteVFSHeader()
	{
		return false;
	}

	protected override void ReadResourceDataAsync(UGCVFSFileBaseInfo resourceInfo, Action<byte[], Exception> callback)
	{
	}

	protected override byte[] ReadResourceData(UGCVFSFileBaseInfo resourceInfo)
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}

	public void _003C_003EiFixBaseProxy_Dispose(bool P0)
	{
	}
}
