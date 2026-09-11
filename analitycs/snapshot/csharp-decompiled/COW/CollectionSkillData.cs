using System.Collections.Generic;
using GCommon;

namespace COW;

public class CollectionSkillData : CSVBaseData
{
	public uint ItemID;

	public uint SortID;

	public uint SkillID;

	public uint SkinType;

	public ResourceID PreviewSkillFemale;

	public ResourceID PreviewSkillMale;

	public ResourceID PreviewVfxSkillEffect;

	private ResourceID[] m_1p_ResourceIds;

	private ResourceID[] m_3p_Team_ResourceIds;

	public uint AwakeSkillID;

	private ResourceID[] m_Awake_1p_ResourceIds;

	private ResourceID[] m_Awake_3p_Team_ResourceIds;

	public uint IsHide;

	private string m_skillType;

	private string m_awake_skillType;

	private List<ResourceID> m_NeedDownloadResIds;

	public string skillType => null;

	public string awakeSkillType => null;

	public List<ResourceID> NeedDownloadResIds => null;

	public ResourceID Get1PResourceId(int index)
	{
		return default(ResourceID);
	}

	public ResourceID Get3PTeamResourceId(int index)
	{
		return default(ResourceID);
	}

	public ResourceID GetAwake1PResourceId(int index)
	{
		return default(ResourceID);
	}

	public ResourceID GetAwake3PTeamResourceId(int index)
	{
		return default(ResourceID);
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
