using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCTimelineTrack
{
	bool IsDisable { get; set; }

	bool Init(IUGCTimeLine timeLine, HPKDGEHKENL res);

	MHHOHPCLMFB GetUGCTimelineTrackType();

	int GetUpdateOrder();

	int GetTrackId();

	List<IUGCTimelineTrack> GetChildTracks();

	void AddChildTrack(IUGCTimelineTrack track);

	void RevmeChildTrack(IUGCTimelineTrack track);

	void SetParentTrack(IUGCTimelineTrack track);

	IUGCTimelineTrack GetParentTrack();

	float GetStartTime();

	float GetEndTime();

	void OnStart();

	void OnEnd();

	bool IsActive();

	void Update();

	void Destroy();

	void UpdateCurKeyFrame();

	void OnPlay();

	void OnPause();
}
