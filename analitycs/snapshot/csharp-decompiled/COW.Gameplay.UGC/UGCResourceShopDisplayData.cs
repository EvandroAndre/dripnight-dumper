using System;
using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class UGCResourceShopDisplayData
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCResourceShopItem> _003C_003E9__6_0;

		public static Comparison<UGCResourceShopItem> _003C_003E9__6_1;

		public static Comparison<UGCResourceShopItem> _003C_003E9__6_2;

		public static Comparison<UGCResourceShopPageData> _003C_003E9__9_0;

		internal int _003CGetAllItems_003Eb__6_0(UGCResourceShopItem a, UGCResourceShopItem b)
		{
			return 0;
		}

		internal int _003CGetAllItems_003Eb__6_1(UGCResourceShopItem a, UGCResourceShopItem b)
		{
			return 0;
		}

		internal int _003CGetAllItems_003Eb__6_2(UGCResourceShopItem a, UGCResourceShopItem b)
		{
			return 0;
		}

		internal int _003CSortPages_003Eb__9_0(UGCResourceShopPageData a, UGCResourceShopPageData b)
		{
			return 0;
		}
	}

	public int PageMaxItemCount;

	public bool IsEnd;

	public List<UGCResourceShopPageData> Pages;

	private HashSet<ulong> m_ResourceIds;

	public bool IsAISearch;

	public void Clear()
	{
	}

	public void GetAllItems(ref List<UGCResourceShopItem> totalDataList, int sortId)
	{
	}

	public bool ContainsPage(int index)
	{
		return false;
	}

	public UGCResourceShopPageData AddPage(int index, List<ulong> resourceIds, List<ulong> aiIds)
	{
		return null;
	}

	public void SortPages()
	{
	}

	public int GetLastPageIndex()
	{
		return 0;
	}
}
