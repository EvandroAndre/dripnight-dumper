using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class DirectedPoint
{
	private Vector3 _003CPosition_003Ek__BackingField;

	private Vector3 _003CForward_003Ek__BackingField;

	public Vector3 Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public Vector3 Forward
	{
		get
		{
			return _003CForward_003Ek__BackingField;
		}
		set
		{
			_003CForward_003Ek__BackingField = value;
		}
	}

	public override string ToString()
	{
		return null;
	}

	public bool Equal(DirectedPoint dp)
	{
		return false;
	}

	public DirectedPoint Clone()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
