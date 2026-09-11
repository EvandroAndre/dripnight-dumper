using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public abstract class UGCTimelineEditorTrack : IUGCTimelineEditorTrack
{
	private HPKDGEHKENL _003CRuntimeData_003Ek__BackingField;

	private NCFFELGEBLB _003CEditorData_003Ek__BackingField;

	private List<IUGCTimelineEditorTrack> _003CChildTracks_003Ek__BackingField;

	private UGCTimelineEditTracksConfig _003CTrackConfig_003Ek__BackingField;

	private long _003CErrorCode_003Ek__BackingField;

	protected UGCVarValueDataV2 m_ActorSlotName;

	private List<UGCTimelineEditorKeyBase> m_Keyframes;

	public HPKDGEHKENL RuntimeData
	{
		get
		{
			return _003CRuntimeData_003Ek__BackingField;
		}
		protected set
		{
			_003CRuntimeData_003Ek__BackingField = value;
		}
	}

	public NCFFELGEBLB EditorData
	{
		get
		{
			return _003CEditorData_003Ek__BackingField;
		}
		private set
		{
			_003CEditorData_003Ek__BackingField = value;
		}
	}

	public List<IUGCTimelineEditorTrack> ChildTracks
	{
		get
		{
			return _003CChildTracks_003Ek__BackingField;
		}
		private set
		{
			_003CChildTracks_003Ek__BackingField = value;
		}
	}

	protected UGCTimelineEditTracksConfig TrackConfig
	{
		get
		{
			return _003CTrackConfig_003Ek__BackingField;
		}
		private set
		{
			_003CTrackConfig_003Ek__BackingField = value;
		}
	}

	public string TrackName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int TrackID => 0;

	public long ErrorCode
	{
		get
		{
			return _003CErrorCode_003Ek__BackingField;
		}
		protected set
		{
			_003CErrorCode_003Ek__BackingField = value;
		}
	}

	public UGCTimelineEditorDefine.KeyFrameType KeyFrameType => (UGCTimelineEditorDefine.KeyFrameType)0;

	public UGCTimelineEditorDefine.RelationType RelationType => (UGCTimelineEditorDefine.RelationType)0;

	public string EntityID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string ActorSlotName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MHHOHPCLMFB TrackType
	{
		get
		{
			return MHHOHPCLMFB.EUGCTTType_None;
		}
		set
		{
		}
	}

	public float StartTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float EndTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public IJHPDKODECM EditMapValue => null;

	public List<UGCTimelineEditorKeyBase> Keyframes => null;

	public virtual string GetTrackTitle()
	{
		return null;
	}

	public virtual bool SetTrackTitle(string name)
	{
		return false;
	}

	public virtual void Create(MHHOHPCLMFB trackType, string TrackName, int TrackID)
	{
	}

	public void Deserialize(HPKDGEHKENL runtimeData, NCFFELGEBLB editorData)
	{
	}

	public virtual void Deserialize()
	{
	}

	public virtual void Serialized()
	{
	}

	public void AddChildTrack(IUGCTimelineEditorTrack track)
	{
	}

	public void RemoveChildTrack(IUGCTimelineEditorTrack track)
	{
	}

	public bool HasKeyFrame(float time)
	{
		return false;
	}

	public bool TryGetKeyFrame(float time, out UGCTimelineEditorKeyBase keyframe)
	{
		keyframe = null;
		return false;
	}

	public bool TryGetAllChildKeyFrame(float time, ref List<UGCTimelineEditorKeyBase> list)
	{
		return false;
	}

	public virtual void AddKeyFrame(UGCTimelineEditorKeyBase keyframe)
	{
	}

	public void RemoveKeyFrame(UGCTimelineEditorKeyBase keyframe)
	{
	}

	public virtual void RemoveKeyFrame(float time)
	{
	}

	public bool RefreshKeyFrame()
	{
		return false;
	}

	public virtual void RefreshTrackTime()
	{
	}

	public string GetValue(string key)
	{
		return null;
	}

	public void SetValue(string key, string value)
	{
	}

	protected UGCVarValueDataV2 GetMapValue(IJHPDKODECM mapValue, string key)
	{
		return null;
	}

	protected UGCVarValueDataV2 GetOrCreateMapValue(IJHPDKODECM mapValue, string key)
	{
		return null;
	}

	public virtual long CheckValidateTrack()
	{
		return 0L;
	}

	protected void SetErrorCode(UGCTimelineEditorErrorCode type, bool value)
	{
	}
}
