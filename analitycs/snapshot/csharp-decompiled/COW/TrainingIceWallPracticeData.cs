using SimpleJSON;

namespace COW;

public class TrainingIceWallPracticeData : IJsonGameData
{
	public uint Rule;

	public uint ItemID;

	public uint GiveCount;

	public float GameTime;

	public uint EndGameHp;

	public uint PartChangeTime;

	public float WeaponShowTime;

	public int WeaponCntPerGroup;

	public uint IceWallHP;

	public uint IceWallMaxNum;

	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
