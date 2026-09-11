using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class LegendClothData : CsvDataIndexedReading, IGetId
{
	public uint SetId;

	public uint LegentType;

	public uint Level;

	public ResourceID ParachuteEffectMale;

	public ResourceID ParachuteEffectFemale;

	public Color ColorVal;

	public ResourceID ColorIcon;

	public ResourceID ParachuteEffectIcon;

	public ResourceID TeamEffectIcon;

	public string Title;

	public string Story;

	public ResourceID IPTag;

	public List<ResourceID> OtherTags;

	public uint ArriveAnimId;

	public ResourceID FootHaloMale;

	public ResourceID FootHaloFemale;

	public ResourceID FootHaloIcon;

	public uint BundleId;

	public ResourceID BgVFX;

	public uint CustomizedBackgroundType;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override string[] GetHeadColNames()
	{
		return null;
	}

	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
