using UnityEngine;
using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCGraph
{
	void LoadGraph(GKGNPJEOEGP graph);

	void UnloadGraph(bool dispatchEvent);

	void OnTick();

	GKGNPJEOEGP GraphData();

	DOMDODOIOBI GetFunction(string funcID);

	UGCLogicEntity OwnerEntity();

	long GetPropertyType(string propertyID);

	bool GetPropertyBool(string propertyID);

	int GetPropertyInt(string propertyID);

	long GetPropertyInt64(string propertyID);

	float GetPropertyFloat(string propertyID);

	Vector2 GetPropertyVector2(string propertyID);

	Vector3 GetPropertyVector3(string propertyID);

	void SetProperty(string propertyID, object value);

	void SetPropertyBool(string propertyID, bool value);

	void SetPropertyInt(string propertyID, int value);

	void SetPropertyInt64(string propertyID, long value);

	void SetPropertyFloat(string propertyID, float value);

	void SetPropertyVector2(string propertyID, Vector2 value);

	void SetPropertyVector3(string propertyID, Vector3 value);
}
