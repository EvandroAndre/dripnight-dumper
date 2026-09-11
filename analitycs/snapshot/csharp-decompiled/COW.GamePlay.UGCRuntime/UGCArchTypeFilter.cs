using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCArchTypeFilter : IUGCObjectPoolItem
{
	private List<long> _003CHas_003Ek__BackingField;

	private List<long> _003CNot_003Ek__BackingField;

	private List<long> _003CAny_003Ek__BackingField;

	public List<long> Has
	{
		get
		{
			return _003CHas_003Ek__BackingField;
		}
		set
		{
			_003CHas_003Ek__BackingField = value;
		}
	}

	public List<long> Not
	{
		get
		{
			return _003CNot_003Ek__BackingField;
		}
		set
		{
			_003CNot_003Ek__BackingField = value;
		}
	}

	public List<long> Any
	{
		get
		{
			return _003CAny_003Ek__BackingField;
		}
		set
		{
			_003CAny_003Ek__BackingField = value;
		}
	}

	public void Reset()
	{
	}

	public UGCArchTypeFilter HasComponents(int[] typeIDs)
	{
		return null;
	}

	public UGCArchTypeFilter NotComponents(int[] typeIDs)
	{
		return null;
	}

	public UGCArchTypeFilter AnyComponents(int[] typeIDs)
	{
		return null;
	}
}
