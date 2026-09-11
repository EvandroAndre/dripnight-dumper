using GCommon;

namespace COW;

public class SpecialCSConfigData : CSVBaseData
{
	private bool _003CRoundPickBuffOpen_003Ek__BackingField;

	private bool _003CGunBuffOpen_003Ek__BackingField;

	private bool _003CDualActiveSkillOpen_003Ek__BackingField;

	private bool _003CRandomAreaEventOpen_003Ek__BackingField;

	private bool _003CBattleLevelOpen_003Ek__BackingField;

	private bool _003CSAPLandOpen_003Ek__BackingField;

	private bool _003CEighthTrainRoundOpen_003Ek__BackingField;

	public ResourceID[] CustomSpawnAreaFences;

	public uint[] Modules;

	public uint ID;

	public bool RoundPickBuffOpen
	{
		get
		{
			return _003CRoundPickBuffOpen_003Ek__BackingField;
		}
		private set
		{
			_003CRoundPickBuffOpen_003Ek__BackingField = value;
		}
	}

	public bool GunBuffOpen
	{
		get
		{
			return _003CGunBuffOpen_003Ek__BackingField;
		}
		private set
		{
			_003CGunBuffOpen_003Ek__BackingField = value;
		}
	}

	public bool DualActiveSkillOpen
	{
		get
		{
			return _003CDualActiveSkillOpen_003Ek__BackingField;
		}
		private set
		{
			_003CDualActiveSkillOpen_003Ek__BackingField = value;
		}
	}

	public bool RandomAreaEventOpen
	{
		get
		{
			return _003CRandomAreaEventOpen_003Ek__BackingField;
		}
		private set
		{
			_003CRandomAreaEventOpen_003Ek__BackingField = value;
		}
	}

	public bool BattleLevelOpen
	{
		get
		{
			return _003CBattleLevelOpen_003Ek__BackingField;
		}
		private set
		{
			_003CBattleLevelOpen_003Ek__BackingField = value;
		}
	}

	public bool SAPLandOpen
	{
		get
		{
			return _003CSAPLandOpen_003Ek__BackingField;
		}
		private set
		{
			_003CSAPLandOpen_003Ek__BackingField = value;
		}
	}

	public bool EighthTrainRoundOpen
	{
		get
		{
			return _003CEighthTrainRoundOpen_003Ek__BackingField;
		}
		private set
		{
			_003CEighthTrainRoundOpen_003Ek__BackingField = value;
		}
	}

	private void ParseModulesFromArray()
	{
	}

	public override void PostDeserializeData()
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
