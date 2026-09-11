using GCommon;

namespace COW;

public class SameSkillData : CSVBaseData
{
	private uint _003CSkillID_003Ek__BackingField;

	private uint _003CSameSkillID_003Ek__BackingField;

	public uint SkillID
	{
		get
		{
			return _003CSkillID_003Ek__BackingField;
		}
		private set
		{
			_003CSkillID_003Ek__BackingField = value;
		}
	}

	public uint SameSkillID
	{
		get
		{
			return _003CSameSkillID_003Ek__BackingField;
		}
		private set
		{
			_003CSameSkillID_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
