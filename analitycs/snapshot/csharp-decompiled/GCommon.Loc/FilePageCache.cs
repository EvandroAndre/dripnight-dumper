using System.IO;

namespace GCommon.Loc;

internal class FilePageCache : FilePageCacheBase
{
	private byte[] m_Mapping;

	private int m_PairsCnt;

	private PagePair[] m_Pairs;

	private uint m_Access;

	public int MinReadSize;

	public int MinAllocSize;

	public FilePageCache(FileStream fs, int begin, int pageSize, int cachePageCnt, bool preAlloc)
		: base(null, 0, 0)
	{
	}

	public PagePair Require(uint offset, int len)
	{
		return null;
	}
}
