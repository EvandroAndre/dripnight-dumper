using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCModuleTransform : IUGCModule
{
	string[] GetChildren(EntityIndex index);

	bool HasNode(string entityID);

	void AddNode(string entityID);

	bool TrySetNodePacketID(string entityID, uint newPacketID);

	void ApplyOrphanTRSState(int syncID, string entityID, uint packetID);

	void RemoveNode(string entityID);

	void UpdateFromDataStore(EntityIndex index);

	void SetVector3Property(string entityID, long propID, Vector3 v);

	Vector3 GetVector3Property(string entityID, long propID);

	void SetQuaternionProperty(string entityID, long propID, Quaternion v);

	Quaternion GetQuaternionProperty(string entityID, long propID);

	void OnTick(float gameTime, float deltaTime);

	void OnTransformNodeCreated(string id);

	void UpdateUnityTransformOnGameObjectChanged(string entityID, GameObject entityObject);

	bool SetParent(UGCLogicEntity parent, UGCLogicEntity child, bool keepWorldPos);

	List<string> GetAllParent(string entityID);

	string GetParent(string entityID);

	void RemoveFromWaitList(string entityID);

	void AddToWaitList(string entityID);
}
