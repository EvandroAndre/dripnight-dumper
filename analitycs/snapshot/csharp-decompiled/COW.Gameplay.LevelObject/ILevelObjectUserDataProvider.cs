using LitJson;

namespace COW.Gameplay.LevelObject;

public interface ILevelObjectUserDataProvider
{
	void ExportUserData(JsonWriter writer);
}
