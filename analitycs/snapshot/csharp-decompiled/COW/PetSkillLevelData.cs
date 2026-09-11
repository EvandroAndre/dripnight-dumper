using GCommon;

namespace COW;

public class PetSkillLevelData : CSVBaseData
{
	private ResourceID m_SkillIconHud;

	private ResourceID m_SkillIconHudNoBlood;

	public int SkillID;

	public int SkillLevel;

	public string SkillDesc;

	public int UnlockPetLevel;

	public int SkillType;

	public float SkillParameter1;

	public float SkillParameter2;

	public float SkillParameter3;

	public int SkillParameter4;

	public float SkillParameter5;

	public string SkillParameter1Str => null;

	public string SkillParameter2Str => null;

	public string SkillParameter3Str => null;

	public string SkillParameter4Str => null;

	public ResourceID SkillIconHud => default(ResourceID);

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static string GenerateKey(int skillID, int SkillLevel)
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private string AttachColor(string sourceStr)
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
