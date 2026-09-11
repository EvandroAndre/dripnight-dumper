using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLandmineObjRepItem
{
	public const int PROP_ID_TRIGGERTIME = -234000;

	public const int PROP_ID_CANSELFTRIGGER = -234001;

	public const int PROP_ID_CANTEAMTRIGGER = -234002;

	public const int PROP_ID_CANVEHICLETRIGGER = -234003;

	public const int PROP_ID_LIFETIME = -234004;

	public const int PROP_ID_CANBEATTACKED = -234005;

	public const int PROP_ID_MAXHP = -234006;

	public const int PROP_ID_RATIOSELF = -234007;

	public const int PROP_ID_RATIOTEAMMATE = -234008;

	public const int PROP_ID_RATIOVEHICLE = -234009;

	public const int PROP_ID_HP = -234010;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnTriggerTimeChangeEvent;

	public Action<bool> OnCanSelfTriggerChangeEvent;

	public Action<bool> OnCanTeamTriggerChangeEvent;

	public Action<bool> OnCanVehicleTriggerChangeEvent;

	public Action<bool> OnCanBeAttackedChangeEvent;

	public Action<float> OnRatioSelfChangeEvent;

	public Action<float> OnRatioTeammateChangeEvent;

	public Action<float> OnRatioVehicleChangeEvent;

	private float _003CTriggerTime_003Ek__BackingField;

	private bool _003CCanSelfTrigger_003Ek__BackingField;

	private bool _003CCanTeamTrigger_003Ek__BackingField;

	private bool _003CCanVehicleTrigger_003Ek__BackingField;

	private bool _003CCanBeAttacked_003Ek__BackingField;

	private float _003CRatioSelf_003Ek__BackingField;

	private float _003CRatioTeammate_003Ek__BackingField;

	private float _003CRatioVehicle_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float TriggerTime
	{
		get
		{
			return _003CTriggerTime_003Ek__BackingField;
		}
		private set
		{
			_003CTriggerTime_003Ek__BackingField = value;
		}
	}

	public bool CanSelfTrigger
	{
		get
		{
			return _003CCanSelfTrigger_003Ek__BackingField;
		}
		private set
		{
			_003CCanSelfTrigger_003Ek__BackingField = value;
		}
	}

	public bool CanTeamTrigger
	{
		get
		{
			return _003CCanTeamTrigger_003Ek__BackingField;
		}
		private set
		{
			_003CCanTeamTrigger_003Ek__BackingField = value;
		}
	}

	public bool CanVehicleTrigger
	{
		get
		{
			return _003CCanVehicleTrigger_003Ek__BackingField;
		}
		private set
		{
			_003CCanVehicleTrigger_003Ek__BackingField = value;
		}
	}

	public bool CanBeAttacked
	{
		get
		{
			return _003CCanBeAttacked_003Ek__BackingField;
		}
		private set
		{
			_003CCanBeAttacked_003Ek__BackingField = value;
		}
	}

	public float RatioSelf
	{
		get
		{
			return _003CRatioSelf_003Ek__BackingField;
		}
		private set
		{
			_003CRatioSelf_003Ek__BackingField = value;
		}
	}

	public float RatioTeammate
	{
		get
		{
			return _003CRatioTeammate_003Ek__BackingField;
		}
		private set
		{
			_003CRatioTeammate_003Ek__BackingField = value;
		}
	}

	public float RatioVehicle
	{
		get
		{
			return _003CRatioVehicle_003Ek__BackingField;
		}
		private set
		{
			_003CRatioVehicle_003Ek__BackingField = value;
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

	public UGCLandmineObjRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
