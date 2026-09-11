using GCommon;

namespace COW;

public class TransformData : CSVBaseData
{
	private class AfterParseDataContext
	{
		public uint AvatarTransformID;
	}

	public uint iID;

	public uint sortId;

	public uint TransformType;

	public string Name;

	public string Desc;

	public string OutGameKey1;

	public string OutGameKey2;

	public ResourceID InGameIcon1;

	public ResourceID InGameIcon2;

	public ResourceID AnimationMaleBeforeID;

	public ResourceID AnimationMaleAfterID;

	public ResourceID AnimationFemaleBeforeID;

	public ResourceID AnimationFemaleAfterID;

	public ResourceID AnimationMaleBeforeID2;

	public ResourceID AnimationMaleAfterID2;

	public ResourceID AnimationFemaleBeforeID2;

	public ResourceID AnimationFemaleAfterID2;

	public ResourceID TransformVFXLobbyMale;

	public ResourceID TransformVFXIngameMale;

	public ResourceID TransformVFXLobbyFemale;

	public ResourceID TransformVFXIngameFemale;

	public ResourceID TransformVFXLobbyMale2;

	public ResourceID TransformVFXIngameMale2;

	public ResourceID TransformTriggerEffectLobbyMale;

	public ResourceID TransformVFXLobbyFeMale2;

	public ResourceID TransformVFXIngameFemale2;

	public ResourceID TransformTriggerEffectLobbyFemale;

	public ResourceID TransformModelIdle;

	public uint NewMatType;

	public ResourceID InGameSoundEffect1;

	public ResourceID InGameSoundEffect2;

	public ResourceID InGameSoundEffect3;

	public AvatarTransformData AvatarTransformData;

	private AfterParseDataContext context;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public CollectionPrivilegeTagType GetTransformPrivilegeType()
	{
		return CollectionPrivilegeTagType.LeadEmote;
	}

	public bool IsMultipleTransform()
	{
		return false;
	}

	public bool IsFreeMultipleTransform()
	{
		return false;
	}

	public bool IsSupportMultipleTransform()
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
