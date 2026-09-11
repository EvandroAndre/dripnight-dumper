using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPhysicalCCTRepItem
{
	public const int PROP_ID_USEPHYSICALCCT = -359000;

	public const int PROP_ID_SLOPELIMIT = -359001;

	public const int PROP_ID_STEPOFFSET = -359002;

	public const int PROP_ID_SKINWIDTH = -359003;

	public const int PROP_ID_MINMOVEDISTANCE = -359004;

	public const int PROP_ID_CENTEROFFSET = -359005;

	public const int PROP_ID_RADIUS = -359006;

	public const int PROP_ID_HEIGHT = -359007;

	public const int PROP_ID_VELOCITY = -359008;

	public const int PROP_ID_MAXSPEED = -359009;

	public const int PROP_ID_GRAVITY = -359010;

	public const int PROP_ID_MASS = -359011;

	public const int PROP_ID_ISSLIDING = -359012;

	public const int PROP_ID_ISTOPCOLLIDING = -359013;

	public const int PROP_ID_ISSIDECOLLIDING = -359014;

	public const int PROP_ID_ISBOTTOMCOLLIDING = -359015;

	public const int PROP_ID_ISSERVERDRIVEN = -359016;

	public const int PROP_ID_USECUSTOMPUSHFORCE = -359017;

	public const int PROP_ID_CUSTOMPUSHFORCE = -359018;

	public const int PROP_ID_ISGROUNDED = -359019;

	public const int PROP_ID_PHYSICALLAYER = -359020;

	public const int PROP_ID_ENABLEROTATEWITHGRAVITY = -359021;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnUsePhysicalCCTChangeEvent;

	public Action<float> OnSlopeLimitChangeEvent;

	public Action<float> OnStepOffsetChangeEvent;

	public Action<float> OnSkinWidthChangeEvent;

	public Action<float> OnMinMoveDistanceChangeEvent;

	public Action<Vector3> OnCenterOffsetChangeEvent;

	public Action<float> OnRadiusChangeEvent;

	public Action<float> OnHeightChangeEvent;

	public Action<Vector3> OnVelocityChangeEvent;

	public Action<float> OnMaxSpeedChangeEvent;

	public Action<Vector3> OnGravityChangeEvent;

	public Action<float> OnMassChangeEvent;

	public Action<bool> OnIsSlidingChangeEvent;

	public Action<bool> OnIsTopCollidingChangeEvent;

	public Action<bool> OnIsSideCollidingChangeEvent;

	public Action<bool> OnIsBottomCollidingChangeEvent;

	public Action<bool> OnIsServerDrivenChangeEvent;

	public Action<bool> OnUseCustomPushForceChangeEvent;

	public Action<float> OnCustomPushForceChangeEvent;

	public Action<bool> OnIsGroundedChangeEvent;

	public Action<int> OnPhysicalLayerChangeEvent;

	public Action<bool> OnEnableRotateWithGravityChangeEvent;

	private bool _003CUsePhysicalCCT_003Ek__BackingField;

	private float _003CSlopeLimit_003Ek__BackingField;

	private float _003CStepOffset_003Ek__BackingField;

	private float _003CSkinWidth_003Ek__BackingField;

	private float _003CMinMoveDistance_003Ek__BackingField;

	private Vector3 _003CCenterOffset_003Ek__BackingField;

	private float _003CRadius_003Ek__BackingField;

	private float _003CHeight_003Ek__BackingField;

	private Vector3 _003CVelocity_003Ek__BackingField;

	private float _003CMaxSpeed_003Ek__BackingField;

	private Vector3 _003CGravity_003Ek__BackingField;

	private float _003CMass_003Ek__BackingField;

	private bool _003CIsSliding_003Ek__BackingField;

	private bool _003CIsTopColliding_003Ek__BackingField;

	private bool _003CIsSideColliding_003Ek__BackingField;

	private bool _003CIsBottomColliding_003Ek__BackingField;

	private bool _003CIsServerDriven_003Ek__BackingField;

	private bool _003CUseCustomPushForce_003Ek__BackingField;

	private float _003CCustomPushForce_003Ek__BackingField;

	private bool _003CIsGrounded_003Ek__BackingField;

	private int _003CPhysicalLayer_003Ek__BackingField;

	private bool _003CEnableRotateWithGravity_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool UsePhysicalCCT
	{
		get
		{
			return _003CUsePhysicalCCT_003Ek__BackingField;
		}
		private set
		{
			_003CUsePhysicalCCT_003Ek__BackingField = value;
		}
	}

	public float SlopeLimit
	{
		get
		{
			return _003CSlopeLimit_003Ek__BackingField;
		}
		private set
		{
			_003CSlopeLimit_003Ek__BackingField = value;
		}
	}

	public float StepOffset
	{
		get
		{
			return _003CStepOffset_003Ek__BackingField;
		}
		private set
		{
			_003CStepOffset_003Ek__BackingField = value;
		}
	}

	public float SkinWidth
	{
		get
		{
			return _003CSkinWidth_003Ek__BackingField;
		}
		private set
		{
			_003CSkinWidth_003Ek__BackingField = value;
		}
	}

	public float MinMoveDistance
	{
		get
		{
			return _003CMinMoveDistance_003Ek__BackingField;
		}
		private set
		{
			_003CMinMoveDistance_003Ek__BackingField = value;
		}
	}

	public Vector3 CenterOffset
	{
		get
		{
			return _003CCenterOffset_003Ek__BackingField;
		}
		private set
		{
			_003CCenterOffset_003Ek__BackingField = value;
		}
	}

	public float Radius
	{
		get
		{
			return _003CRadius_003Ek__BackingField;
		}
		private set
		{
			_003CRadius_003Ek__BackingField = value;
		}
	}

	public float Height
	{
		get
		{
			return _003CHeight_003Ek__BackingField;
		}
		private set
		{
			_003CHeight_003Ek__BackingField = value;
		}
	}

	public Vector3 Velocity
	{
		get
		{
			return _003CVelocity_003Ek__BackingField;
		}
		private set
		{
			_003CVelocity_003Ek__BackingField = value;
		}
	}

	public float MaxSpeed
	{
		get
		{
			return _003CMaxSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CMaxSpeed_003Ek__BackingField = value;
		}
	}

	public Vector3 Gravity
	{
		get
		{
			return _003CGravity_003Ek__BackingField;
		}
		private set
		{
			_003CGravity_003Ek__BackingField = value;
		}
	}

	public float Mass
	{
		get
		{
			return _003CMass_003Ek__BackingField;
		}
		private set
		{
			_003CMass_003Ek__BackingField = value;
		}
	}

	public bool IsSliding
	{
		get
		{
			return _003CIsSliding_003Ek__BackingField;
		}
		private set
		{
			_003CIsSliding_003Ek__BackingField = value;
		}
	}

	public bool IsTopColliding
	{
		get
		{
			return _003CIsTopColliding_003Ek__BackingField;
		}
		private set
		{
			_003CIsTopColliding_003Ek__BackingField = value;
		}
	}

	public bool IsSideColliding
	{
		get
		{
			return _003CIsSideColliding_003Ek__BackingField;
		}
		private set
		{
			_003CIsSideColliding_003Ek__BackingField = value;
		}
	}

	public bool IsBottomColliding
	{
		get
		{
			return _003CIsBottomColliding_003Ek__BackingField;
		}
		private set
		{
			_003CIsBottomColliding_003Ek__BackingField = value;
		}
	}

	public bool IsServerDriven
	{
		get
		{
			return _003CIsServerDriven_003Ek__BackingField;
		}
		private set
		{
			_003CIsServerDriven_003Ek__BackingField = value;
		}
	}

	public bool UseCustomPushForce
	{
		get
		{
			return _003CUseCustomPushForce_003Ek__BackingField;
		}
		private set
		{
			_003CUseCustomPushForce_003Ek__BackingField = value;
		}
	}

	public float CustomPushForce
	{
		get
		{
			return _003CCustomPushForce_003Ek__BackingField;
		}
		private set
		{
			_003CCustomPushForce_003Ek__BackingField = value;
		}
	}

	public bool IsGrounded
	{
		get
		{
			return _003CIsGrounded_003Ek__BackingField;
		}
		private set
		{
			_003CIsGrounded_003Ek__BackingField = value;
		}
	}

	public int PhysicalLayer
	{
		get
		{
			return _003CPhysicalLayer_003Ek__BackingField;
		}
		private set
		{
			_003CPhysicalLayer_003Ek__BackingField = value;
		}
	}

	public bool EnableRotateWithGravity
	{
		get
		{
			return _003CEnableRotateWithGravity_003Ek__BackingField;
		}
		private set
		{
			_003CEnableRotateWithGravity_003Ek__BackingField = value;
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

	public UGCPhysicalCCTRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
