using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAlongPathMotionRepItem
{
	public const int PROP_ID_TARGETENTITY = -431000;

	public const int PROP_ID_PATH = -431001;

	public const int PROP_ID_STYLE = -431002;

	public const int PROP_ID_SPEED = -431003;

	public const int PROP_ID_TANGENTFACING = -431004;

	public const int PROP_ID_ELAPSEDPERCENTAGE = -431005;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<string> OnPathChangeEvent;

	public Action<int> OnStyleChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	public Action<bool> OnTangentFacingChangeEvent;

	public Action<float> OnElapsedPercentageChangeEvent;

	private string _003CTargetEntity_003Ek__BackingField;

	private string _003CPath_003Ek__BackingField;

	private int _003CStyle_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

	private bool _003CTangentFacing_003Ek__BackingField;

	private float _003CElapsedPercentage_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string TargetEntity
	{
		get
		{
			return _003CTargetEntity_003Ek__BackingField;
		}
		private set
		{
			_003CTargetEntity_003Ek__BackingField = value;
		}
	}

	public string Path
	{
		get
		{
			return _003CPath_003Ek__BackingField;
		}
		private set
		{
			_003CPath_003Ek__BackingField = value;
		}
	}

	public int Style
	{
		get
		{
			return _003CStyle_003Ek__BackingField;
		}
		private set
		{
			_003CStyle_003Ek__BackingField = value;
		}
	}

	public float Speed
	{
		get
		{
			return _003CSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CSpeed_003Ek__BackingField = value;
		}
	}

	public bool TangentFacing
	{
		get
		{
			return _003CTangentFacing_003Ek__BackingField;
		}
		private set
		{
			_003CTangentFacing_003Ek__BackingField = value;
		}
	}

	public float ElapsedPercentage
	{
		get
		{
			return _003CElapsedPercentage_003Ek__BackingField;
		}
		private set
		{
			_003CElapsedPercentage_003Ek__BackingField = value;
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

	public UGCAlongPathMotionRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
