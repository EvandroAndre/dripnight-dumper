using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using message;

namespace COW.GamePlay.UGCRuntime;

internal class UGCTimeLine : GNMLOCICOAI, IUGCTimeLine
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<int> _003C_003E9__19_0;

		internal int _003CRemoveTimeLineTrack_003Eb__19_0(int a, int b)
		{
			return 0;
		}
	}

	private UGCResourceTimeLine m_UGCResource;

	private PAEHKPKMJKN m_UGCTimelineData;

	private UGCRuntime m_ugcRuntime;

	private UGCTimeLineActorLib m_ActorLib;

	private List<IUGCTimelineTrack> m_Tracks;

	private bool m_IsPlay;

	private float m_PlayProgress;

	private float m_LastPlayProgress;

	public UGCRuntime GetUGCRuntime()
	{
		return null;
	}

	public UGCTimeLineActorLib GetActorLib()
	{
		return null;
	}

	public UGCTimeLine(UGCRuntime ugcRuntime, UGCEntityDataStore ds, string entityID)
		: base(null, null)
	{
	}

	public override void Destroy()
	{
	}

	public void LoadResourceByUUID(string resUUID)
	{
	}

	public void LoadResourceByPB(PAEHKPKMJKN res)
	{
	}

	private void LoadResComplete(UGCResourceTimeLine res)
	{
	}

	private void InitTimeline()
	{
	}

	private IUGCTimelineTrack CreateTimeLineTrack(MHHOHPCLMFB trackTypeID)
	{
		return null;
	}

	private List<IUGCTimelineTrack> AddTimeLineTrack(HPKDGEHKENL trackItemRes, IUGCTimelineTrack parentTrack)
	{
		return null;
	}

	public List<IUGCTimelineTrack> AddTimeLineTrackByPB(HPKDGEHKENL trackItemRes, int parentTrackId = 0)
	{
		return null;
	}

	public void RemoveTimeLineTrack(int trackId)
	{
	}

	public void UpdataTimeLineTrackRes(int trackId, HPKDGEHKENL trackItemRes)
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public override void Play()
	{
	}

	public override void Pause()
	{
	}

	public override void Reset()
	{
	}

	public override void Update(float deltaTime)
	{
	}

	private void UpdateLogically()
	{
	}

	private void UpdateLogicallyTrack(IUGCTimelineTrack track)
	{
	}

	public float GetProgress()
	{
		return 0f;
	}

	public float GetLastPlayProgress()
	{
		return 0f;
	}

	public float GetLength()
	{
		return 0f;
	}

	public void GotoProgress(float progress)
	{
	}

	public bool SetTrackActor(int trackId, CEDBLAICIBJ slotData)
	{
		return false;
	}

	public void DisableTrack(int trackId, bool disable)
	{
	}

	public IUGCTimelineTrack GetTrack(int trackId)
	{
		return null;
	}

	public List<IUGCTimelineTrack> GetTrackList()
	{
		return null;
	}

	public void UpdateAgainTrack(int trackId)
	{
	}

	public bool IsHideUI()
	{
		return false;
	}

	private void _003CLoadResourceByUUID_003Eb__12_0(bool succ, UGCResourceTimeLine resObj)
	{
	}

	public void _003C_003EiFixBaseProxy_Destroy()
	{
	}

	public void _003C_003EiFixBaseProxy_Play()
	{
	}

	public void _003C_003EiFixBaseProxy_Pause()
	{
	}

	public void _003C_003EiFixBaseProxy_Reset()
	{
	}

	public void _003C_003EiFixBaseProxy_Update(float P0)
	{
	}
}
