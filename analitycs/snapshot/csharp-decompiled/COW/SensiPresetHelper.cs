using System.Collections.Generic;

namespace COW;

public class SensiPresetHelper
{
	public enum PresetType
	{
		Medium,
		High
	}

	public const int PlatFormType = 3;

	public const int SensiSettingNum = 7;

	public Dictionary<int, List<float>> AndroidResetPresets;

	public Dictionary<int, List<float>> IOSResetPresets;

	public Dictionary<int, List<float>> GooglePCResetPresets;

	public void InitResetData()
	{
	}

	public List<float> GetCurrentPreset()
	{
		return null;
	}

	public List<float> GetDefualtSensiPresetSettingByType(int presetType)
	{
		return null;
	}

	private void InitResetPresets()
	{
	}

	private List<float> InitPreset(string strValue)
	{
		return null;
	}
}
