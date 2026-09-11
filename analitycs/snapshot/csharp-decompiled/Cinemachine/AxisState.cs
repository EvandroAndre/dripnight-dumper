using System;

namespace Cinemachine;

[Serializable]
public struct AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert)
{
	[Serializable]
	public struct Recentering(bool enabled, float waitTime, float recenteringTime)
	{
		public bool m_enabled = false;

		public float m_WaitTime = 0f;

		public float m_RecenteringTime = 0f;

		private float mLastAxisInputTime = 0f;

		private float mRecenteringVelocity = 0f;

		private int m_LegacyHeadingDefinition = 0;

		private int m_LegacyVelocityFilterStrength = 0;

		public void Validate()
		{
		}

		public void CopyStateFrom(ref Recentering other)
		{
		}

		public void CancelRecentering()
		{
		}

		public void RecenterNow()
		{
		}

		public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget)
		{
		}

		public bool LegacyUpgrade(ref int heading, ref int velocityFilter)
		{
			return false;
		}
	}

	public float Value = 0f;

	public float m_MaxSpeed = 0f;

	public float m_AccelTime = 0f;

	public float m_DecelTime = 0f;

	public string m_InputAxisName = null;

	public float m_InputAxisValue = 0f;

	public bool m_InvertInput = false;

	public float m_MinValue = 0f;

	public float m_MaxValue = 0f;

	public bool m_Wrap = false;

	public Recentering m_Recentering = default(Recentering);

	private float mCurrentSpeed = 0f;

	private const float Epsilon = 0.0001f;

	private bool m_ValueRangeLocked = false;

	private bool m_HasRecentering = false;

	public bool ValueRangeLocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasRecentering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void Validate()
	{
	}

	public void Reset()
	{
	}

	public bool Update(float deltaTime)
	{
		return false;
	}

	private float GetMaxSpeed()
	{
		return 0f;
	}
}
