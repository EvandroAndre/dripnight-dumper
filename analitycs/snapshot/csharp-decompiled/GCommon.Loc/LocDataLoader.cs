using System.IO;
using Unity.Collections;

namespace GCommon.Loc;

public class LocDataLoader
{
	public static LocDataTransLazyLoader LoadLoc(LocData data, byte[] idBytes, FileStream transStream, bool needOverWrite = true)
	{
		return null;
	}

	public static LocDataTransLazyLoader LoadLocWithNativeArray(LocData data, NativeArray<byte> idData, FileStream transStream, bool needOverWrite = true)
	{
		return null;
	}
}
