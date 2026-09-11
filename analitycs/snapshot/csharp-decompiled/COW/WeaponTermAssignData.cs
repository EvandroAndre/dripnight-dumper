using System.Collections.Generic;
using GCommon;

namespace COW;

public class WeaponTermAssignData : CSVBaseData, IGetId
{
	public Dictionary<uint, uint> m_TermAssignMap;

	public string term_desc;

	public string term_icon;

	public uint[] weapon_ids;

	public uint weapon_term;

	public uint id;

	public override void PostDeserializeData()
	{
	}

	public uint GetWeaponTermByWeaponId(uint weaponId)
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

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
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
