using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCEntityRepItem
{
	public const int PROP_ID_ENABLE = -10000;

	public const int PROP_ID_TAGSLIST = -10001;

	public const int PROP_ID_ACTIVESELF = -10002;

	public const int PROP_ID_ACTIVEPARENT = -10003;

	public const int PROP_ID_ACTIVEINHIERARCHY = -10004;

	public const int PROP_ID_ENABLELOGIC = -10005;

	public const int PROP_ID_ENTITYNAME = -10006;

	public const int PROP_ID_AOISETTING = -10007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnEnableChangeEvent;

	public Action<List<object>> OnTagsListChangeEvent;

	public Action<bool> OnActiveSelfChangeEvent;

	public Action<bool> OnActiveParentChangeEvent;

	public Action<bool> OnEnableLogicChangeEvent;

	public Action<string> OnEntityNameChangeEvent;

	public Action<int> OnAOISettingChangeEvent;

	private bool _003CEnable_003Ek__BackingField;

	private List<object> _003CTagsList_003Ek__BackingField;

	private bool _003CActiveSelf_003Ek__BackingField;

	private bool _003CActiveParent_003Ek__BackingField;

	private bool _003CEnableLogic_003Ek__BackingField;

	private string _003CEntityName_003Ek__BackingField;

	private int _003CAOISetting_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool Enable
	{
		get
		{
			return _003CEnable_003Ek__BackingField;
		}
		private set
		{
			_003CEnable_003Ek__BackingField = value;
		}
	}

	public List<object> TagsList
	{
		get
		{
			return _003CTagsList_003Ek__BackingField;
		}
		private set
		{
			_003CTagsList_003Ek__BackingField = value;
		}
	}

	public bool ActiveSelf
	{
		get
		{
			return _003CActiveSelf_003Ek__BackingField;
		}
		private set
		{
			_003CActiveSelf_003Ek__BackingField = value;
		}
	}

	public bool ActiveParent
	{
		get
		{
			return _003CActiveParent_003Ek__BackingField;
		}
		private set
		{
			_003CActiveParent_003Ek__BackingField = value;
		}
	}

	public bool EnableLogic
	{
		get
		{
			return _003CEnableLogic_003Ek__BackingField;
		}
		private set
		{
			_003CEnableLogic_003Ek__BackingField = value;
		}
	}

	public string EntityName
	{
		get
		{
			return _003CEntityName_003Ek__BackingField;
		}
		private set
		{
			_003CEntityName_003Ek__BackingField = value;
		}
	}

	public int AOISetting
	{
		get
		{
			return _003CAOISetting_003Ek__BackingField;
		}
		private set
		{
			_003CAOISetting_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
