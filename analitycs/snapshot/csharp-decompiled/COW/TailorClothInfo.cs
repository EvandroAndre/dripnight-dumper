using System.Collections.Generic;

namespace COW;

public class TailorClothInfo
{
	private List<TailorItemInfo> _003CTailorItemInfoList_003Ek__BackingField;

	public List<TailorItemInfo> TailorItemInfoList
	{
		get
		{
			return _003CTailorItemInfoList_003Ek__BackingField;
		}
		private set
		{
			_003CTailorItemInfoList_003Ek__BackingField = value;
		}
	}

	public bool AllClothesIsPlaceHolder()
	{
		return false;
	}

	public bool HasClothData()
	{
		return false;
	}
}
