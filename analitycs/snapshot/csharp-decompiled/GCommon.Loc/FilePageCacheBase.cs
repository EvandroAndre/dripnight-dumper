using System.Collections.Generic;
using System.IO;

namespace GCommon.Loc;

internal class FilePageCacheBase
{
	public class PagePair
	{
		public int Length;

		public byte[] Bytes;

		public unsafe byte* Ptr;

		public uint Begin;

		public uint End;

		public uint Access;
	}

	protected int m_PageSize;

	protected const int BytesHeadPad = 32;

	public bool AllocByNative;

	public int AllocPagesPerTime;

	protected FileStream m_Fs;

	protected uint m_OffsetBegin;

	protected long m_ReadPos;

	protected List<byte[]> m_AllocedBytes;

	public FilePageCacheBase(FileStream fs, int begin = 0, int pageSize = 4096)
	{
	}

	protected void AllocBuffer(PagePair pair, int size)
	{
	}

	protected void FreeBuffer(PagePair pair)
	{
	}
}
