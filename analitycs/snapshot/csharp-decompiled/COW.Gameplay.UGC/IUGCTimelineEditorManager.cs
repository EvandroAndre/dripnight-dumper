using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public interface IUGCTimelineEditorManager
{
	List<IUGCTimelineEditorTrackBaseWarp> Tracks { get; }

	string Name { get; }

	string AssetID { get; }

	float Duration { get; }

	int FrameRate { get; }

	int Mode { get; }

	float Zoom { get; }

	int Unit { get; }

	bool Serialized();

	void Deserialize();

	void Load(CAIDHLFFJDP editorAsset, PAEHKPKMJKN runtimeAsset);

	void UnLoad();

	void Destroy();

	void Play();

	void SlowGoToTime(float newTime);

	void Stop();

	void Pause();

	bool HasTrack(string entityID);
}
