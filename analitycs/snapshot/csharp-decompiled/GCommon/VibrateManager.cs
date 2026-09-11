using COW;
using UnityEngine;

namespace GCommon;

public class VibrateManager : MonoBehaviour
{
	private static VibrateManager m_Instance;

	private CSVAsyncDataMap<int, VibrationInfo> vibrateInfoDic;

	private float m_lastPlayHearFootStepTime;

	private float m_hearFootStepVibrateDuration;

	private VibrationInfo m_hearStepVibrate;

	public static VibrateManager instance => null;

	public bool SupportAmplitudeControl => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void InitVibrateInfo(CSVAsyncDataMap<int, VibrationInfo> info = null)
	{
	}

	public void StartVibrate(VibrateStyle _vibrateStyle)
	{
	}

	public void StartVibrate(VibrationInfo info)
	{
	}

	public void StopVibrate()
	{
	}

	public bool NeedUseVibrateSDKOnIOS(VibrationInfo info)
	{
		return false;
	}

	private bool isVibrateSupported()
	{
		return false;
	}

	public void PlayHearEnemyFootStep()
	{
	}
}
