using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public static class PlayGamesInputSDK
{
	public enum AndroidKeyCode
	{
		Num0 = 7,
		Num9 = 16,
		A = 29,
		Z = 54,
		F1 = 131,
		F12 = 142,
		NumPad0 = 144,
		NumPad9 = 153,
		Star = 17,
		Pound = 18,
		DpadUp = 19,
		DpadDown = 20,
		DpadLeft = 21,
		DpadRight = 22,
		Comma = 55,
		Period = 56,
		LeftAlt = 57,
		RightAlt = 58,
		LeftShift = 59,
		RightShift = 60,
		Tab = 61,
		Space = 62,
		Enter = 66,
		Del = 67,
		Grave = 68,
		Minus = 69,
		Equals = 70,
		LeftBracket = 71,
		RightBracket = 72,
		BackSlash = 73,
		SemiColon = 74,
		Apostrophe = 75,
		Slash = 76,
		At = 77,
		Plus = 81,
		PageUp = 92,
		PageDown = 93,
		Escape = 111,
		ForwardDel = 112,
		LeftCtrl = 113,
		RightCtrl = 114,
		CapsLock = 115,
		ScrollLock = 116,
		Break = 121,
		MoveHome = 122,
		MoveEnd = 123,
		Insert = 124,
		NumLock = 143,
		NumPadDivide = 154,
		NumPadMultiply = 155,
		NumPadSubstract = 156,
		NumPadAdd = 157,
		NumPadDot = 158,
		NumPadComma = 159,
		NumPadEnter = 160,
		NumPadEquals = 161,
		NumPadLeftParen = 162,
		NumPadRightParen = 163
	}

	public enum AndroidMouseActions
	{
		RightClick = 1,
		TertiaryClick,
		ForwardClick,
		BackClick,
		ScrollUp,
		ScrollDown,
		Movement,
		LeftDrag,
		RightDrag,
		LeftClick
	}

	[Serializable]
	public class UnityInputControls
	{
		public int[] KeyCodes;

		public int[] MouseActions;
	}

	[Serializable]
	public class UnityInputAction
	{
		public string ActionLabel;

		public int UniqueId;

		public UnityInputControls InputControls;
	}

	[Serializable]
	public class UnityInputGroup
	{
		public class Builder
		{
			private Dictionary<string, UnityInputAction> _InputActions;

			public UnityInputGroup Build()
			{
				return null;
			}

			public Builder Set(string actionLabel, UnityInputAction inputAction)
			{
				return null;
			}
		}

		public string GroupLabel;

		public UnityInputAction[] InputActions;

		private UnityInputGroup()
		{
		}
	}

	[Serializable]
	public class UnityMouseSettings
	{
		public bool InvertMouseMovement;

		public bool AllowMouseSensitivityAdjustment;
	}

	[Serializable]
	public class UnityInputMap
	{
		public class Builder
		{
			[Serializable]
			private sealed class _003C_003Ec
			{
				public static readonly _003C_003Ec _003C_003E9;

				public static Converter<KeyCode, int> _003C_003E9__2_0;

				public static Converter<AndroidMouseActions, int> _003C_003E9__2_1;

				internal int _003CSet_003Eb__2_0(KeyCode unityKeyCode)
				{
					return 0;
				}

				internal int _003CSet_003Eb__2_1(AndroidMouseActions androidMouseAction)
				{
					return 0;
				}
			}

			private Dictionary<string, UnityInputGroup.Builder> _InputGroups;

			public UnityInputMap Build()
			{
				return null;
			}

			public Builder Set(string groupLabel, string actionLabel, KeyCode[] unityKeyCodes, AndroidMouseActions[] androidMouseActions)
			{
				return null;
			}
		}

		public UnityInputGroup[] InputGroups;

		public UnityMouseSettings MouseSettings;

		private UnityInputMap()
		{
		}
	}

	private static Dictionary<int, int> KeyCode_UnityToAndroid;

	private static AndroidJavaClass _InputSDKManager;

	static PlayGamesInputSDK()
	{
	}

	public static void ClearInputMapping()
	{
	}

	public static void UpdateInputMapping(UnityInputMap unityInputMap)
	{
	}
}
