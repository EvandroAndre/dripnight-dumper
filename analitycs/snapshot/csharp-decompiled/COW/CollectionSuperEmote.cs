using System.Collections.Generic;
using GCommon;

namespace COW;

public class CollectionSuperEmote : CSVBaseData, IGetId
{
	public string Name;

	public string UserTipsBG;

	public string FloatingWords;

	public string PreviewBG;

	public string FloatWordBG;

	public string Desc;

	public string UseIcon;

	public ResourceID UseIconUIFX;

	public ResourceID Scene;

	public uint InteractiveAnim;

	public float IngameCameraFinishLerpTime;

	public ResourceID IngameCamera;

	public float CutSceneTime;

	public float ChangeSceneTime;

	public ResourceID SoundIngameChangeScene;

	public ResourceID VFXIngameChangeScene;

	public ResourceID PreviewVideo;

	public ResourceID SFXResourceId;

	public ResourceID PreviewFemaleAnimVFX;

	public ResourceID PreviewMaleAnimVFX;

	public ResourceID PreviewFemaleAnim;

	public uint SortID;

	public ResourceID PreviewMaleAnim;

	public uint AnimationID;

	public uint ItemID;

	public uint SourceType;

	public bool NeedTeleport;

	public CollectionPrivilegeTagType GetPrivilegeTagType()
	{
		return CollectionPrivilegeTagType.LeadEmote;
	}

	public void GetAllResIds(ref List<ResourceID> resIdList)
	{
	}

	public float GetAnimClipLength(bool isFemale)
	{
		return 0f;
	}

	public ResourceID GetSuperEmoteAnimRes(bool isFemale)
	{
		return default(ResourceID);
	}

	public ResourceID GetSuperEmoteEffectAnimRes(bool isFemale)
	{
		return default(ResourceID);
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
