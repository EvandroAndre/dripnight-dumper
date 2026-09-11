using System.Collections.Generic;

namespace GCommon;

internal class UGCVirtualInputManager : SingletonModule<UGCVirtualInputManager>
{
	private Dictionary<string, UGCVirtualButton> m_VirtualButtons;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void RegisterUGCVitualButton(string name)
	{
	}

	public void UnRegisterUGCVitualButton(string name)
	{
	}

	public bool Tick()
	{
		return false;
	}

	public void Press(string name)
	{
	}

	public void Release(string name)
	{
	}

	public bool IsButtonDown(string key)
	{
		return false;
	}

	public bool IsButtonReleased(string key)
	{
		return false;
	}

	public bool IsButtonPressed(string key)
	{
		return false;
	}
}
