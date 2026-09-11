using System.Collections.Generic;
using GCommon;

namespace COW;

internal class WeaponTabDataManager : SingletonModule<WeaponTabDataManager>
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public uint popType;

		internal bool _003CFindWeaponTabDataByPopType_003Eb__0(WeaponTabData data)
		{
			return false;
		}
	}

	private List<WeaponTabData> m_WeaponTabDataList;

	private Dictionary<uint, WeaponTabData> m_DictTypeToWeaponTab;

	public List<WeaponTabData> WeaponTabDataList => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public uint GetKeyByWeaponType(uint type, uint subType, uint subSubType)
	{
		return 0u;
	}

	public WeaponTabData FindWeaponTabData(uint type, uint subtype, uint subsubtype)
	{
		return null;
	}

	public WeaponTabData FindWeaponTabDataByPopType(uint popType)
	{
		return null;
	}

	public List<WeaponTabData> FindWeaponTabsByPopType(uint popType)
	{
		return null;
	}

	public List<uint> GetIDList()
	{
		return null;
	}
}
