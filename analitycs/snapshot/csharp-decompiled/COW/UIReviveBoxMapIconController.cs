using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIReviveBoxMapIconController : UIManagedLevelObjectMapIconController
{
	private const float IconSize = 70f;

	private const float IconHalfSize = 35f;

	private const float SideArrowRotateBottom = 0f;

	private const float SideArrowRotateRight = 90f;

	private const float SideArrowRotateTop = 180f;

	private const float SideArrowRotateLeft = 270f;

	private const float HighlightUIFXDuration = 1f;

	private const float SideArrowMarkDuration = 2f;

	private const string ReviveBoxProgressParam = "Progress";

	private UIReviveBoxMapIconView m_View;

	private UIReviveBoxMapIconViewData m_ViewData;

	private VisualInstanceHolder m_UIFXHolder;

	private VisualInstanceHolder m_UIFXHighlightHolder;

	private Animator m_UIFXAnimator;

	private float m_SelfRemainingPercent;

	private uint m_UIFXHighlightReleaseDelayID;

	private uint m_SideArrowMarkDelayID;

	private bool m_SideArrowMarkActive;

	private Vector3 m_DefaultMainLocalPosition;

	private bool m_IsIconVisible;

	private bool m_HasTeammateInfo;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override bool KeepRotationUp()
	{
		return false;
	}

	public override bool KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public override bool IsMarkingSupported()
	{
		return false;
	}

	public override OPICPDCLKAG GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public override EILKGGIDJEH GetMarkPointType()
	{
		return EILKGGIDJEH.EItemMarkPointType_Location;
	}

	public override void SetViewData(object viewData)
	{
	}

	public override void OnTrackedPlayerChanged(BHGGAEEHJCO trackedPlayer)
	{
	}

	public override bool IconBoundsContainsPos(Vector3 position)
	{
		return false;
	}

	protected override Bounds? GetIconBounds()
	{
		return null;
	}

	protected override void RestoreBeforeRecycled()
	{
	}

	public void PlayHighlightUIFX(ResourceID resID)
	{
	}

	private void ActivateSideArrowMark()
	{
	}

	private void DeactivateSideArrowMarkByDelay()
	{
	}

	private void DeactivateSideArrowMark()
	{
	}

	private void Update()
	{
	}

	private void SetupDefaultState()
	{
	}

	private void StartUIFX()
	{
	}

	private void OnUIFXAttached(GameObject instance)
	{
	}

	private void ReleaseUIFX()
	{
	}

	private void ReleaseHighlightUIFXByDelay()
	{
	}

	private void ReleaseHighlightUIFX()
	{
	}

	private bool ShouldShowIcon()
	{
		return false;
	}

	private void RefreshTeammateInfo()
	{
	}

	private void UpdateIcon()
	{
	}

	private void UpdateProgress()
	{
	}

	private void SetIconVisible(bool visible)
	{
	}

	private void UpdateSideArrow()
	{
	}

	private void ApplySideArrowRotation(Vector3 iconWorldPosition, float clampedX, float clampedY)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new bool _003C_003EiFixBaseProxy_KeepRotationUp()
	{
		return false;
	}

	public new bool _003C_003EiFixBaseProxy_KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsMarkingSupported()
	{
		return false;
	}

	public OPICPDCLKAG _003C_003EiFixBaseProxy_GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public EILKGGIDJEH _003C_003EiFixBaseProxy_GetMarkPointType()
	{
		return EILKGGIDJEH.EItemMarkPointType_Location;
	}

	public new void _003C_003EiFixBaseProxy_SetViewData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTrackedPlayerChanged(BHGGAEEHJCO P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IconBoundsContainsPos(Vector3 P0)
	{
		return false;
	}

	public Bounds? _003C_003EiFixBaseProxy_GetIconBounds()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RestoreBeforeRecycled()
	{
	}
}
