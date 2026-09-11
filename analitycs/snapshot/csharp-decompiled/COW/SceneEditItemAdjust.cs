using UnityEngine;

namespace COW;

public static class SceneEditItemAdjust
{
	public enum ButtonState : ulong
	{
		None = 0uL,
		Attribute = 1uL,
		Move = 2uL,
		Tangent = 4uL,
		Scale = 8uL,
		Rotate = 0x10uL,
		Copy = 0x20uL,
		Delete = 0x40uL,
		Save = 0x80uL,
		FPV = 0x100uL,
		AddSubTrack = 0x200uL,
		AddTrack = 0x400uL,
		AddKeyFrame = 0x800uL,
		DeleteTrack = 0x1000uL,
		DelKeyFrame = 0x2000uL,
		TimelineSetting = 0x4000uL,
		AddKeyClip = 0x8000uL,
		DelKeyClip = 0x10000uL,
		Group = 0x20000uL,
		Ungroup = 0x40000uL
	}

	public enum State
	{
		Normal,
		Highlight,
		Disable
	}

	public static readonly Color HIGHLIGHT_COLOR;

	public static readonly Color NORMAL_COLOR;

	public static readonly Color DISABLE_COLOR;

	public static ButtonState SetStateActive(ButtonState state, ButtonState flag, bool enabled)
	{
		return ButtonState.None;
	}

	public static bool IsStateActive(ButtonState state, ButtonState flag)
	{
		return false;
	}

	internal static int GetButtonIndex(EAdjustType adjustType)
	{
		return 0;
	}
}
