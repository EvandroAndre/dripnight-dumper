using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLineRenderEntityRepItem
{
	public const int PROP_ID_POINTS = -457000;

	public const int PROP_ID_CUSTOMMATERIAL = -457001;

	public const int PROP_ID_WIDTH = -457002;

	private UGCEntityDataStore _repDataMgr;

	public Action<List<object>> OnPointsChangeEvent;

	public Action<string> OnCustomMaterialChangeEvent;

	public Action<float> OnWidthChangeEvent;

	private List<object> _003CPoints_003Ek__BackingField;

	private string _003CCustomMaterial_003Ek__BackingField;

	private float _003CWidth_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public List<object> Points
	{
		get
		{
			return _003CPoints_003Ek__BackingField;
		}
		private set
		{
			_003CPoints_003Ek__BackingField = value;
		}
	}

	public string CustomMaterial
	{
		get
		{
			return _003CCustomMaterial_003Ek__BackingField;
		}
		private set
		{
			_003CCustomMaterial_003Ek__BackingField = value;
		}
	}

	public float Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		private set
		{
			_003CWidth_003Ek__BackingField = value;
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

	public UGCLineRenderEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
