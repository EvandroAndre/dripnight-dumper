using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon.CommandPattern;
using message;

namespace COW;

public static class BEUtil
{
	public static bool DEBUGMODE;

	public static readonly OLHOBAPCNMI TypeMapping;

	private static Dictionary<string, List<BEEnumData>> BEEnumDic;

	public static MacroCommand SetDataBlockToSlotCommand;

	public static bool EnableUpdateValueForTypeChanged;

	public static bool EnableDebugOverrideOptimizedStrategy;

	public static EBlockEditDebugOptimizingStrategy DebugOverrideOptimizedStrategy;

	public static EBlockEditDebugOptimizingStrategy BlockOptimizingStrategy => EBlockEditDebugOptimizingStrategy.BuildOptimized;

	public static void ExecuteChangeConstValueCommand(Command command)
	{
	}

	public static BEEnumData GetEnum(List<BEEnumData> enumList, ValueData valueData)
	{
		return null;
	}

	public static List<BEEnumData> GetBasicEnumList(string enumType)
	{
		return null;
	}

	private static void InitBEEnumDic()
	{
	}

	public static string InputValToDecimal(string val)
	{
		return null;
	}

	public static float LogTimeByOptimizingStrategy(EBlockEditDebugOptimizingStrategy strategy, string processName, ref float startTime)
	{
		return 0f;
	}

	private static int CalculateSameTextCount(string input, string target)
	{
		return 0;
	}

	public static float CalculateFinalScore(string input, string target, float utilizationFactor, float utilizationFactorWeight)
	{
		return 0f;
	}
}
