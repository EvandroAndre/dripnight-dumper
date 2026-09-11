using GCommon;
using proto;

namespace COW;

public class IngameQuickChatItemData : CSVBaseData
{
	public uint GroupId;

	public string GroupName;

	public uint ItemID;

	public uint SortId;

	public ulong ShowTime;

	public ulong StopShowTime;

	public ulong StartTime;

	public ulong EndTime;

	public string GoPosIcon;

	public uint GoPos;

	public string SubGoPos;

	public uint GroupSortId;

	public ResourceID GroupResID;

	public EQuickChatPriority ItemPriority;

	public int ItemQualityPriority;

	public static implicit operator IngameQuickChatItemData(InGameQuickChatItemDesc desc)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
