using GCommon;

namespace COW;

public class WorkshopAvatarSkillData : CSVBaseData
{
	public string SkillIcon;

	public string SkillName;

	public uint SkillId;

	public override string GetPrimaryKey()
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

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
