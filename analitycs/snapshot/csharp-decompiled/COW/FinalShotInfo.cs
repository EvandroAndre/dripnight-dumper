using System;
using proto;

namespace COW;

public class FinalShotInfo : CollectionBaseInfo, IComparable<FinalShotInfo>
{
	public FinalShotData finalshot_data;

	public FinalShotInfo()
	{
	}

	public FinalShotInfo(uint itemid)
	{
	}

	public static implicit operator FinalShotInfo(Item it)
	{
		return null;
	}

	public static implicit operator FinalShotInfo(FinalShotData data)
	{
		return null;
	}

	public int CompareTo(FinalShotInfo other)
	{
		return 0;
	}
}
