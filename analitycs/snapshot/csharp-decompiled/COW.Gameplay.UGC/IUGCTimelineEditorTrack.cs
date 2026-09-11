using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public interface IUGCTimelineEditorTrack
{
	HPKDGEHKENL RuntimeData { get; }

	NCFFELGEBLB EditorData { get; }

	List<UGCTimelineEditorKeyBase> Keyframes { get; }

	List<IUGCTimelineEditorTrack> ChildTracks { get; }

	string TrackName { get; set; }

	int TrackID { get; }

	string ActorSlotName { get; set; }

	string EntityID { get; set; }

	UGCTimelineEditorDefine.KeyFrameType KeyFrameType { get; }

	UGCTimelineEditorDefine.RelationType RelationType { get; }

	MHHOHPCLMFB TrackType { get; set; }

	float StartTime { get; set; }

	float EndTime { get; set; }

	long ErrorCode { get; }

	string GetTrackTitle();

	bool SetTrackTitle(string name);

	void Serialized();

	void Deserialize();

	void AddChildTrack(IUGCTimelineEditorTrack track);

	void RemoveChildTrack(IUGCTimelineEditorTrack track);

	bool HasKeyFrame(float time);

	bool TryGetKeyFrame(float time, out UGCTimelineEditorKeyBase keyframe);

	void AddKeyFrame(UGCTimelineEditorKeyBase keyframe);

	void RemoveKeyFrame(float keyframeTime);

	void RemoveKeyFrame(UGCTimelineEditorKeyBase keyframe);

	bool TryGetAllChildKeyFrame(float time, ref List<UGCTimelineEditorKeyBase> keyframe);

	bool RefreshKeyFrame();

	void RefreshTrackTime();

	string GetValue(string key);

	void SetValue(string key, string value);

	long CheckValidateTrack();
}
