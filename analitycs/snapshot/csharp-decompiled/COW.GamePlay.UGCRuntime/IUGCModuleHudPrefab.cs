namespace COW.GamePlay.UGCRuntime;

public interface IUGCModuleHudPrefab : IUGCModule
{
	void RemoveCustomHudOrWidgetEntity(string entityID);

	string FindHudWidgetEntity(string hudEntityID, string widgetFileID);

	string FindHudWidgetEntityByString(string hudEntityID, string hudPrefabID, string widgetNameOrPath);

	void SetHudSizeProp(string entityID, int propID, int itemValue);

	int GetHudSizeProp(string entityID, int propID);

	string[] GetChildren(string entityID);

	string GetParent(string entityID);

	string CloneEntity(string entityID);

	void SetParent(string childEntityID, string parentEntityID, bool keepWordPos);

	void SetAccountID(string entityID, string value);

	string GetAccountID(string entityID);
}
