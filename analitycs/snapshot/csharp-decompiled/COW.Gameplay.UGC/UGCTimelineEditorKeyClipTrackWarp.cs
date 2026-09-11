namespace COW.Gameplay.UGC;

public class UGCTimelineEditorKeyClipTrackWarp : UGCTimelineEditorTrackBaseWarp
{
	public override bool TryGetScopeKeyFrame(float time, float scope, out UGCTimelineEditorKeyBase keyFrameData)
	{
		keyFrameData = null;
		return false;
	}

	public override bool TryGetKeyFrame(float time, out UGCTimelineEditorKeyBase keyFrameData)
	{
		keyFrameData = null;
		return false;
	}

	public bool AddOrUpdateArgumentKeyClip(UGCTimelineEditorKeyClip keyClip, string argumentName, string type, MutableValue value)
	{
		return false;
	}
}
