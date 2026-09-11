using System.Collections.Generic;
using GCommon;

namespace COW;

public class SkillPowerUpData : CSVBaseData, IGetId
{
	private uint[] m_PowerUpSkillIds;

	private Dictionary<uint, uint> m_PerkToItemMap;

	public string[] power_up_skillid;

	public string[] itemid;

	public uint id;

	public uint skillid;

	public uint[] PowerUpSkillIds => null;

	public Dictionary<uint, uint> PerkToItemMap => null;

	private void ParsePowerUpSkillIds()
	{
	}

	private void BuildPerkToItemMap()
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public bool ContainsSkillId(uint skillId)
	{
		return false;
	}

	public uint GetPowerUpSkillId(int index)
	{
		return 0u;
	}

	public uint GetItemIdByPerk(uint perkSkillId)
	{
		return 0u;
	}

	public uint GetPerkByItemId(uint shopItemId)
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
