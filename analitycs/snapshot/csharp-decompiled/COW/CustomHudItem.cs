using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class CustomHudItem : MonoBehaviour
{
	public UIEventListener m_EventListener;

	public string m_HudName;

	public UISprite m_LockIcon;

	public UISprite m_Hidden;

	public UIWidget m_BG;

	public bool m_Circle;

	public UI2DSprite m_2dSprite;

	public int OnlyGameMode;

	public string GameModeHideHud;

	public List<CustomHudReloadSprite> NeedReloadSprite;

	protected virtual void Awake()
	{
	}

	protected virtual void OnHudPress(GameObject go, bool state)
	{
	}

	protected virtual void OnHudDragStart(GameObject go)
	{
	}

	protected virtual void OnHudDragEnd(GameObject go)
	{
	}

	protected virtual void OnLostFocus()
	{
	}

	protected virtual void OnFocus()
	{
	}

	public void LostFocus()
	{
	}

	public void Focus()
	{
	}
}
