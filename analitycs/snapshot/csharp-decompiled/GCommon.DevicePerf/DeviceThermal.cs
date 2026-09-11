using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon.DevicePerf;

public static class DeviceThermal
{
	public static class ThermalStatus
	{
		public const int Unsupported = -1;

		public const int None = 0;

		public const int Light = 1;

		public const int Moderate = 2;

		public const int Severe = 3;

		public const int Critical = 4;

		public const int Emergency = 5;

		public const int Shutdown = 6;
	}

	public interface IThermalMonitor
	{
		void OnThermalStatusChanged(int thermalStatus);
	}

	public abstract class IDeviceThermal
	{
		private GameObject _MessageHandler;

		protected GameObject MessageHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool SupportThermalMonitoring => false;

		public virtual bool SupportThermalHeadroomPrediction => false;

		public virtual int ThermalHeadroomPredictionInterval_MS => 0;

		public virtual bool SupportThermalHeadroomThresholds => false;

		public IDeviceThermal()
		{
		}

		public virtual int GetCurrentThermalStatus()
		{
			return 0;
		}

		public virtual void RegisterThermalMonitor(IThermalMonitor thermalMonitor)
		{
		}

		public virtual void UnregisterThermalMonitor(IThermalMonitor thermalMonitor)
		{
		}

		public virtual float PredictThermalHeadroom(int forecastSeconds)
		{
			return 0f;
		}

		public virtual Dictionary<int, float> GetThermalHeadroomThresholds()
		{
			return null;
		}
	}

	public class DeviceThermal_Default : IDeviceThermal
	{
	}

	public class DeviceThermal_Android : IDeviceThermal
	{
		private class DevicePerfHandler : MonoBehaviour
		{
			public DeviceThermal_Android Device;

			public void OnThermalStatusChanged(string statusStr)
			{
			}
		}

		[Serializable]
		private class ThermalHeadroomPrediction
		{
			public bool NaN;

			public float Result;
		}

		private static AndroidJavaClass _ThermalManager;

		private List<IThermalMonitor> _ThermalMonitors;

		public static AndroidJavaClass ThermalManager => null;

		public override bool SupportThermalHeadroomPrediction => false;

		public override int ThermalHeadroomPredictionInterval_MS => 0;

		public override bool SupportThermalHeadroomThresholds => false;

		public override bool SupportThermalMonitoring => false;

		public override float PredictThermalHeadroom(int forecastSeconds)
		{
			return 0f;
		}

		public override Dictionary<int, float> GetThermalHeadroomThresholds()
		{
			return null;
		}

		public override int GetCurrentThermalStatus()
		{
			return 0;
		}

		public override void RegisterThermalMonitor(IThermalMonitor thermalMonitor)
		{
		}

		public override void UnregisterThermalMonitor(IThermalMonitor thermalMonitor)
		{
		}

		protected void NotifyThermalMonitors_OnThermalStatusChanged(int status)
		{
		}
	}

	private static IDeviceThermal _DeviceThermal;

	public static IDeviceThermal Device => null;

	static DeviceThermal()
	{
	}
}
