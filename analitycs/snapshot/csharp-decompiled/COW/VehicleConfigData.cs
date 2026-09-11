using System.Collections.Generic;

namespace COW;

public class VehicleConfigData
{
	public EControlMode ControlMode;

	public RigidBodyConfig RigidConfig;

	public VehicleParamConfig VehicleConfig;

	public Dictionary<string, VehicleControllerInfo> ControllerConfigs;

	public VehicleInteratTriggerData InteratTriggerData;
}
