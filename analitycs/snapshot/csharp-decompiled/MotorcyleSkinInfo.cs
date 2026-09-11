using System.Collections.Generic;
using UnityEngine;

public class MotorcyleSkinInfo : VehicleSkinInfoBase
{
	public Transform MotorcyleBodyModel;

	public Transform VehicleBrakeLight;

	public Transform FrontWheelModel;

	public Transform RearWheelModel;

	public Transform FenderModel;

	public Transform SteerHandleModel;

	protected List<Transform> m_WheelModels;

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
