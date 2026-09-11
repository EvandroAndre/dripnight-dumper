using System.Collections.Generic;

namespace COW;

public class InventoryClothSeriesInfo
{
	private List<InventoryClothInfo> _003CCloths_003Ek__BackingField;

	private uint _003CSeriesId_003Ek__BackingField;

	private int _003CIndex_003Ek__BackingField;

	private ESeriesClothType _003CSeriesType_003Ek__BackingField;

	public List<InventoryClothInfo> Cloths
	{
		get
		{
			return _003CCloths_003Ek__BackingField;
		}
		private set
		{
			_003CCloths_003Ek__BackingField = value;
		}
	}

	public uint SeriesId
	{
		get
		{
			return _003CSeriesId_003Ek__BackingField;
		}
		private set
		{
			_003CSeriesId_003Ek__BackingField = value;
		}
	}

	public int Index
	{
		get
		{
			return _003CIndex_003Ek__BackingField;
		}
		private set
		{
			_003CIndex_003Ek__BackingField = value;
		}
	}

	public ESeriesClothType SeriesType
	{
		get
		{
			return _003CSeriesType_003Ek__BackingField;
		}
		private set
		{
			_003CSeriesType_003Ek__BackingField = value;
		}
	}

	public InventoryClothSeriesInfo(uint seriesId, ESeriesClothType seriesType)
	{
	}

	public void SetIndex(int index)
	{
	}

	public InventoryClothInfo GetCurrentClothInfo()
	{
		return null;
	}

	public void PrepareClothInfo(int count)
	{
	}

	public void AddSeriesCloth(InventoryClothInfo cloth, int index)
	{
	}

	public void PickCurrentIndex()
	{
	}

	public static List<uint> GetLockIndex(InventoryClothSeriesInfo info)
	{
		return null;
	}
}
