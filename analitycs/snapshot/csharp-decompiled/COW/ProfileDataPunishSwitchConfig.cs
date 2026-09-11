using proto;

namespace COW;

public class ProfileDataPunishSwitchConfig
{
	private const ESwitch.SwitchFunc SwitchFunc = ESwitch.SwitchFunc.SwitchFunc_ENABLE_HACKER_HIDE_HOMEPAGE;

	private const char Separator = ';';

	private const int KillTimesIndex = 0;

	private const int HeadShotRatioIndex = 1;

	private const int KDIndex = 2;

	private bool m_HasKillTimes;

	private float m_KillTimes;

	private bool m_HasHeadShotRatio;

	private float m_HeadShotRatio;

	private bool m_HasKD;

	private float m_KD;

	public static ProfileDataPunishSwitchConfig Create(bool masked)
	{
		return null;
	}

	public float GetKillTimesValue(uint killTimes)
	{
		return 0f;
	}

	public string GetKillTimesText(uint killTimes)
	{
		return null;
	}

	public float GetHeadShotRatioValue(float headShotRatio)
	{
		return 0f;
	}

	public string GetHeadShotRatioText(float headShotRatio)
	{
		return null;
	}

	public float GetKDValue(float kd)
	{
		return 0f;
	}

	public string GetKDText(float kd)
	{
		return null;
	}

	private void Parse(string content)
	{
	}

	private string FormatValue(float value)
	{
		return null;
	}
}
