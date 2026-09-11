using System;
using System.Collections.Generic;

namespace GCommon;

public class UIBaseNavigationController : UIBaseController
{
	protected UINavigationData m_NavigationData;

	protected bool m_IsRoot;

	protected bool m_IsNavigationShowed;

	protected List<UIPopupWindowController> m_PopupWindows;

	protected bool m_WillBeClose;

	public bool IsOpenVerticalPopWnd;

	public bool WillBeClose
	{
		set
		{
		}
	}

	public bool IsRoot => false;

	public UINavigationData NavigationData => null;

	public virtual bool NavigationCanAccess()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public void OnForceBlurBg()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public virtual void OnNavigationShowed(UINavigationData navigationData, bool isRoot)
	{
	}

	public virtual void OnNavigationClosed()
	{
	}

	public virtual void OnWillPopToNavigation(Type targetType, UIBaseNavigationController previousNavigation)
	{
	}

	public void ShowPopupWindow(UIPopupWindowController popupWindow)
	{
	}

	public List<UIPopupWindowController> GetPopupWindows()
	{
		return null;
	}

	public void OnPopupWindowDepthIncrease(UIPopupWindowController popupWindow, uint increaseDepth)
	{
	}

	public void OnPopupWindowClose(UIPopupWindowController popupWindow)
	{
	}

	protected virtual void OnPopupWindowListChange()
	{
	}

	public void CloseAllPopupWindows()
	{
	}

	public virtual void OnCloseAllPopupWindows()
	{
	}

	public bool HasPopupWindowsByType(Type popupType)
	{
		return false;
	}

	public void ClosePopupWindowsByType(Type popupType)
	{
	}

	public UIPopupWindowController TopPopupWindows()
	{
		return null;
	}

	public bool HasGlassEnabledInPopupWindowList(UIPopupWindowController popupWnd)
	{
		return false;
	}

	protected virtual bool IsCoveredByPopupWnd()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}
}
