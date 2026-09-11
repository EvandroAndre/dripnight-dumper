using System.Collections.Generic;
using GCommon;

namespace COW;

public class PVETalentDataManager : SingletonModule<PVETalentDataManager>
{
	private Dictionary<uint, PVETalentConifgData> m_TalentConfigDict;

	private Dictionary<uint, List<uint>> m_HgSnowTalentGroupItemDict;

	private List<uint> m_HgSnowTalentGroupList;

	public Dictionary<uint, List<uint>> HgSnowTalentGroupItemDict => null;

	public List<uint> HgSnowTalentGroupList => null;

	protected override void OnInit()
	{
	}

	public PVETalentConifgData GetPVETalentConifgData(uint id)
	{
		return null;
	}

	public Dictionary<uint, PVETalentConifgData> GetAllTalentConfigDict()
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public uint GetHuntingGroundTokenId()
	{
		return 0u;
	}
}
