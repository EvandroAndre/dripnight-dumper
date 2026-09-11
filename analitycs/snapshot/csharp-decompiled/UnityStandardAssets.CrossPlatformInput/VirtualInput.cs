using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput;

public abstract class VirtualInput
{
	private Vector3 _003CvirtualMousePosition_003Ek__BackingField;

	protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

	protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

	protected List<string> m_AlwaysUseVirtual;

	public Vector3 virtualMousePosition
	{
		get
		{
			return _003CvirtualMousePosition_003Ek__BackingField;
		}
		private set
		{
			_003CvirtualMousePosition_003Ek__BackingField = value;
		}
	}

	public bool AxisExists(string name)
	{
		return false;
	}

	public bool ButtonExists(string name)
	{
		return false;
	}

	public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
	{
	}

	public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
	{
	}

	public void UnRegisterVirtualAxis(string name)
	{
	}

	public void UnRegisterVirtualButton(string name)
	{
	}

	public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
	{
		return null;
	}

	public CrossPlatformInputManager.VirtualButton VirtualButtonReference(string name)
	{
		return null;
	}

	public void SetVirtualMousePositionX(float f)
	{
	}

	public void SetVirtualMousePositionY(float f)
	{
	}

	public void SetVirtualMousePositionZ(float f)
	{
	}

	public virtual void SetButtonClick(string name)
	{
	}

	public virtual void UseClicked(string name)
	{
	}

	public abstract float GetAxis(string name, bool raw);

	public abstract bool GetButton(string name);

	public abstract bool GetButtonDown(string name);

	public abstract bool GetButtonUp(string name);

	public abstract void SetButtonDown(string name);

	public abstract void SetButtonUp(string name);

	public abstract void SetAxisPositive(string name);

	public abstract void SetAxisNegative(string name);

	public abstract void SetAxisZero(string name);

	public abstract void SetAxis(string name, float value);

	public abstract Vector3 MousePosition();

	public abstract bool GetKeyCodeButton(KeyCode kc);
}
