using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSoundEntityObject : MonoBehaviour
{
	public Transform min;

	public Transform max;

	private float _003CminDistance_003Ek__BackingField;

	private float _003CmaxDistance_003Ek__BackingField;

	public float minDistance
	{
		get
		{
			return _003CminDistance_003Ek__BackingField;
		}
		private set
		{
			_003CminDistance_003Ek__BackingField = value;
		}
	}

	public float maxDistance
	{
		get
		{
			return _003CmaxDistance_003Ek__BackingField;
		}
		private set
		{
			_003CmaxDistance_003Ek__BackingField = value;
		}
	}

	public void SetVisible(bool is3d)
	{
	}

	public void SetMinDistance(float value)
	{
	}

	public void SetMaxDistance(float value)
	{
	}
}
