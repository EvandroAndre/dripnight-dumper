using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace GCommon;

internal class VibrateSDKManager
{
	private enum ThreadRequestType
	{
		None = -1,
		Stop = 1,
		Play = 2,
		Quit = 3
	}

	private class ThreadRequest
	{
		public ThreadRequestType requestType;

		public VibrateSDKData requestCfg;
	}

	public interface IVibrate
	{
		bool isHighQulity { get; }

		void Init();

		void Play(string heString, int loop, int amplitude);

		void Stop();

		void Quit();
	}

	public class Vibrate_Android : IVibrate
	{
		private AndroidJavaObject m_Vibrate;

		private bool _003CisHighQulity_003Ek__BackingField;

		public bool isHighQulity
		{
			get
			{
				return _003CisHighQulity_003Ek__BackingField;
			}
			private set
			{
				_003CisHighQulity_003Ek__BackingField = value;
			}
		}

		public void Init()
		{
		}

		public void Play(string heString, int loop, int amplitude)
		{
		}

		public void Stop()
		{
		}

		public void Quit()
		{
		}
	}

	private static VibrateSDKManager m_instance;

	private static float m_maxDistForVibrate;

	private Transform m_maxDistCameraTransform;

	private IVibrate m_Vibrate;

	private Thread m_PlayThread;

	private AutoResetEvent m_plsyVibrateEvent;

	private Dictionary<int, VibrateSDKData> m_vibrateCfgDic;

	private VibrateSDKData m_currRunEffectData;

	private VibrateSDKData m_currContinuousRunEffectData;

	private List<VibrateSDKData> m_hearEnemyFootStepVibrates;

	private float m_lastHearFootStepTime;

	private int m_lastPlayHearFootStepIndex;

	private ThreadRequest m_threadRequest;

	private float m_currRunEffectStartTime;

	private Dictionary<int, int> m_settingDic;

	public bool isLocalPlayerDead;

	private bool _003CisSupport_003Ek__BackingField;

	private bool _003CisHighQulity_003Ek__BackingField;

	private HashSet<int> m_disableGameVar;

	public static VibrateSDKManager instance => null;

	public bool IsCustomRoomObserver => false;

	public bool isSupport
	{
		get
		{
			return _003CisSupport_003Ek__BackingField;
		}
		private set
		{
			_003CisSupport_003Ek__BackingField = value;
		}
	}

	public bool isHighQulity
	{
		get
		{
			return _003CisHighQulity_003Ek__BackingField;
		}
		private set
		{
			_003CisHighQulity_003Ek__BackingField = value;
		}
	}

	public bool vibrateEnabled => false;

	public bool isMainSettingOpen => false;

	public void Init()
	{
	}

	private void UpdateVibrateDataSettingState()
	{
	}

	public void InitGameVibrate(Transform cameraTransform = null)
	{
	}

	private void StartVibrateThread()
	{
	}

	public void ClearGameVibrate()
	{
	}

	private void ThreadFunc()
	{
	}

	public void Play(int vibrateId)
	{
	}

	public void Play(int vibrateId, Vector3 worldPos)
	{
	}

	public void PlayHearEnemyStep(Vector3 worldPos)
	{
	}

	public bool IsCanplayFootStepVibrate()
	{
		return false;
	}

	private bool isCanPlay(VibrateSDKData newVibrate)
	{
		return false;
	}

	public bool WithinMaxDist(Vector3 worldPos)
	{
		return false;
	}

	public void Stop()
	{
	}

	public int PlayContinuous(int vibrateId)
	{
		return 0;
	}

	public void StopContinuous(int vibrateId)
	{
	}

	public void OnResetSetting()
	{
	}

	public bool isVibrateSettingOpen(int vibrateId)
	{
		return false;
	}

	private int GetSetting(int settingId)
	{
		return 0;
	}

	public void OnApplicationQuit()
	{
	}
}
