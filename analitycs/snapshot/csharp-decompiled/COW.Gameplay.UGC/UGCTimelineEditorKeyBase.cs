using message;

namespace COW.Gameplay.UGC;

public abstract class UGCTimelineEditorKeyBase
{
	public const string KEYFRAME_ERROR_KEY = "ERROR";

	protected GHKGGCEMAKO m_runtimKeyFrameData;

	protected CCHOFCIGDHH m_editKeyFrameData;

	private ulong _003CLastEditTime_003Ek__BackingField;

	protected IUGCTimelineEditorTrack m_Track;

	public GHKGGCEMAKO RuntimeKeyframe => null;

	public CCHOFCIGDHH EditKeyframe => null;

	public bool IsOnlyEditKey => false;

	public ulong LastEditTime
	{
		get
		{
			return _003CLastEditTime_003Ek__BackingField;
		}
		protected set
		{
			_003CLastEditTime_003Ek__BackingField = value;
		}
	}

	public int UniqueId => 0;

	public IUGCTimelineEditorTrack Track
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual float Time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public virtual float Duration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public virtual long ErrorCode
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public IJHPDKODECM EditMapValue => null;

	public virtual void Create(float time)
	{
	}

	public virtual void Create(CCHOFCIGDHH editKeyFrame)
	{
	}

	public virtual void Create(GHKGGCEMAKO keyFrameData)
	{
	}

	public virtual void Create(GHKGGCEMAKO rKeyframe, CCHOFCIGDHH eKeyframe)
	{
	}

	public virtual void Serialized()
	{
	}

	public virtual void Destroy()
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

	protected void SetErrorCode(UGCTimelineEditorErrorCode type, bool value)
	{
	}

	public virtual long CheckValidateKeyFrame()
	{
		return 0L;
	}
}
