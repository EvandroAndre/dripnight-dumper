using GCommon;

namespace COW;

public class SmartAdjustSettingDataManager : SingletonModule<SmartAdjustSettingDataManager>
{
	private CSVAsyncDataMap<uint, SmartAdjustSetting> m_SmartAdjustSettings;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public SmartAdjustSetting GetSettingByLevel(uint level)
	{
		return null;
	}

	public string[] GetTrackedHudNames(uint level)
	{
		return null;
	}

	public uint GetMaxClickRecords(uint level)
	{
		return 0u;
	}

	public float GetNoiseThresholdMultiplier(uint level)
	{
		return 0f;
	}

	public uint GetMinClickCountForAdjust(uint level)
	{
		return 0u;
	}

	public uint GetMinMatchCountForAdjust(uint level)
	{
		return 0u;
	}

	public uint GetSmartHudAdjustType(uint level)
	{
		return 0u;
	}

	public uint GetMaxDisplayRecords(uint level)
	{
		return 0u;
	}

	public uint GetMaxMatchFilesPerPreset(uint level)
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
