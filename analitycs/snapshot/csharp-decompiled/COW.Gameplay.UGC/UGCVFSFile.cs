using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCVFSFile : UGCVFSBase
{
	public enum ESaveAsStatus
	{
		saving,
		success,
		fail
	}

	private class PairCpyFileBaseInfo
	{
		public UGCVFSFileBaseInfo src;

		public UGCVFSFileBaseInfo dst;
	}

	private sealed class HCDAOOCFBOH
	{
		public UGCVFSFile KOKNHFGCGLN;

		public UGCVFSFileBaseInfo EBPHHIEHAJK;

		internal void IFCPLIKNOHJ(byte[] OHKBJBBFBIB, int DFNHOKCIIJK, int AJHBMPPJNIJ, Exception HDMEPAPIGJG)
		{
		}
	}

	private sealed class NJLIMGHGDGN
	{
		public Action<byte[], Exception> CEHELPAIELA;

		public UGCVFSFileBaseInfo AFOJPFPBNNH;

		public UGCVFSFile KOKNHFGCGLN;

		internal void GHHKCKGGEFE(byte[] OHKBJBBFBIB, int DFNHOKCIIJK, int AJHBMPPJNIJ, Exception HDMEPAPIGJG)
		{
		}
	}

	private string _filePath;

	private UGCVFSIOManager _ioManager;

	private UGCVFSFile m_tempSrcVFS;

	private Action<int, int, int> m_tempSaveAsCallback;

	private int m_nTempSaveAsIndex;

	private List<PairCpyFileBaseInfo> m_tempNeedAsyncReadAndSaveAsList;

	public string FilePath => null;

	public DateTime GetCreationTimeUtc()
	{
		return default(DateTime);
	}

	public DateTime GetLastModifiedTimeUtc()
	{
		return default(DateTime);
	}

	public UGCVFSFile(string filePath, UGCVFSIOManager ioManager = null)
	{
	}

	public bool Load()
	{
		return false;
	}

	public void Compact(Action<int, int, int> callback)
	{
	}

	private void writeChunkWithAppend(UGCVFSIndexChunk indexChunk, List<UGCVFSFileBaseInfo> appendFileList)
	{
	}

	private long calculateAppendPosition()
	{
		return 0L;
	}

	private bool saveDirty()
	{
		return false;
	}

	public void Save()
	{
	}

	public void SaveAs(string filePath, Action<int, int, int> callback)
	{
	}

	private void onSaveAsFinished(bool success)
	{
	}

	private void _NextAsyncReadAndSaveAs()
	{
	}

	public void InitializeNewVFSFile()
	{
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

	protected override long GetEndOfFilePosition()
	{
		return 0L;
	}

	protected override bool WriteDataToFile(long position, byte[] data, int offsetData = 0, int lengthData = -1)
	{
		return false;
	}

	private bool IsSingleResourceVFS()
	{
		return false;
	}

	private bool RewriteSingleResource(UGCVFSFileBaseInfo resourceInfo)
	{
		return false;
	}

	private uint WriteIndexChunk(long position, UGCVFSIndexChunk chunk)
	{
		return 0u;
	}

	private uint WriteChunkHeader(long position, UGCVFSChunkHeader header)
	{
		return 0u;
	}

	private UGCVFSIndexChunk GetLastIndexChunk()
	{
		return null;
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

	private UGCVFSIndexChunk FindResourceIndexChunk(string resourceUUID, out UGCVFSFileBaseInfo originFileBaseInfo)
	{
		originFileBaseInfo = null;
		return null;
	}

	private bool HasEnoughSpace(UGCVFSIndexChunk chunk, UGCVFSFileBaseInfo newFileInfo, UGCVFSFileBaseInfo originFileBaseInfo)
	{
		return false;
	}

	public new void Dispose()
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public void _003C_003EiFixBaseProxy_Dispose(bool P0)
	{
	}
}
