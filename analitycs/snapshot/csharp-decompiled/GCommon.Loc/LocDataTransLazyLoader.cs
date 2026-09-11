using System.IO;
using System.Text;

namespace GCommon.Loc;

public class LocDataTransLazyLoader
{
	private LoadTransMethod m_Method;

	private const uint TransOffsetMask = 16777215u;

	private const uint MaxTransOffset = 16777215u;

	private uint[] m_TransSizeOffsets;

	private FileStream m_TransStream;

	private static readonly Encoding s_TransEncoding;

	private int m_TransOffsetInFile;

	private byte[] m_TransBuf;

	private unsafe char* p_TransChars;

	private bool m_UsePageCache;

	private FilePageCache m_PageCache;

	private bool m_UseStrPool;

	private AppendOnlyStrPool m_StrPool;

	private int m_Str255RequireLen;

	public static int d_FilledTransCnt;

	public void Unload()
	{
	}

	public void Init(LoadTransMethod m, FileStream s, LoadTransResult r, bool usePageCache, bool useStrPool)
	{
	}

	private void InitTransBuf(int maxTransBytes, int transFileLen, int transOffset)
	{
	}

	public string LoadTransOnDemand(int idx)
	{
		return null;
	}

	public string GetStats()
	{
		return null;
	}
}
