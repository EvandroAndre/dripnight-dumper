using System;
using System.Collections.Generic;

namespace GCommon;

public class IntervalTreeBuilder
{
	[Serializable]
	private sealed class _003C_003Ec__4<T> where T : class, IGetId
	{
		public static readonly _003C_003Ec__4<T> _003C_003E9;

		public static Comparison<IntervalNode> _003C_003E9__4_0;

		internal int _003CCreateItemIdDic_003Eb__4_0(IntervalNode a, IntervalNode b)
		{
			return 0;
		}
	}

	public static bool EnableMultNodes;

	public static int MultNodeMaxChildCnt;

	public static int CompareById<T>(T a, T b) where T : class, IGetId
	{
		return 0;
	}

	public static List<T> OverwriteAndSort<T>(List<T> dst, List<T> overwrites, bool sorted) where T : class, IGetId
	{
		return null;
	}

	public static IntervalTreeDic<T> CreateItemIdDic<T>(List<T> dataList, bool sorted, bool needSort = true) where T : class, IGetId
	{
		return null;
	}

	public static List<IntervalNode> CreateRanges<T>(List<T> list, uint maxRangeRadix) where T : IGetId
	{
		return null;
	}

	public static IntervalTree BuildTree(List<IntervalNode> ranges, uint radixScale, uint maxRangeRadix, uint minRadix, uint maxRadix)
	{
		return null;
	}

	private static void BuildSubTree(ref IntervalNode node, List<uint> radixes, int maxRadixIdx, int maxRangeRadixIdx, List<IntervalNode> nodes, List<IntervalNode> leafRanges, List<int> leafSizes, int begin, int end)
	{
	}
}
