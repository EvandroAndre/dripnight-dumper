using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class DetectorMapObjectModel
{
	private FDOJBOJFMJC m_Detector;

	private Player m_LocalPlayer;

	private float m_Range;

	private float m_Interval;

	private float m_ShowPointTime;

	public float FadeTime;

	private Player.IGJPHDANPJD m_LastState;

	public bool ShowAirLine;

	public bool ShowCircle;

	public List<Vector3> DetectedPoints;

	public List<Vector3> DetectedCarPoints;

	public List<uint> DetectedCarPointsSubType;

	public int LastDetectFrame;

	public float LastDetectTime;

	public float NextDetectTime;

	public float DestoryDetectTime;

	public float FadeStartTime;

	public float FadeEndTime;

	private bool _003CStopped_003Ek__BackingField;

	private bool m_IsPlayedAutoQuickChat;

	public Vector3 DetectorPosition => default(Vector3);

	public bool Stopped
	{
		get
		{
			return _003CStopped_003Ek__BackingField;
		}
		protected set
		{
			_003CStopped_003Ek__BackingField = value;
		}
	}

	public float Range => 0f;

	internal DetectorMapObjectModel(FDOJBOJFMJC d)
	{
	}

	public void Update()
	{
	}

	private void DetectionPlayers()
	{
	}

	private void DetectionCars()
	{
	}

	private bool CheckTeammateBuffDelayDestroy()
	{
		return false;
	}
}
