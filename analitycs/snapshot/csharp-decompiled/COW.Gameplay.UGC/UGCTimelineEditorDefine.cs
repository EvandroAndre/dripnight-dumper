using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCTimelineEditorDefine
{
	public enum ClipLoopType
	{
		None,
		Once,
		Hold,
		Loop,
		LoopForever
	}

	public enum EAvatarType
	{
		Female = 1,
		Male,
		Pet
	}

	public enum RelationType
	{
		MainTrack = 1,
		ChildTrack
	}

	public enum KeyFrameType
	{
		Key = 1,
		Clip
	}

	public const float PerUnitWidth = 100f;

	public const int PROPID_LOCAL_POSITION = -97005;

	public const int PROPID_LOCAL_ROTATION = -97007;

	public const int PROPID_LOCAL_SCALE = -97008;

	public const int TIMELINE_TIME_ID = 1;

	public const int TIMELINE_DURATION_ID = 2;

	public static Color INCREASE_TIME_COLOR;

	public static Color DECREASE_TIME_COLOR;

	public static Color SIDE_BAR_SELECTED_COLOR;
}
