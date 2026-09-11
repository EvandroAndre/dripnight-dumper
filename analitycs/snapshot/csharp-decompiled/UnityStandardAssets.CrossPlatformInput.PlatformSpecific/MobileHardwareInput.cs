using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific;

public class MobileHardwareInput : VirtualInput
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__0_0;

		public static Action<string> _003C_003E9__0_1;

		internal void _003C_002Ector_003Eb__0_0(string str)
		{
		}

		internal void _003C_002Ector_003Eb__0_1(string str)
		{
		}
	}

	~MobileHardwareInput()
	{
	}

	public override float GetAxis(string name, bool raw)
	{
		return 0f;
	}

	public override bool GetButton(string name)
	{
		return false;
	}

	public override bool GetButtonDown(string name)
	{
		return false;
	}

	public override bool GetButtonUp(string name)
	{
		return false;
	}

	public override void SetButtonDown(string name)
	{
	}

	public override void SetButtonUp(string name)
	{
	}

	public override void SetAxisPositive(string name)
	{
	}

	public override void SetAxisNegative(string name)
	{
	}

	public override void SetAxisZero(string name)
	{
	}

	public override void SetAxis(string name, float value)
	{
	}

	public override Vector3 MousePosition()
	{
		return default(Vector3);
	}

	public override bool GetKeyCodeButton(KeyCode kc)
	{
		return false;
	}
}
