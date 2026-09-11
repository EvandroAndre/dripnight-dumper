using System;
using System.Collections.Generic;
using UnityEngine;

public class MeteorEffectController : MonoBehaviour
{
	public struct MeteorShowerTime
	{
		public DateTime startTime;

		public DateTime endTime;

		public bool isRandom;
	}

	public GameObject meteorPrefab;

	public int meteorStartHour;

	public int meteorEndHour;

	public int[] timeSegments;

	private bool isDuringMeteorShower;

	private int generalMeteorDuration;

	private GameObject instance;

	private ParticleSystem[] particles;

	public string meteorSpecificTime;

	private int weatherNightEnd;

	private int weatherNightStart;

	private Queue<MeteorShowerTime> _003CpendingShowTime_003Ek__BackingField;

	public Queue<MeteorShowerTime> pendingShowTime
	{
		get
		{
			return _003CpendingShowTime_003Ek__BackingField;
		}
		private set
		{
			_003CpendingShowTime_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void TickMeteorShower()
	{
	}

	private void OnDestroy()
	{
	}

	private DateTime GetDayOfTheNight(DateTime time)
	{
		return default(DateTime);
	}

	private bool IsInMeteorShowerTime()
	{
		return false;
	}

	private void StartMeteorShower()
	{
	}

	private void StopMeteorShower()
	{
	}

	private void OnMeteorSpecificTimeUpdate(object[] param)
	{
	}

	private void UpdatePendingShowData()
	{
	}
}
