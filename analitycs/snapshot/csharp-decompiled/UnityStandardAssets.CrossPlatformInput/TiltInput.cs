using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput;

public class TiltInput : MonoBehaviour
{
	public enum AxisOptions
	{
		ForwardAxis,
		SidewaysAxis
	}

	[Serializable]
	public class AxisMapping
	{
		public enum MappingType
		{
			NamedAxis,
			MousePositionX,
			MousePositionY,
			MousePositionZ
		}

		public MappingType type;

		public string axisName;
	}

	public AxisMapping mapping;

	public AxisOptions tiltAroundAxis;

	public float fullTiltAngle;

	public float centreAngleOffset;

	private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
