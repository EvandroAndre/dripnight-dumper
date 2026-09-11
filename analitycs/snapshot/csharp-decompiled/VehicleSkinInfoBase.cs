using System.Collections.Generic;
using UnityEngine;

public abstract class VehicleSkinInfoBase : MonoBehaviour
{
	private uint _003CSkinResID_003Ek__BackingField;

	public Animation TailAni;

	public int FirstAniSpeed;

	public int SecondAniSpeed;

	public string BoostEndEffectRes;

	public string BoostStartEffectRes;

	public string BoostLoopEffectRes;

	public Vector3 LeftFrontWheel;

	public Vector3 RightFrontWheel;

	public Vector3 LeftBottomWheel;

	public Vector3 RightBottomWheel;

	public Vector3 DriveSeat;

	public Vector3 PassengerSeat;

	public Vector3 SteeringWheel;

	public string GearVFX;

	public GameObject RunningVFX;

	public Transform[] Seats;

	public uint SkinResID
	{
		get
		{
			return _003CSkinResID_003Ek__BackingField;
		}
		set
		{
			_003CSkinResID_003Ek__BackingField = value;
		}
	}

	public abstract Transform BodyModel { get; }

	public abstract List<Transform> WheelModels { get; }

	public abstract void SetSkinState(bool is_show);

	public abstract void ClearSkinAttached();

	public abstract void EnableBrakeLightsEffect(bool enable);

	public abstract void EnableTailAimi(int state);
}
