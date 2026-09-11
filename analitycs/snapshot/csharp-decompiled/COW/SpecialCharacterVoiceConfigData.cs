using GCommon;

namespace COW;

public class SpecialCharacterVoiceConfigData : CSVBaseData
{
	private enum EStackType
	{
		Always,
		Once
	}

	private enum EAudibleRange
	{
		OnlySelf,
		Teammates
	}

	public uint ID;

	public uint[] CharacterID;

	public uint[] GameModeSetting;

	public uint EffectsTriggerEventID;

	public uint EffectsConditionID;

	public string EffectsConditionParam;

	private string EffectSoundIDName;

	private ResourceID EffectSoundID;

	public int Priority;

	public string[] LangSuffix;

	public float AudioColdDownTime;

	public int StackType;

	public int AudibleRange;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public ResourceID GetEffectSoundID()
	{
		return default(ResourceID);
	}

	public bool IsTriggerOnce()
	{
		return false;
	}

	public bool IsOnlySelfCanTrigger()
	{
		return false;
	}

	public bool CheckModeSetting(uint mode)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
