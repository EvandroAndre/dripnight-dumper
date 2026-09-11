using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using message;

namespace COW.Gameplay.UGC;

public class UGCTimelinePreviewMgr
{
	private UGCRuntime m_UGCRuntime;

	private Dictionary<string, IUGCTimelinePreviewEntity> m_previewEntityMap;

	private Dictionary<int, IUGCTimelinePreviewTrack> m_previewTrackMap;

	private UGCTimeLine m_UGCTimeLine;

	public UGCRuntime UGCRuntime => null;

	public bool Init()
	{
		return false;
	}

	public void Destroy()
	{
	}

	public void CreatePreviewEntity(string entityId, string slotName)
	{
	}

	public void CreatePreviewEntityByTimelineData(PAEHKPKMJKN data)
	{
	}

	public void RemovePreviewEntity(string entityId, string slotName)
	{
	}

	public bool ExistPreviewEntity(string entityId)
	{
		return false;
	}

	public IUGCTimelinePreviewEntity GetPreviewEntity(string entityId)
	{
		return null;
	}

	public IUGCValue GetPreviewRepItemData(string entityId, long propId)
	{
		return null;
	}

	private void AddTimeLinePrevieTrack(IUGCTimelineTrack track)
	{
	}

	private void RemoveTimeLinePrevieTrack(int trackId)
	{
	}

	public void StartPreview(PAEHKPKMJKN data)
	{
	}

	public void EndPreview()
	{
	}

	public void AddTimeLineTrack(HPKDGEHKENL trackItemRes, int parentTrackId)
	{
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

	public bool Play()
	{
		return false;
	}

	public bool Pause()
	{
		return false;
	}

	public bool Reset()
	{
		return false;
	}

	public bool GotoPlayStop(float progress)
	{
		return false;
	}

	public void Update(float deltaTime)
	{
	}

	public void UpdateAgain(int trackId = 0)
	{
	}

	public float GetProgress()
	{
		return 0f;
	}

	public void RegisterRepItemChangeEvent(string entityID, Action<long, UGCSimpleValue> handler)
	{
	}

	public void UnRegisterRepItemChangeEvent(string entityID, Action<long, UGCSimpleValue> handler)
	{
	}

	public void DisableTrack(int trackId, bool disable)
	{
	}
}
