using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public static class UgcPublic
{
	public enum EMergeMode
	{
		Merge,
		Overwrite
	}

	public static string GetLevelObjectNameFromID(string prefix, uint id)
	{
		return null;
	}

	public static TimeAbsMS TimeSecToMilliSec(int sec)
	{
		return default(TimeAbsMS);
	}

	public static int UGCGetFunctionCallerDataName(DOMDODOIOBI funcCallerData)
	{
		return 0;
	}

	public static bool GetCodeBlockParamIsOut(int paramIndex, DOMDODOIOBI funcCallerData)
	{
		return false;
	}

	public static long GetCodeBlockParamTypeID(int paramIndex, DOMDODOIOBI funcCallerData)
	{
		return 0L;
	}

	public static Tuple2<FJOPMIJBFEI, bool> UGCGetCustomReplicationDataByEntityType(long componentTypeID, List<FJOPMIJBFEI> entityReplicationData)
	{
		return default(Tuple2<FJOPMIJBFEI, bool>);
	}

	public static bool CheckContainTypeID(long targetTypeID, List<long> archTypeIDs)
	{
		return false;
	}

	public static bool CheckContainArchType(List<long> targetTypeIDs, List<long> archTypeIDs)
	{
		return false;
	}

	public static bool ValueEqual(object left, object right)
	{
		return false;
	}

	public static int GetColorR(int color)
	{
		return 0;
	}

	public static int GetColorG(int color)
	{
		return 0;
	}

	public static int GetColorB(int color)
	{
		return 0;
	}

	public static int GetColorA(int color)
	{
		return 0;
	}

	public static void SetColorR(ref int color, int value)
	{
	}

	public static void SetColorG(ref int color, int value)
	{
	}

	public static void SetColorB(ref int color, int value)
	{
	}

	public static void SetColorA(ref int color, int value)
	{
	}
}
