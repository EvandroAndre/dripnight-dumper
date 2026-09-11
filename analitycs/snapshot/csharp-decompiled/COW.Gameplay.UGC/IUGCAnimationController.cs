using UnityEngine;

namespace COW.Gameplay.UGC;

public interface IUGCAnimationController
{
	void SetAttachEntityID(string entityID);

	void LoadControllerByResUUID(string resUUID);

	void AttachAnimation(Animation ani);

	void SyncAnimationState(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed);

	void SyncClipSpeed(string stateName, string currentClipName, float currentClipProgress, float currentClipSpeed, float currentStateSpeed);

	void SyncClipLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed);

	void SyncStateLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed);

	void Update(float deltaTime);
}
