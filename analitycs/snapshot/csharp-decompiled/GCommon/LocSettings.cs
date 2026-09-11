namespace GCommon;

public static class LocSettings
{
	public const LoadTransMethod LoadMethod = LoadTransMethod.Bytes;

	public static bool UseStrPool;

	public static bool UsePageCache;

	public static int CachePageCnt;

	public const int PageSize = 4096;

	public const int StrSizeOffset32Bit = 8;

	public const int StrSizeOffset64Bit = 16;

	public const int StrAppendLen32Bit = 14;

	public const int StrAppendLen64Bit = 22;

	public const int StrAlignment32Bit = 4;

	public const int StrAlignment64Bit = 8;
}
