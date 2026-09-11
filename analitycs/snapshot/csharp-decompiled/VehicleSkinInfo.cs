using System.Collections.Generic;
using UnityEngine;

public class VehicleSkinInfo : VehicleSkinInfoBase
{
	public enum TailAnimState
	{
		DownFirstState = 1,
		DownSecondState,
		UpFirstState,
		UpSecondState
	}

	public Transform VehicleBodyModel;

	public Transform VehicleBrakeLight;

	public Transform VehicleSteeringWheel;

	public Transform FrontLeftWheelModel;

	public Transform FrontRightWheelModel;

	public Transform RearLeftWheelModel;

	public Transform RearRightWheelModel;

	private int AnimState;

	private List<Transform> m_WheelModels;

	public override Transform BodyModel => null;

	public override List<Transform> WheelModels => null;

	public override void SetSkinState(bool is_show)
	{
	}

	public override void ClearSkinAttached()
	{
	}

	public override void EnableBrakeLightsEffect(bool enable)
	{
	}

	public override void EnableTailAimi(int state)
	{
	}
}
