using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIModeEditManager : SingletonModule<UIModeEditManager>
{
	private ModeVariables m_CustomModeSettingVariables;

	private UIModeEditData m_CustomModeSetting;

	private Dictionary<uint, ModeVariables> m_CustomModeSettingVariablesCache;

	private Dictionary<uint, UIModeEditData> m_CustomModeSettingCache;

	private HashSet<uint> m_AttemptedCustomIndices;

	private bool m_ClassicLoaded;

	private ModeVariables m_ClassicModeSettingVariables;

	private UIModeEditData m_ClassicModeSetting;

	private bool m_InfectionLoaded;

	private ModeVariables m_InfectionCustomSettingVariables;

	private UIModeEditData m_InfectionCustomModeSetting;

	public List<WorkShopSkillEditListData> SkillCDRule;

	private Dictionary<uint, UIModeEditData> m_SettingDataMap;

	public ModeVariables CustomModeSettingVariables
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIModeEditData CustomModeSetting
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ModeVariables ClassicModeSettingVariables => null;

	public UIModeEditData ClassicModeSetting => null;

	public ModeVariables InfectionCustomSettingVariables => null;

	public UIModeEditData InfectionCustomModeSetting => null;

	protected override void OnInit()
	{
	}

	private void EnsureCustomLoaded(uint index)
	{
	}

	public ModeVariables GetCustomModeSettingVariables(uint index)
	{
		return null;
	}

	public UIModeEditData GetCustomModeSetting(uint index)
	{
		return null;
	}

	private void EnsureClassicLoaded()
	{
	}

	private void EnsureInfectionLoaded()
	{
	}

	public UIModeEditData GetModeEditData(uint gameMode, uint templateID)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public List<uint> GenerateModeTags(UIModeEditData modeEditData, NIKKALKPIBO gameMode, CMDBIPLGLGA groupMode, uint teamCnt, bool limitedAmmo, bool autoHealing, float safeZoneStartTime, float safeZoneStartTimeDefault, float safeZoneSize, float safeZoneSizeDefault, bool zeroCD, bool emptyMap, bool unlimitedBullet, bool unlimitedGloowall, bool unlimitedThrowables, int minNumOfMatchStart, bool usehoudini, bool useraceHoudini, bool useAIGen)
	{
		return null;
	}
}
