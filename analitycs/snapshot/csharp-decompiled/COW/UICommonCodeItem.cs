using System;
using GCommon;
using UnityEngine;

namespace COW;

internal class UICommonCodeItem : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public Action<object> callback;

		public UICommonCodeItem _003C_003E4__this;

		internal void _003CSetUIData_003Eb__0()
		{
		}
	}

	public UIToggleButton Toggle;

	public UILabel Code;

	public UISprite IconSprite;

	public UISprite BgSprite;

	private int m_Index;

	public static int INPUT_DELETE_INDEX;

	public static int INPUT_ZERO_INDEX;

	public static int INPUT_CONFIRM_INDEX;

	private const uint CODE_BG_COLOR = 3705265151u;

	private const uint ICON_BG_COLOR = 4290380031u;

	private const uint ICON_BG_COLOR_DISABLE = 2456420607u;

	public void SetUIData(int index, Action<object> callback = null)
	{
	}

	public static string GetInputCodeString(int index)
	{
		return null;
	}

	public void ButtonColorHL(bool v)
	{
	}
}
