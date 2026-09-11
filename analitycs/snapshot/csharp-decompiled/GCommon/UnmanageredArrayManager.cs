using System.Collections.Generic;

namespace GCommon;

public class UnmanageredArrayManager
{
	public static Dictionary<byte[], UnmanageredArray<byte>> m_ArrayDic;

	private static object m_Lock;

	public static byte[] AllocArrayByte(int count)
	{
		return null;
	}

	public static void FreeArrayByte(byte[] array)
	{
	}
}
