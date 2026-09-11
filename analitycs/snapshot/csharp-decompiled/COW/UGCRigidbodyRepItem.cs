using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCRigidbodyRepItem
{
	public const int PROP_ID_TYPE = -257000;

	public const int PROP_ID_USEGRAVITY = -257001;

	public const int PROP_ID_MASS = -257002;

	public const int PROP_ID_CENTEROFMASS = -257003;

	public const int PROP_ID_VELOCITY = -257004;

	public const int PROP_ID_ANGULARVELOCITY = -257005;

	public const int PROP_ID_DRAG = -257006;

	public const int PROP_ID_ANGULARDRAG = -257007;

	public const int PROP_ID_CONSTRAIN = -257008;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnTypeChangeEvent;

	public Action<bool> OnUseGravityChangeEvent;

	public Action<float> OnMassChangeEvent;

	public Action<Vector3> OnCenterOfMassChangeEvent;

	public Action<Vector3> OnVelocityChangeEvent;

	public Action<Vector3> OnAngularVelocityChangeEvent;

	public Action<float> OnDragChangeEvent;

	public Action<float> OnAngularDragChangeEvent;

	public Action<int> OnConstrainChangeEvent;

	private int _003CType_003Ek__BackingField;

	private bool _003CUseGravity_003Ek__BackingField;

	private float _003CMass_003Ek__BackingField;

	private Vector3 _003CCenterOfMass_003Ek__BackingField;

	private Vector3 _003CVelocity_003Ek__BackingField;

	private Vector3 _003CAngularVelocity_003Ek__BackingField;

	private float _003CDrag_003Ek__BackingField;

	private float _003CAngularDrag_003Ek__BackingField;

	private int _003CConstrain_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		private set
		{
			_003CType_003Ek__BackingField = value;
		}
	}

	public bool UseGravity
	{
		get
		{
			return _003CUseGravity_003Ek__BackingField;
		}
		private set
		{
			_003CUseGravity_003Ek__BackingField = value;
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

	public Vector3 CenterOfMass
	{
		get
		{
			return _003CCenterOfMass_003Ek__BackingField;
		}
		private set
		{
			_003CCenterOfMass_003Ek__BackingField = value;
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

	public Vector3 AngularVelocity
	{
		get
		{
			return _003CAngularVelocity_003Ek__BackingField;
		}
		private set
		{
			_003CAngularVelocity_003Ek__BackingField = value;
		}
	}

	public float Drag
	{
		get
		{
			return _003CDrag_003Ek__BackingField;
		}
		private set
		{
			_003CDrag_003Ek__BackingField = value;
		}
	}

	public float AngularDrag
	{
		get
		{
			return _003CAngularDrag_003Ek__BackingField;
		}
		private set
		{
			_003CAngularDrag_003Ek__BackingField = value;
		}
	}

	public int Constrain
	{
		get
		{
			return _003CConstrain_003Ek__BackingField;
		}
		private set
		{
			_003CConstrain_003Ek__BackingField = value;
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

	public UGCRigidbodyRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
