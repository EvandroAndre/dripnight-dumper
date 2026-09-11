using GCommon;

namespace COW;

public class InGameVerticleViewRoleData : CSVBaseData
{
	public int RoleId;

	public string RoleName;

	public ResourceID ResId;

	public string[] Desc;

	public uint[] GunIdArray;

	public float MagFillTime;

	public int SkillThreshold;

	public string Icon;

	public ResourceID Sound;

	public string MiniIcon;

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
