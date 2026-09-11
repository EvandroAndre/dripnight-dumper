using SimpleJSON;

namespace COW;

public class TrainingGrenadePracticeData : IJsonGameData
{
	public uint Rule;

	public uint GiveItemCnt;

	public uint GiveItemId;

	public float GameTime;

	public uint InitOccurCnt;

	public uint EndGameNeedHitCnt;

	public uint HP;

	public float OccurMoveTargetPerTime;

	public float OccurMultiTargetPerTime;

	public uint OccurNormalCntAfterTargetDown;

	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
