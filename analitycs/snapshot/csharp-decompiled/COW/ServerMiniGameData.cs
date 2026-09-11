using System.Collections.Generic;
using GCommon;
using SimpleJSON;

namespace COW;

public class ServerMiniGameData : IJsonGameData
{
	public uint GameType;

	public ResourceID MarkIconRes;

	public string GameTitleKey;

	public uint RewardActivitId;

	public uint RewardItemId;

	public uint RewardItemNum;

	public ResourceID RewardIconRes;

	public List<ResourceID> EffectResList;

	public uint BigEventId;

	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
