using System.Collections.Generic;
using COW;
using UnityEngine;

namespace GCommon;

public class UIPopupWindowController : UIBaseController
{
	protected UIBaseNavigationController m_NavigationController;

	protected List<UITweener> m_PopupTweener;

	protected UIPanel m_MainPanel;

	protected UIPanel[] m_ChildPanels;

	public UIPopWindowFrameStyle m_frameStyle;

	protected UIPopupGlassBG m_Glass;

	public UIGlassBGController GlassCtrl;

	protected bool m_IsCoverSparkPet;

	protected bool m_IsCoverPrePopWnd;

	protected bool m_IsCoverFullscreen;

	private bool m_IsIndependentDepth;

	protected int m_TargetDepth;

	public virtual string Rule()
	{
		return null;
	}

	public virtual bool OverrideRuleBtnClick()
	{
		return false;
	}

	public virtual string CustomTitle()
	{
		return null;
	}

	public virtual int GlassDelay()
	{
		return 0;
	}

	public virtual int MinGroupDepth()
	{
		return 0;
	}

	public virtual bool EnablePlayTweenAminAgain()
	{
		return false;
	}

	protected virtual string AnimationConfogPath()
	{
		return null;
	}

	protected virtual void OnTweenAnimationFinish()
	{
	}

	protected virtual bool UseCustomizedAnimation()
	{
		return false;
	}

	public virtual void BeforeForceClose()
	{
	}

	public UIPopupWindowTopBtnController ShowCloseBtn(EventDelegate.Callback action)
	{
		return null;
	}

	protected override void Awake()
	{
	}

	protected virtual ResourceID GetFrameResourceId()
	{
		return default(ResourceID);
	}

	public virtual bool NeedSetLobbyObjectVisibleState()
	{
		return false;
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void InitDepth(int startDepth)
	{
	}

	protected virtual void OnInitDepth()
	{
	}

	public void SetTitleKey(string key)
	{
	}

	public void SetNavigationController(UIBaseNavigationController navigationController)
	{
	}

	protected virtual void OnSetNavigationController()
	{
	}

	public void AddTweenByConfig(UIPanel mainPanel)
	{
	}

	public void DisableTween()
	{
	}

	public void EnableTweenAnimAgian()
	{
	}

	public int GetMainPanelDepth()
	{
		return 0;
	}

	public int GetMaxPanelDepth()
	{
		return 0;
	}

	public void IncreasePanelDepth(uint incrementDepth)
	{
	}

	public void SetIndependentDepth()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override T OpenChildController<T>(Transform parent, Vector3 localPosition = default(Vector3), EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
	{
		return null;
	}

	protected override void OnChildControllerOpenChildController()
	{
	}

	public virtual bool ClosedByEsc()
	{
		return false;
	}

	public virtual bool IgnoreEsc()
	{
		return false;
	}

	public virtual void EnterByReturn()
	{
	}

	public void SetColliderMaskAlpha(UISprite mask, float alpha = 0f)
	{
	}

	public bool HasGlassEnabledInPopupWindowList()
	{
		return false;
	}

	public virtual void OnPopupWindowListChange()
	{
	}

	public bool IsCoverPrePopupWnd()
	{
		return false;
	}

	public bool IsCoverSparkPet()
	{
		return false;
	}

	public bool IsCoveredByPopupWnd()
	{
		return false;
	}

	public bool IsCoverFullscreen()
	{
		return false;
	}

	public virtual void OnNavigationBack()
	{
	}

	public virtual void OnNavigationClosed()
	{
	}

	public virtual void AfterPopupGlassBgReady()
	{
	}

	public void HideFrame()
	{
	}
}
