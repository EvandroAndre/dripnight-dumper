using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCVFSIndexChunk
{
	public UGCVFSChunkHeader Header;

	public uint FileBaseInfoCount;

	public List<UGCVFSFileBaseInfo> FileBaseInfos;

	public uint DataChunkAvailableSpace;

	public List<UGCVFSFileBaseInfo> DirtyForAppendFileList;

	public uint NeedSpace => 0u;

	public long CalcLastFileDataEndPosition()
	{
		return 0L;
	}

	public long CalcAppendFileListNeedSpace()
	{
		return 0L;
	}

	public void ReplaceOrAddFileInfo(UGCVFSFileBaseInfo info)
	{
	}

	public void SerializeWithoutHeader(UGCVFSBinarySerializer serializer)
	{
	}
}
