using System.Collections.Generic;

namespace COW;

public class HudUploadInfoItem
{
	public string HudName;

	public string HudDesc;

	public long HudLikeCnt;

	public List<uint> HudTags;

	public HudConfigs HudConfigs;

	public float[] GetSensitivitySettings()
	{
		return null;
	}

	public void SetSensitivitySettings(float[] sensitivitySettings)
	{
	}
}
