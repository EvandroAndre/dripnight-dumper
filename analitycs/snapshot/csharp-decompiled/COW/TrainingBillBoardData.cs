using SimpleJSON;
using UnityEngine;

namespace COW;

public class TrainingBillBoardData : IJsonGameData
{
	public string CdnUrl;

	public int StartTimeStamp;

	public int EndTimeStamp;

	public Vector2 TextureSize;

	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}

	private void loadCfg(JSONNode jObject)
	{
	}
}
