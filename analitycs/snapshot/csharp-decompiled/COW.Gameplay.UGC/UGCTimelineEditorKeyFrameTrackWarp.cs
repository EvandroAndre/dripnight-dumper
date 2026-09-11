using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorKeyFrameTrackWarp : UGCTimelineEditorTrackBaseWarp
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

	public void AddOrUpdateQuaternionPropertyKeyFrame(UGCTimelineEditorKeyFrame editKeyFrame, int propID, string propertyName, MHJLOKOOGNB type, Vector3 value, bool refreshPreview = true)
	{
	}

	public void AddOrUpdateVector3PropertyKeyFrame(UGCTimelineEditorKeyFrame editKeyFrame, int propID, string propertyName, MHJLOKOOGNB type, Vector3 value, bool refreshPreview = true)
	{
	}

	public void AddOrUpdatePropertyKeyFrame(UGCTimelineEditorKeyFrame editKeyFrame, int propID, string propertyName, MHJLOKOOGNB type, MutableValue value, bool refreshPreview = true)
	{
	}

	private void AddOrUpdatePropertyKeyFrame(UGCTimelineEditorKeyFrame editKeyFrame, int propID, string propertyName, MHJLOKOOGNB type, UGCVarValueDataV2 data, bool refreshPreview = true)
	{
	}
}
