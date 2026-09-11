using System;
using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCAnimationControllerComplex
{
	public interface IAnimationCallback
	{
		void OnPreStatePlay(StatePlayInfo state);

		void OnPostUpdate(float deltaTime);
	}

	public class ClipPlayInfo
	{
		public string UniqueName;

		public float LocalStartTime;

		public float DurationTime;

		public float OriginSpeed;

		public bool OldVersionIsLoop;

		public float FadeinTime;

		public KIMLKJEOGPE WrapMode;

		public UGCResAnimationClip ClipRes;

		public float FreezeAfterTime;

		public float FreezeAnimationTime;

		public bool UseStateTimeToStart;

		public bool CauseStateReplayWhenEnd;

		public int BodyIndex;

		public UGCAnimPlayable_State RuntimeState;

		public int RuntimeStateID;

		public float EndTime => 0f;

		public float GetStartTimeWithFadein(bool autoCrossFade)
		{
			return 0f;
		}
	}

	public class StateSubInfo
	{
		public string BodyName;

		public int BodyIndex;

		public List<ClipPlayInfo> PlayClips;

		public int WaitPlayClipIndex;

		public StatePlayInfo OwnerState;

		public UGCAnimPlayable_IClipPlayer RuntimePlayer;

		public int ReplayFrameID;

		public ClipPlayInfo LastClip => null;

		public bool IsLoop => false;
	}

	public class StatePlayInfo
	{
		public string StateName;

		public string OverrideFFStateName;

		public bool IsOriginLoop;

		public List<StateSubInfo> PlaySubStates;

		public float Duration;

		public float UserPlaySpeed;

		public bool IsLoop;

		public List<DFNPBIBKFHG> Events;

		public ClipPlayInfo LongestClip;

		public Action FOnStatePlayCompleted;

		public int CheckEventIdx;

		public float PrevFramePlayTime;

		public float CurrentFramePlayTime;

		public int CurrentPlayTimeFrameID;

		public Dictionary<int, UGCAnimPlayableSnapPlayer> CacheSnapMap;

		public bool IsIdle => false;

		public StateSubInfo GetOrAddSubState(string bodyName, int bodyIndex)
		{
			return null;
		}

		public void CorrectDurationAndStart(int version)
		{
		}

		public void onStatePlayCompleted()
		{
		}

		public void UpdateCurrentPlayTime(float deltaTime, int frameID)
		{
		}

		public bool IsFlyOverTime(float time, ref float needTime)
		{
			return false;
		}

		public void ResetOnPlayed()
		{
		}
	}

	public class BodyPartInfo
	{
		public string BodyName;

		public int BodyIndex;

		public IHFBKHILNCA PartDefData;

		public StateSubInfo IdleSubState;

		public UGCAnimPlayable_IClipPlayer RuntimePlayer;

		public StateSubInfo CurrentSubState;

		public StateSubInfo DelayPlaySubState;
	}

	public class PlayMachine
	{
		public List<StatePlayInfo> StateList;

		public Dictionary<string, StatePlayInfo> StateDictionary;

		public List<BodyPartInfo> BodyPartList;

		public int BaseWholePartIndex;

		public UGCAnimPlayable_Simple RuntimePlay;

		public int GetBodyPartIndex(string partName)
		{
			return 0;
		}

		public BodyPartInfo GetBodyPart(int partIndex)
		{
			return null;
		}

		public StatePlayInfo GetStateByName(string stateName)
		{
			return null;
		}

		public StatePlayInfo GetOrAddDynamicState(string stateName, UGCResAnimationClip resClip)
		{
			return null;
		}
	}

	private class CachePlayStateInfo
	{
		public int cacheType;

		public string stateName;

		public float speed;

		public bool overrideLoop;

		public bool isLoop;

		public float currentStateSpeed;

		public bool isStateLoop;

		public string currentClipName;

		public float currentClipProgress;

		public bool isClipLoop;

		public float currentClipSpeed;
	}

	public class DynamicClipInfo
	{
		public float LocalStartTime;

		public float DurationTime;

		public float Speed;

		public float FadeinTime;

		public KIMLKJEOGPE WrapMode;

		public UGCResAnimationClip ClipRes;

		public float FreezeAfterTime;

		public string BodyPartName;
	}

	public IAnimationCallback Callback;

	private Animator m_animator;

	private PlayMachine m_playMachine;

	private UGCAnimPlayable_Simple m_simplePlayable;

	private UGCAnimPlayableDebugger m_debugger;

	private StatePlayInfo m_lastPlayingState;

	private bool m_isInited;

	private int m_addClipMask;

	private int m_frameID;

	private string m_attachEntityID;

	private CachePlayStateInfo m_cachePlayState;

	private string m_localPlayCustomStateName;

	private UGCResAnimationClip m_localPlayCustomClipRes;

	private Dictionary<string, float> m_cacheBodyPartWeight;

	public PlayMachine Machine => null;

	public UGCAnimPlayable_Simple Playable => null;

	private bool IsAllReady => false;

	private PlayMachine buildMachine(UGCResAnimationController res)
	{
		return null;
	}

	public static Transform FindChildRecursively(Transform parentTF, string childName)
	{
		return null;
	}

	private void collectTransformAndChild(Transform boneTransform, CFAJFPHPPLF boneData, string parentPath, AvatarMask mask)
	{
	}

	private AvatarMask collectTransformAndChild(List<CFAJFPHPPLF> rootBones)
	{
		return null;
	}

	private void collectTransformAndChild(Transform t, List<Transform> result)
	{
	}

	private void attachPlayable(UGCAnimPlayable_Simple simplePlayable)
	{
	}

	private void tryInitWhenAllReady()
	{
	}

	public void LoadUGCResAnimationController(UGCResAnimationController resObj)
	{
	}

	public static bool IsNearlyEqual(float a, float b)
	{
		return false;
	}

	private void playSubState(StateSubInfo subState, int startIndex = 0, bool forceQueued = false, float minFirstFadeTime = float.PositiveInfinity, bool skipFirstClipDelay = false)
	{
	}

	public void PlayState(StatePlayInfo statePlayInfo, float speed, bool isStateLoop)
	{
	}

	private void stopState(StatePlayInfo statePlayInfo)
	{
	}

	public StatePlayInfo GetCurrentState()
	{
		return null;
	}

	private static void CheckStateEvent(float deltaTime, List<DFNPBIBKFHG> eventList, string receiveEntityID, ref float inOutCheckEventPrevTime, ref int inOutCheckEventIdx)
	{
	}

	private static void CheckStateEventWithNextTime(float nextTime, List<DFNPBIBKFHG> eventList, string receiveEntityID, ref float inOutCheckEventPrevTime, ref int inOutCheckEventIdx)
	{
	}

	private void checkStateEvent(float deltaTimeInput)
	{
	}

	private void checkClipEvent(ClipPlayInfo clipInfo)
	{
	}

	private void updateImpl(float deltaTime)
	{
	}

	private void onSimpleAnimationPrepareFrame()
	{
	}

	public void SetAttachEntityID(string entityID)
	{
	}

	public void AttachAnimation(Animator ani)
	{
	}

	public bool IsAnimationStateOriginLoop(string stateName)
	{
		return false;
	}

	public void SyncAnimationState(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void SyncClipSpeed(string stateName, string currentClipName, float currentClipProgress, float currentClipSpeed, float currentStateSpeed)
	{
	}

	public void SyncClipLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void SyncStateLoop(string stateName, float currentStateSpeed, bool isStateLoop, string currentClipName, float currentClipProgress, bool isClipLoop, float currentClipSpeed)
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void PlayClientCustomClip(AnimationClip clip, bool isLoop)
	{
	}

	public void StopClientCustomClip()
	{
	}

	public bool IsClientCustomClipPlaying()
	{
		return false;
	}

	public void PlayClientCustomRes(UGCResAnimationClip resObj, bool isLoop)
	{
	}

	public void PauseCurrentAnimation(bool isPause)
	{
	}

	public void SetBodyPartWeight(string partName, float weight)
	{
	}

	public void StopAnimationState(string stateName)
	{
	}

	public StatePlayInfo CreateDynamicState(string stateName)
	{
		return null;
	}

	public void RemoveDynamicState(string stateName)
	{
	}

	public void AddClipToDynamicState(StatePlayInfo state, DynamicClipInfo clipInfo)
	{
	}

	public StatePlayInfo GetStateByName(string stateName)
	{
		return null;
	}

	public void BeginPlaybackState()
	{
	}

	public void EndPlaybackState()
	{
	}

	public void SetPlaybackTime(string stateName, float time, bool cacheSnap = true)
	{
	}

	public void SetPlaybackTime(StatePlayInfo state, float time, bool cacheSnap = true)
	{
	}

	public bool CapturePlaybackSnap(UGCAnimPlayableSnapPlayer snap)
	{
		return false;
	}

	public UGCAnimPlayableSnapPlayer MakeSnap(StatePlayInfo state, float time, bool enableCache = true, bool autoCrossFade = false, UGCAnimPlayableSnapPlayer outSnap = null)
	{
		return null;
	}

	private static float calcAnimationTime(ClipPlayInfo needPlayClip, float timeInput, bool autoCrossFade)
	{
		return 0f;
	}

	private UGCAnimPlayableSnapLayer makeSubStateSnap(StatePlayInfo state, StateSubInfo subState, float time, bool autoCrossFade, ref int indexInState)
	{
		return null;
	}
}
