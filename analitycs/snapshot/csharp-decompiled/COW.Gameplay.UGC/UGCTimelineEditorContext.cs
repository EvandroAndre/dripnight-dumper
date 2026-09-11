using System;
using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorContext : IUGCTimelineEditorManager
{
	public enum TimelineState
	{
		None,
		Pause,
		Play,
		Stop
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public UGCTimelineEditorContext _003C_003E4__this;

		public Action<bool> callback;

		internal void _003CAddEditKeyClipAtCurrentTime_003Eb__0(bool value, UGCTimelineEditorKeyBase frameData)
		{
		}
	}

	private CAIDHLFFJDP m_TimelineEditorAsset;

	private PAEHKPKMJKN m_TimelineRuntimeAsset;

	private UGCTimelinePreviewMgr m_PreviewManager;

	private List<IUGCTimelineEditorTrackBaseWarp> m_TrackWarps;

	private bool _003CIsInSceneEditView_003Ek__BackingField;

	private bool _003CIsInspectorShowing_003Ek__BackingField;

	private bool _003CIsDragging_003Ek__BackingField;

	private bool _003CIsRecording_003Ek__BackingField;

	private bool m_IsSwitchCameraMute;

	private IUGCTimelineEditorTrackBaseWarp m_CurrentTrackWarp;

	private IUGCTimelineEditorTrackBaseWarp m_CurrentRealTrackWarp;

	private UGCTimelineEditorKeyClip m_CurrentManuallySelectedKeyClip;

	private TimelineModeButtonHandler m_handler;

	public bool IsPlaying => false;

	public UGCTimelinePreviewMgr Preview => null;

	public List<IUGCTimelineEditorTrackBaseWarp> Tracks => null;

	public string Name => null;

	public List<CEDBLAICIBJ> EntitySlots => null;

	public string AssetID => null;

	public float Duration => 0f;

	public int FrameRate => 0;

	public int Mode => 0;

	public float Zoom => 0f;

	public int Unit => 0;

	public float CurrentTime => 0f;

	public bool IsInSceneEditView
	{
		get
		{
			return _003CIsInSceneEditView_003Ek__BackingField;
		}
		set
		{
			_003CIsInSceneEditView_003Ek__BackingField = value;
		}
	}

	public bool IsInspectorShowing
	{
		get
		{
			return _003CIsInspectorShowing_003Ek__BackingField;
		}
		set
		{
			_003CIsInspectorShowing_003Ek__BackingField = value;
		}
	}

	public bool IsDragging
	{
		get
		{
			return _003CIsDragging_003Ek__BackingField;
		}
		set
		{
			_003CIsDragging_003Ek__BackingField = value;
		}
	}

	public bool IsRecording
	{
		get
		{
			return _003CIsRecording_003Ek__BackingField;
		}
		private set
		{
			_003CIsRecording_003Ek__BackingField = value;
		}
	}

	public bool IsSwitchCameraMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsCanEdit => false;

	public IUGCTimelineEditorTrackBaseWarp CurrentTrackWarp => null;

	public IUGCTimelineEditorTrackBaseWarp CurrentRealTrackWarp => null;

	public UGCTimelineEditorKeyClip CurrentManuallySelectedKeyClip => null;

	public bool CheckTrackMaxLimit()
	{
		return false;
	}

	public void SetCurrentTrackWarp(IUGCTimelineEditorTrackBaseWarp value)
	{
	}

	public void SetManuallySelectedKeyClip(UGCTimelineEditorKeyClip keyClip)
	{
	}

	public bool TryGetScopeKeyFrame(float time, float scope, out UGCTimelineEditorKeyBase keyFrameData)
	{
		keyFrameData = null;
		return false;
	}

	public bool HasKeyFrame(float time)
	{
		return false;
	}

	public bool TryGetKeyFrame(float time, out UGCTimelineEditorKeyBase keyFrameData)
	{
		keyFrameData = null;
		return false;
	}

	public bool TryGetPropTrack(long PropID, out IUGCTimelineEditorTrackBaseWarp trackBaseWarp)
	{
		trackBaseWarp = null;
		return false;
	}

	public UGCTimelineEditorKeyBase AddEditKeyFrameAtCurrentTime()
	{
		return null;
	}

	public void AddEditKeyClipAtCurrentTime(Action<bool> callback)
	{
	}

	public void AddOrUpdatePropertyKeyFrame(UGCTimelineEditorKeyFrame editKeyFrame, int propID, string propertyName, MHJLOKOOGNB type, MutableValue value, bool dispatchEvent = true)
	{
	}

	public void AddOrUpdateArgumentKeyClip(UGCTimelineEditorKeyClip keyClip, string argumentName, string type, MutableValue value, bool dispatchEvent = true)
	{
	}

	public void RemoveCurrentTrack()
	{
	}

	public void RemoveCurrentKeyframe()
	{
	}

	public void RemoveCurrentKeyClip()
	{
	}

	public void StopRecording()
	{
	}

	public void StartRecording()
	{
	}

	public void RefreshCameraPFVMode()
	{
	}

	public void Load(CAIDHLFFJDP asset, PAEHKPKMJKN timelineData)
	{
	}

	public void UnLoad()
	{
	}

	public HPKDGEHKENL GetRuntimeTrackData(int trackId)
	{
		return null;
	}

	public bool Serialized()
	{
		return false;
	}

	public void Deserialize()
	{
	}

	public void Destroy()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	public void Update()
	{
	}

	public void RefreshPreview()
	{
	}

	public void RefreshPreview(IUGCTimelineEditorTrackBaseWarp track)
	{
	}

	public void SlowGoToTime(float newTime)
	{
	}

	public bool HasTrack(string entityID, MHHOHPCLMFB trackType)
	{
		return false;
	}

	public bool HasTrack(string entityID)
	{
		return false;
	}

	public bool HasTrack(MHHOHPCLMFB trackType)
	{
		return false;
	}

	public bool TryGetTrack(string entityID, out IUGCTimelineEditorTrackBaseWarp trackWarp)
	{
		trackWarp = null;
		return false;
	}

	public int GetTrackUniqueID()
	{
		return 0;
	}

	public bool CheckActorSlotNameValid(string slotName)
	{
		return false;
	}

	public string GetValidSlotName(string name)
	{
		return null;
	}

	public string GetValidTrackName(MHHOHPCLMFB trackType, string name)
	{
		return null;
	}

	public void AddTrack(IUGCTimelineEditorTrackBaseWarp trackWarp, IUGCTimelineEditorTrack trackData)
	{
	}

	public void RemoveChildTrack(IUGCTimelineEditorTrackBaseWarp childTrackWarp)
	{
	}

	public void RemoveTrack(IUGCTimelineEditorTrack trackData)
	{
	}

	public void AddEntitySlotData(string entityID, string actorSlotName)
	{
	}

	public void UpdateEntitySlotData(string entityID, string actorSlotName)
	{
	}

	public string GetEntityIDFromEntitySlots(string actorSlotName)
	{
		return null;
	}

	public string GetSceneEditNameFromActorName(string actorSlotName)
	{
		return null;
	}

	public void RemoveEntitySlotData(string actorSlotName)
	{
	}

	public void RemoveEntitySlotData(string entityID, string actorSlotName)
	{
	}

	public void UpdateKeyFrameTime(UGCTimelineEditorKeyBase keyFrameData, float time, bool dispatch = true)
	{
	}

	public void UpdateKeyFrameDuration(UGCTimelineEditorKeyClip keyFrameData, float duration, bool dispatch = true)
	{
	}

	public void RefreshDuration()
	{
	}

	private float GetTrackDuration(IUGCTimelineEditorTrackBaseWarp track)
	{
		return 0f;
	}

	public bool CheckShowInInspector(int propID)
	{
		return false;
	}

	public List<UGCTimelineEditRule> GetTimelineRuleTips()
	{
		return null;
	}

	public void SetAdjuestButtonHandler(TimelineModeButtonHandler handler)
	{
	}

	public void RefreshAdjuestButton()
	{
	}

	public void RefreshTransformToolsState()
	{
	}

	public void SetTimelineSettingIcon(bool highlight)
	{
	}

	public void SetAddSutTrackIcon(bool highlight)
	{
	}

	public void SetAdjuestExpand(bool expand)
	{
	}

	public SceneEditItemAdjust.ButtonState GetAdjuestShowState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	private SceneEditItemAdjust.ButtonState ShowPropertyTrackAdjustState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	private SceneEditItemAdjust.ButtonState ShowEntityTrackAdjustState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	private SceneEditItemAdjust.ButtonState ShowEventTrackAdjustState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	private SceneEditItemAdjust.ButtonState ShowCameraTrackAdjustState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	private SceneEditItemAdjust.ButtonState ShowNPCTrackAdjustState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}

	private SceneEditItemAdjust.ButtonState ShowSubTrackAdjustState()
	{
		return SceneEditItemAdjust.ButtonState.None;
	}
}
