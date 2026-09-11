using System;
using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCLevelObjectModule : IUGCModule
{
	private UGCRuntime ugcRuntime;

	private UGCEntityDataStore entityModule;

	private Dictionary<int, string> itemIDToTypeName;

	public UGCLevelObjectModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void Destroy()
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public int UGCTypeNameToSceneEditItemID(string typeName)
	{
		return 0;
	}

	public string SceneEditItemIDToUGCTypeName(int itemID)
	{
		return null;
	}

	public UGCLogicEntity CreateUGCLevelObject(int itemID, string ugcEntityID, string subLevelGUID, Func<int, string, long, UGCEntityDataStore, bool> prepareDataFunc)
	{
		return null;
	}

	public void RemoveUGCLevelObject(UGCLogicEntity entityToDelete)
	{
	}

	public UGCLogicEntity CloneUGCLevelObjectWithoutAwake(UGCLogicEntity entityToClone)
	{
		return null;
	}
}
