using UnityEngine;

namespace COW;

public class UIhudCSTechPointView : MonoBehaviour
{
	public UISprite StateAlive;

	public UISprite StateDefault;

	private static string m_ActiveIconDefault;

	private static string m_InactiveIconDefault;

	private static Color m_ActiveIconColorDefault;

	private static Color m_InactiveIconColorDefault;

	private static int m_ActiveIconHeight;

	private static int m_InactiveIconHeight;

	public static void RecordDefaultSkinInfo(UIhudCSTechPointView view)
	{
	}

	public void SetSkin(bool setToDefault = false)
	{
	}

	public void SetActive(bool value, bool active)
	{
	}
}
