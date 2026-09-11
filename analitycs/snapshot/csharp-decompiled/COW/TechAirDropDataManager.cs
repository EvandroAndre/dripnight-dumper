using System.Collections.Generic;
using GCommon;

namespace COW;

public class TechAirDropDataManager : SingletonModule<TechAirDropDataManager>
{
	private Dictionary<uint, TechAirDropSkin> m_SkinDatas;

	public const uint SKIN_TYPE_DEFAULT = 0u;

	public const uint SKIN_TYPE_CSABILITYPOINT_DEFAULT = 13u;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public TechAirDropSkin GetSkinData()
	{
		return null;
	}

	private uint GetSkinType()
	{
		return 0u;
	}

	public TechAirDropSkin GetSkinDataByType(uint skinType)
	{
		return null;
	}
}
