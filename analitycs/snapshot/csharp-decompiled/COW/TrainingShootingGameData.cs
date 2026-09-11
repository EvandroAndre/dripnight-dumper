using SimpleJSON;

namespace COW;

public class TrainingShootingGameData : IJsonGameData
{
	public class Level
	{
		public int id;

		public int hp;

		public float duration;

		public uint count;

		public uint vest;

		public string name;

		public float interval;

		public uint moveType;

		public float[] moveTime;

		public float[] moveStopTime;

		public Level(JSONNode jsonNode)
		{
		}
	}

	public Level level_L;

	public Level level_M;

	public Level level_H;

	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
