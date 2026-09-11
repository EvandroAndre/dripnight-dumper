using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCEntityRepData : IUGCObjectPoolItem
{
	private string _003CEntityID_003Ek__BackingField;

	private Dictionary<long, UGCEntityRepDataItem> _003CRepItem_003Ek__BackingField;

	private string _003CArchTypeID_003Ek__BackingField;

	private int _003CSyncSubLevelID_003Ek__BackingField;

	private uint _003CAttribute_003Ek__BackingField;

	private bool _003CIsRemote_003Ek__BackingField;

	private bool _003CIsEnableClientModify_003Ek__BackingField;

	public string EntityID
	{
		get
		{
			return _003CEntityID_003Ek__BackingField;
		}
		set
		{
			_003CEntityID_003Ek__BackingField = value;
		}
	}

	public Dictionary<long, UGCEntityRepDataItem> RepItem
	{
		get
		{
			return _003CRepItem_003Ek__BackingField;
		}
		set
		{
			_003CRepItem_003Ek__BackingField = value;
		}
	}

	public string ArchTypeID
	{
		get
		{
			return _003CArchTypeID_003Ek__BackingField;
		}
		set
		{
			_003CArchTypeID_003Ek__BackingField = value;
		}
	}

	public int SyncSubLevelID
	{
		get
		{
			return _003CSyncSubLevelID_003Ek__BackingField;
		}
		set
		{
			_003CSyncSubLevelID_003Ek__BackingField = value;
		}
	}

	public uint Attribute
	{
		get
		{
			return _003CAttribute_003Ek__BackingField;
		}
		set
		{
			_003CAttribute_003Ek__BackingField = value;
		}
	}

	public bool IsRemote
	{
		get
		{
			return _003CIsRemote_003Ek__BackingField;
		}
		set
		{
			_003CIsRemote_003Ek__BackingField = value;
		}
	}

	public bool IsEnableClientModify
	{
		get
		{
			return _003CIsEnableClientModify_003Ek__BackingField;
		}
		set
		{
			_003CIsEnableClientModify_003Ek__BackingField = value;
		}
	}

	public UGCEntityRepData Create(UGCRuntime runtime, string entityID, string archTypeID, int syncSubLevelID, List<UGCComponentProp> entityDefData, bool isRemote)
	{
		return null;
	}

	public bool HasAttribute(AKHGCDIHALG keyword)
	{
		return false;
	}

	public void Reset()
	{
	}
}
