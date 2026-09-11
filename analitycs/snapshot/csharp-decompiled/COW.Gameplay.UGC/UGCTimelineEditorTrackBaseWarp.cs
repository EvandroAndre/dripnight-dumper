using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public abstract class UGCTimelineEditorTrackBaseWarp : IUGCTimelineEditorTrackBaseWarp
{
	protected UGCTimelineEditorContext m_TimelineEditorContext;

	private IUGCTimelineEditorTrack _003CTrackData_003Ek__BackingField;

	protected List<IUGCTimelineEditorTrackBaseWarp> m_ChildTracks;

	private IUGCTimelineEditorTrackBaseWarp _003CParentTrack_003Ek__BackingField;

	public IUGCTimelineEditorTrack TrackData
	{
		get
		{
			return _003CTrackData_003Ek__BackingField;
		}
		protected set
		{
			_003CTrackData_003Ek__BackingField = value;
		}
	}

	public UGCTimelineEditorDefine.KeyFrameType KeyFrameType => (UGCTimelineEditorDefine.KeyFrameType)0;

	public string ActorSlotName => null;

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

	public MHHOHPCLMFB TrackType => MHHOHPCLMFB.EUGCTTType_None;

	public float StartTime => 0f;

	public float EndTime => 0f;

	public long ErrorCode => 0L;

	public List<IUGCTimelineEditorTrackBaseWarp> ChildTracks => null;

	public virtual IUGCTimelineEditorTrackBaseWarp ParentTrack
	{
		get
		{
			return _003CParentTrack_003Ek__BackingField;
		}
		set
		{
			_003CParentTrack_003Ek__BackingField = value;
		}
	}

	public virtual string TrackValue => null;

	public int PropID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string GetTrackTitle()
	{
		return null;
	}

	public bool SetTrackTitle(string name)
	{
		return false;
	}

	public virtual void Create(IUGCTimelineEditorTrack data, UGCTimelineEditorContext Mgr)
	{
	}

	public virtual void Load(IUGCTimelineEditorTrack data, UGCTimelineEditorContext Mgr)
	{
	}

	public virtual void OnPreviewInitialized()
	{
	}

	public virtual void OnRuntimeTrackCreated()
	{
	}

	public virtual void Update(float deltaTime)
	{
	}

	public virtual void Destroy()
	{
	}

	public virtual void Serialized()
	{
	}

	public virtual void Deserialize()
	{
	}

	public virtual void AddChildTrack(IUGCTimelineEditorTrackBaseWarp track)
	{
	}

	public virtual void RemoveChildTrack(IUGCTimelineEditorTrackBaseWarp track)
	{
	}

	public virtual bool HasChildTrack(int PropID)
	{
		return false;
	}

	public virtual void SetParentTrack(IUGCTimelineEditorTrackBaseWarp track)
	{
	}

	public virtual void AddEditKeyFrame(UGCTimelineEditorKeyBase keyframe)
	{
	}

	public virtual void RemoveEditKeyFrame(UGCTimelineEditorKeyBase keyframe)
	{
	}

	public virtual void RemoveChildrenKeyFrame(float time)
	{
	}

	public virtual bool HasKeyFrame(float time)
	{
		return false;
	}

	public abstract bool TryGetScopeKeyFrame(float time, float scope, out UGCTimelineEditorKeyBase keyFrameData);

	public abstract bool TryGetKeyFrame(float time, out UGCTimelineEditorKeyBase keyFrameData);

	public long CheckValidateTrack()
	{
		return 0L;
	}
}
