using System.Collections.Generic;
using message;

namespace GCommon;

internal class UGCInputSystemActionHandler
{
	public class KeyInfo
	{
		public string KeyCode;

		public string CustomButton;

		public CDEBKCBLKKO UGCKeyState;

		public KeyInfo(string keyCode, string customButton, CDEBKCBLKKO keyState)
		{
		}
	}

	public static HashSet<string> BlockedKey;

	private Dictionary<uint, List<KeyInfo>> m_Action2KeyStateMapping;

	private HashSet<uint> m_ActionOverride;

	private HashSet<string> m_KeyOverride;

	public bool IsKeyOverride(string key)
	{
		return false;
	}

	public bool Update()
	{
		return false;
	}

	public bool IsButtonDown(string key, bool skipCheck = false)
	{
		return false;
	}

	public bool IsButtonReleased(string key, bool skipCheck = false)
	{
		return false;
	}

	public bool IsButtonPressed(string key, bool skipCheck = false)
	{
		return false;
	}

	public bool IsActionAcitve(KPAEFNMDJKE action)
	{
		return false;
	}

	public void OnDestroy()
	{
	}
}
