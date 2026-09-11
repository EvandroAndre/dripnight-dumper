using System;
using UnityEngine;

namespace COW;

public class UILoginButton : MonoBehaviour
{
	public class LoginButtionData
	{
		public string name;

		public Action callback;

		public uint normalColor;

		public uint hoverColor;

		public uint pressedColor;

		public string platformName;

		public uint nameTint;

		public string icon;

		public Vector2 iconSize;

		public uint iconTint;

		public uint lightTint;
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public LoginButtionData data;

		internal void _003CSetData_003Eb__0()
		{
		}
	}

	public UIButton button;

	public UILabel platformName;

	public UISprite platformIcon;

	public UISprite light;

	public void SetData(LoginButtionData data)
	{
	}

	public void SetEnable(bool enable)
	{
	}
}
