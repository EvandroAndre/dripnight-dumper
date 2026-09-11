using System;
using System.Collections.Generic;

namespace proto;

public class CollectionBookDesc : IComparable
{
	public uint book_id;

	public EStore.HyperBookType type;

	public long time_pre_start;

	public long time_pre_end;

	public long time_open_start;

	public long time_open_end;

	public uint go_pos;

	public string sub_go_pos;

	public uint sort_id;

	public uint obtain_go_pos;

	public string obtain_sub_go_pos;

	public uint preview_config_index;

	public bool is_use_general_token;

	public bool is_hide;

	private int m_HiddenPageIdx;

	private int m_BigRewardIdx;

	private List<CollectionBookItemDesc> m_CollectionBookItemDescList;

	public int HiddenPageIdx => 0;

	public int BigRewardIdx => 0;

	public List<CollectionBookItemDesc> CollectionBookItemDescList => null;

	private void OnConstructor()
	{
	}

	public void AddCollectionBookItemDesc(CollectionBookItemDesc itemDesc)
	{
	}

	public void AddCollectionBookBigRewardItemDesc(CollectionBookItemDesc itemDesc)
	{
	}

	public CollectionBookItemDesc GetCollectionBookItemDesc(int index)
	{
		return null;
	}

	public void SortCollectionBookItemDesc()
	{
	}

	public int GetBookPageCount()
	{
		return 0;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public List<AwardDesc> GetHyperBookAwardList()
	{
		return null;
	}
}
