using UnityEngine;

public class RCC_Settings
{
	public enum BehaviorType
	{
		Simulator,
		Racing,
		SemiArcade,
		Drift,
		Fun,
		Custom
	}

	public enum ControllerType
	{
		Keyboard,
		Mobile,
		Custom
	}

	public enum Units
	{
		KMH,
		MPH
	}

	public static RCC_Settings instance;

	public bool overrideFixedTimeStep;

	public float fixedTimeStep;

	public float maxAngularVelocity;

	public BehaviorType behaviorType;

	public bool useFixedWheelColliders;

	public ControllerType controllerType;

	public string verticalInput;

	public string horizontalInput;

	public KeyCode handbrakeKB;

	public KeyCode changeCameraKB;

	public KeyCode enterExitVehicleKB;

	public bool useAutomaticGear;

	public bool keepEnginesAlive;

	public bool autoReverse;

	public GameObject contactParticles;

	public Units units;

	public bool useTelemetry;

	public bool useAccelerometerForSteering;

	public bool useSteeringWheelForSteering;

	public float UIButtonSensitivity;

	public float UIButtonGravity;

	public float gyroSensitivity;

	public bool useLightsAsVertexLights;

	public bool useLightProjectorForLightingEffect;

	public string RCCLayer;

	public string RCCTag;

	public bool tagAllChildrenGameobjects;

	public GameObject chassisJoint;

	public GameObject exhaustGas;

	public GameObject projector;

	public LayerMask projectorIgnoreLayer;

	public GameObject headLights;

	public GameObject brakeLights;

	public GameObject reverseLights;

	public GameObject indicatorLights;

	public GameObject mirrors;

	public bool dontUseAnyParticleEffects;

	public bool dontUseChassisJoint;

	public bool dontUseSkidmarks;

	public bool foldGeneralSettings;

	public bool foldControllerSettings;

	public bool foldUISettings;

	public bool foldWheelPhysics;

	public bool foldSFX;

	public bool foldOptimization;

	public static RCC_Settings Instance => null;
}
