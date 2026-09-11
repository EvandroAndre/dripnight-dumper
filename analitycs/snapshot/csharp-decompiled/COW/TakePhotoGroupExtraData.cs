using System.Collections.Generic;
using GCommon;

namespace COW;

public class TakePhotoGroupExtraData
{
	public List<TakePhotoGroupFriendInfo> SpecialShowFriends;

	public ResourceID SpecificBG;

	public uint TemplateMemberMinCnt;

	public bool IsSeasonReplayBR;

	public uint SeasonReplayTab;

	public uint TemplateId;

	public List<ulong> SelectedFriendIds;

	public Dictionary<ulong, List<SeasonReplayFriendData>> DicReplayFriendData;

	public ECGroupPhotoGoposFrom GroupPhotoGoposFrom;

	public uint LocalAvatarTransformId;

	public EAvatarModelIngameType LocalAvatarTransformLevel;
}
