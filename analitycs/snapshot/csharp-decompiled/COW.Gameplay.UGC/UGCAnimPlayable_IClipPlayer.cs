using UnityEngine;
using UnityEngine.Playables;

namespace COW.Gameplay.UGC;

public interface UGCAnimPlayable_IClipPlayer
{
	string name { get; set; }

	bool isPlaying { get; }

	bool isEmpty { get; }

	bool isQueueEmpty { get; }

	float remainTime { get; }

	// C# has no syntax for parameterized property 'Item'.
	UGCAnimPlayable_State get_Item(string name);

	Playable RootPlayable { get; }

	bool IsAllDone { get; }

	int StateCount { get; }

	// C# has no syntax for parameterized property 'Item'.
	UGCAnimPlayable_State get_Item(int index);

	bool isWeightDirty { get; set; }

	float weight { get; }

	float userWeight { get; set; }

	int AddClip(string name, AnimationClip clip, int stateMask = 0);

	UGCAnimPlayable_State Play(string stateName, float duration = -1f);

	UGCAnimPlayable_State CrossFade(string stateName, float fadeTime = 0.2f, float duration = -1f);

	UGCAnimPlayable_State PlayQueued(string stateName, float duration = -1f);

	UGCAnimPlayable_State CrossFadeQueued(string stateName, float fadeTime = 0.2f, float duration = -1f);

	UGCAnimPlayable_State Play(int stateID, float duration = -1f);

	UGCAnimPlayable_State CrossFade(int stateID, float fadeTime = 0.2f, float duration = -1f);

	UGCAnimPlayable_State PlayQueued(int stateID, float delayTime = 0f, float duration = -1f);

	UGCAnimPlayable_State CrossFadeQueued(int stateID, float fadeTime = 0.2f, float delayTime = 0f, float duration = -1f);

	bool CaptureLayerSnap(UGCAnimPlayableSnapLayer snap);

	void ApplySnap(UGCAnimPlayableSnapLayer snap);

	bool IsPlaying(string stateName);

	UGCAnimPlayable_State getStateByName(string stateName);

	float PlayerUpdate(double animationDeltaTime);

	void ResotreWithGraphChanged(PlayableGraph graph);

	void Stop();

	void StopState(string stateName);

	void FadeTo(float targetWeight, float inFadeTime);

	void Clear(bool isDestroy, int maskState = 0);

	void Resume();
}
