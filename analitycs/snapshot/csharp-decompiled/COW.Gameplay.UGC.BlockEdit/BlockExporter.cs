using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

public static class BlockExporter
{
	private static readonly Dictionary<long, long> m_ArithmeticSignPriority;

	private static readonly Dictionary<long, long> m_LogicalOperatorPriority;

	private static Dictionary<int, Dictionary<string, long>> m_UserCustomEventIdDic;

	private static long m_UserCustomEventIdCurIndex;

	public static bool TakeOverExportArithmetic(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool TakeOverExportLogicalOperation(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	private static bool ExportExpressionWithOperator(BlockData source, DOMDODOIOBI result, int startIndex, int endIndex, Dictionary<long, long> priorityMap)
	{
		return false;
	}

	private static bool ExportCalculationFuncCallerData(DOMDODOIOBI source, UGCVarValueDataV2 left, UGCVarValueDataV2 op, UGCVarValueDataV2 right)
	{
		return false;
	}

	public static bool TakeOverExportStrConcat(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool TakeOverExportGetEntityProperty(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool TakeOverExportDefFuncWithoutReturn(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool TakeOverExportDefFuncWithReturn(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool OverrideExportCallFunc(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool TakeOverExportGetSelfOrGlobalGraphProperty(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool TakeOverExportSetSelfOrGlobalGraphProperty(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool ExportIfElse(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static long GetUserCustomEventId(EUGCUserCustomEventSource eventSource, string eventUid)
	{
		return 0L;
	}

	public static void RegisterUserCustomEventId(EUGCUserCustomEventSource eventSource, string eventUid, long id)
	{
	}

	public static bool OverrideExportUserCustomEvent(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}

	public static bool OverrideExportDispatchUserCustomEvent(BlockData source, DOMDODOIOBI result)
	{
		return false;
	}
}
