using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCTimeLineTrackBase : IUGCTimelineTrack
{
	protected IUGCTimeLine m_TimeLine;

	protected HPKDGEHKENL m_Res;

	protected MHHOHPCLMFB m_TrackType;

	protected int m_UpdateOrder;

	protected int m_TrackId;

	protected IUGCTimelineTrack m_ParentTrack;

	protected List<IUGCTimelineTrack> m_ChildTracks;

	protected int m_LastEnterKeyFrameIndex;

	protected bool m_IsActive;

	protected GHKGGCEMAKO m_CurActiveKeyFrame;

	private bool m_IsDisable;

	public int LastEnterKeyFrameIndex => 0;

	public virtual bool IsDisable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int GetTrackId()
	{
		return 0;
	}

	public virtual bool Init(IUGCTimeLine timeLine, HPKDGEHKENL res)
	{
		return false;
	}

	public int GetKeyFrameCount()
	{
		return 0;
	}

	public GHKGGCEMAKO GetKeyFrameData(int index)
	{
		return null;
	}

	public virtual void Destroy()
	{
	}

	public virtual MHHOHPCLMFB GetUGCTimelineTrackType()
	{
		return MHHOHPCLMFB.EUGCTTType_None;
	}

	public virtual int GetUpdateOrder()
	{
		return 0;
	}

	public virtual List<IUGCTimelineTrack> GetChildTracks()
	{
		return null;
	}

	public virtual void AddChildTrack(IUGCTimelineTrack track)
	{
	}

	public virtual void RevmeChildTrack(IUGCTimelineTrack track)
	{
	}

	public virtual void SetParentTrack(IUGCTimelineTrack track)
	{
	}

	public virtual IUGCTimelineTrack GetParentTrack()
	{
		return null;
	}

	public virtual float GetStartTime()
	{
		return 0f;
	}

	public virtual float GetEndTime()
	{
		return 0f;
	}

	public virtual void OnStart()
	{
	}

	public virtual void OnEnd()
	{
	}

	public virtual bool IsActive()
	{
		return false;
	}

	public virtual void Update()
	{
	}

	protected virtual void OnKeyFrameEnter(GHKGGCEMAKO keyFrameData)
	{
	}

	protected virtual void OnKeyFrameLeave(GHKGGCEMAKO keyFrameData)
	{
	}

	protected virtual bool LinearInterpolation(GHKGGCEMAKO curKeyFrame, GHKGGCEMAKO nextKeyFrame, MHJLOKOOGNB propType, float playProgress, ref IUGCValue ugcValue)
	{
		return false;
	}

	public virtual void UpdateCurKeyFrame()
	{
	}

	public virtual void OnPlay()
	{
	}

	public virtual void OnPause()
	{
	}
}
