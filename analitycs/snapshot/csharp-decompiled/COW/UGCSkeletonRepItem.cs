using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSkeletonRepItem
{
	public const int PROP_ID_HEAD = -276000;

	public const int PROP_ID_LEFTARM = -276001;

	public const int PROP_ID_LEFTHAND = -276002;

	public const int PROP_ID_RIGHTARM = -276003;

	public const int PROP_ID_RIGHTHAND = -276004;

	public const int PROP_ID_BODY = -276005;

	public const int PROP_ID_LEFTLEG = -276006;

	public const int PROP_ID_LEFTFOOT = -276007;

	public const int PROP_ID_RIGHTLEG = -276008;

	public const int PROP_ID_RIGHTFOOT = -276009;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnHeadChangeEvent;

	public Action<string> OnLeftArmChangeEvent;

	public Action<string> OnLeftHandChangeEvent;

	public Action<string> OnRightArmChangeEvent;

	public Action<string> OnRightHandChangeEvent;

	public Action<string> OnBodyChangeEvent;

	public Action<string> OnLeftLegChangeEvent;

	public Action<string> OnLeftFootChangeEvent;

	public Action<string> OnRightLegChangeEvent;

	public Action<string> OnRightFootChangeEvent;

	private string _003CHead_003Ek__BackingField;

	private string _003CLeftArm_003Ek__BackingField;

	private string _003CLeftHand_003Ek__BackingField;

	private string _003CRightArm_003Ek__BackingField;

	private string _003CRightHand_003Ek__BackingField;

	private string _003CBody_003Ek__BackingField;

	private string _003CLeftLeg_003Ek__BackingField;

	private string _003CLeftFoot_003Ek__BackingField;

	private string _003CRightLeg_003Ek__BackingField;

	private string _003CRightFoot_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Head
	{
		get
		{
			return _003CHead_003Ek__BackingField;
		}
		private set
		{
			_003CHead_003Ek__BackingField = value;
		}
	}

	public string LeftArm
	{
		get
		{
			return _003CLeftArm_003Ek__BackingField;
		}
		private set
		{
			_003CLeftArm_003Ek__BackingField = value;
		}
	}

	public string LeftHand
	{
		get
		{
			return _003CLeftHand_003Ek__BackingField;
		}
		private set
		{
			_003CLeftHand_003Ek__BackingField = value;
		}
	}

	public string RightArm
	{
		get
		{
			return _003CRightArm_003Ek__BackingField;
		}
		private set
		{
			_003CRightArm_003Ek__BackingField = value;
		}
	}

	public string RightHand
	{
		get
		{
			return _003CRightHand_003Ek__BackingField;
		}
		private set
		{
			_003CRightHand_003Ek__BackingField = value;
		}
	}

	public string Body
	{
		get
		{
			return _003CBody_003Ek__BackingField;
		}
		private set
		{
			_003CBody_003Ek__BackingField = value;
		}
	}

	public string LeftLeg
	{
		get
		{
			return _003CLeftLeg_003Ek__BackingField;
		}
		private set
		{
			_003CLeftLeg_003Ek__BackingField = value;
		}
	}

	public string LeftFoot
	{
		get
		{
			return _003CLeftFoot_003Ek__BackingField;
		}
		private set
		{
			_003CLeftFoot_003Ek__BackingField = value;
		}
	}

	public string RightLeg
	{
		get
		{
			return _003CRightLeg_003Ek__BackingField;
		}
		private set
		{
			_003CRightLeg_003Ek__BackingField = value;
		}
	}

	public string RightFoot
	{
		get
		{
			return _003CRightFoot_003Ek__BackingField;
		}
		private set
		{
			_003CRightFoot_003Ek__BackingField = value;
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

	public UGCSkeletonRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
