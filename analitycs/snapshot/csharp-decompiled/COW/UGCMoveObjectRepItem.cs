using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMoveObjectRepItem
{
	public const int PROP_ID_MOTIONTYPE = -59000;

	public const int PROP_ID_MOTIONVALUEX = -59001;

	public const int PROP_ID_MOTIONVALUEY = -59002;

	public const int PROP_ID_MOTIONVALUEZ = -59003;

	public const int PROP_ID_MOTIONTIME = -59004;

	public const int PROP_ID_STAYTIME = -59005;

	public const int PROP_ID_ISRESET = -59006;

	public const int PROP_ID_EXTRABASEINFOINSTANCEID = -59007;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnMotionTypeChangeEvent;

	public Action<int> OnMotionValueXChangeEvent;

	public Action<int> OnMotionValueYChangeEvent;

	public Action<int> OnMotionValueZChangeEvent;

	public Action<int> OnMotionTimeChangeEvent;

	public Action<int> OnStayTimeChangeEvent;

	public Action<bool> OnIsResetChangeEvent;

	public Action<int> OnExtraBaseInfoInstanceIdChangeEvent;

	private int _003CMotionType_003Ek__BackingField;

	private int _003CMotionValueX_003Ek__BackingField;

	private int _003CMotionValueY_003Ek__BackingField;

	private int _003CMotionValueZ_003Ek__BackingField;

	private int _003CMotionTime_003Ek__BackingField;

	private int _003CStayTime_003Ek__BackingField;

	private bool _003CIsReset_003Ek__BackingField;

	private int _003CExtraBaseInfoInstanceId_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int MotionType
	{
		get
		{
			return _003CMotionType_003Ek__BackingField;
		}
		private set
		{
			_003CMotionType_003Ek__BackingField = value;
		}
	}

	public int MotionValueX
	{
		get
		{
			return _003CMotionValueX_003Ek__BackingField;
		}
		private set
		{
			_003CMotionValueX_003Ek__BackingField = value;
		}
	}

	public int MotionValueY
	{
		get
		{
			return _003CMotionValueY_003Ek__BackingField;
		}
		private set
		{
			_003CMotionValueY_003Ek__BackingField = value;
		}
	}

	public int MotionValueZ
	{
		get
		{
			return _003CMotionValueZ_003Ek__BackingField;
		}
		private set
		{
			_003CMotionValueZ_003Ek__BackingField = value;
		}
	}

	public int MotionTime
	{
		get
		{
			return _003CMotionTime_003Ek__BackingField;
		}
		private set
		{
			_003CMotionTime_003Ek__BackingField = value;
		}
	}

	public int StayTime
	{
		get
		{
			return _003CStayTime_003Ek__BackingField;
		}
		private set
		{
			_003CStayTime_003Ek__BackingField = value;
		}
	}

	public bool IsReset
	{
		get
		{
			return _003CIsReset_003Ek__BackingField;
		}
		private set
		{
			_003CIsReset_003Ek__BackingField = value;
		}
	}

	public int ExtraBaseInfoInstanceId
	{
		get
		{
			return _003CExtraBaseInfoInstanceId_003Ek__BackingField;
		}
		private set
		{
			_003CExtraBaseInfoInstanceId_003Ek__BackingField = value;
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

	public UGCMoveObjectRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
