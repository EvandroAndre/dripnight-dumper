using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public interface IUGCTimelineEditorTrackBaseWarp
{
	IUGCTimelineEditorTrack TrackData { get; }

	string ActorSlotName { get; }

	string TrackValue { get; }

	string EntityID { get; }

	int PropID { get; }

	MHHOHPCLMFB TrackType { get; }

	float StartTime { get; }

	float EndTime { get; }

	UGCTimelineEditorDefine.KeyFrameType KeyFrameType { get; }

	string TrackName { get; }

	int TrackID { get; }

	IUGCTimelineEditorTrackBaseWarp ParentTrack { get; }

	List<IUGCTimelineEditorTrackBaseWarp> ChildTracks { get; }

	string GetTrackTitle();

	bool SetTrackTitle(string name);

	void Create(IUGCTimelineEditorTrack data, UGCTimelineEditorContext Mgr);

	void OnPreviewInitialized();

	void OnRuntimeTrackCreated();

	void Update(float deltaTime);

	void Destroy();

	void Serialized();

	void Deserialize();

	void AddChildTrack(IUGCTimelineEditorTrackBaseWarp track);

	void RemoveChildTrack(IUGCTimelineEditorTrackBaseWarp track);

	bool HasChildTrack(int PropID);

	void AddEditKeyFrame(UGCTimelineEditorKeyBase keyframe);

	void RemoveEditKeyFrame(UGCTimelineEditorKeyBase keyframe);

	void RemoveChildrenKeyFrame(float time);

	bool HasKeyFrame(float time);

	bool TryGetScopeKeyFrame(float time, float scope, out UGCTimelineEditorKeyBase keyFrameData);

	bool TryGetKeyFrame(float time, out UGCTimelineEditorKeyBase keyFrameData);

	long CheckValidateTrack();
}
