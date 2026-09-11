using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput;

public static class CrossPlatformInputManager
{
	public enum ActiveInputMethod
	{
		Hardware,
		Touch,
		MobileHardware
	}

	public class VirtualAxis
	{
		private string _003Cname_003Ek__BackingField;

		private float m_Value;

		private bool _003CmatchWithInputManager_003Ek__BackingField;

		public string name
		{
			get
			{
				return _003Cname_003Ek__BackingField;
			}
			private set
			{
				_003Cname_003Ek__BackingField = value;
			}
		}

		public bool matchWithInputManager
		{
			get
			{
				return _003CmatchWithInputManager_003Ek__BackingField;
			}
			private set
			{
				_003CmatchWithInputManager_003Ek__BackingField = value;
			}
		}

		public float GetValue => 0f;

		public float GetValueRaw => 0f;

		public VirtualAxis(string name)
		{
		}

		public VirtualAxis(string name, bool matchToInputSettings)
		{
		}

		public void Remove()
		{
		}

		public void Update(float value)
		{
		}
	}

	public class VirtualButton
	{
		private string _003Cname_003Ek__BackingField;

		private bool _003CmatchWithInputManager_003Ek__BackingField;

		private int m_LastPressedFrame;

		private int m_ReleasedFrame;

		private bool m_Pressed;

		private bool m_PressedDirty;

		private bool m_Clicked;

		private bool m_UseClicked;

		public string name
		{
			get
			{
				return _003Cname_003Ek__BackingField;
			}
			private set
			{
				_003Cname_003Ek__BackingField = value;
			}
		}

		public bool matchWithInputManager
		{
			get
			{
				return _003CmatchWithInputManager_003Ek__BackingField;
			}
			private set
			{
				_003CmatchWithInputManager_003Ek__BackingField = value;
			}
		}

		public bool GetButton => false;

		public bool PressDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Clicked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseClicked
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GetButtonDown => false;

		public bool GetButtonUp => false;

		public VirtualButton(string name)
		{
		}

		public VirtualButton(string name, bool matchToInputSettings)
		{
		}

		public void Pressed()
		{
		}

		public void Released()
		{
		}

		public void Remove()
		{
		}
	}

	private static VirtualInput activeInput;

	private static VirtualInput s_TouchInput;

	private static VirtualInput s_HardwareInput;

	private static VirtualInput s_MobileHardwareInput;

	private static ActiveInputMethod _003CCurActiveInputMethod_003Ek__BackingField;

	private static int _003CLastButtonChangedFc_003Ek__BackingField;

	public static bool ForceCheckButtonChange;

	public static ActiveInputMethod CurActiveInputMethod
	{
		get
		{
			return _003CCurActiveInputMethod_003Ek__BackingField;
		}
		private set
		{
			_003CCurActiveInputMethod_003Ek__BackingField = value;
		}
	}

	public static int LastButtonChangedFc
	{
		get
		{
			return _003CLastButtonChangedFc_003Ek__BackingField;
		}
		private set
		{
			_003CLastButtonChangedFc_003Ek__BackingField = value;
		}
	}

	public static Vector3 mousePosition => default(Vector3);

	static CrossPlatformInputManager()
	{
	}

	public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
	{
	}

	public static bool AxisExists(string name)
	{
		return false;
	}

	public static bool ButtonExists(string name)
	{
		return false;
	}

	public static void RegisterVirtualAxis(VirtualAxis axis)
	{
	}

	public static void RegisterVirtualButton(VirtualButton button)
	{
	}

	public static void UnRegisterVirtualAxis(string name)
	{
	}

	public static void UnRegisterVirtualButton(string name)
	{
	}

	public static VirtualAxis VirtualAxisReference(string name)
	{
		return null;
	}

	public static VirtualButton VirtualButtonReference(string name)
	{
		return null;
	}

	public static float GetAxis(string name)
	{
		return 0f;
	}

	public static float GetAxisRaw(string name)
	{
		return 0f;
	}

	private static float GetAxis(string name, bool raw)
	{
		return 0f;
	}

	public static bool GetButton(string name)
	{
		return false;
	}

	public static bool GetButtonDown(string name)
	{
		return false;
	}

	public static bool GetButtonUp(string name)
	{
		return false;
	}

	public static void SetButtonDown(string name)
	{
	}

	public static void SetButtonUp(string name)
	{
	}

	public static void SetButtonClick(string name)
	{
	}

	public static void UseButtonClick(string name)
	{
	}

	public static bool GetKeyCodeButton(KeyCode kc)
	{
		return false;
	}

	public static void SetAxisPositive(string name)
	{
	}

	public static void SetAxisNegative(string name)
	{
	}

	public static void SetAxisZero(string name)
	{
	}

	public static void SetAxis(string name, float value)
	{
	}

	public static void SetVirtualMousePositionX(float f)
	{
	}

	public static void SetVirtualMousePositionY(float f)
	{
	}

	public static void SetVirtualMousePositionZ(float f)
	{
	}
}
