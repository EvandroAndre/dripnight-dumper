using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIGameModeGameplayAffixDetailsDropdownController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public bool flag;

		public TweenPosition target1;

		public Transform pos2;

		public Transform pos1;

		public TweenPosition target2;

		public Transform pos3;

		internal void _003CStartProtectLabelCarouselTween_003Eb__0()
		{
		}
	}

	private const float m_EnterFromPreviewVfxDurationSecs = 5f;

	private bool m_Collapsed;

	private NIKKALKPIBO m_GameMode;

	private DLBMPCCFKKM m_MatchMode;

	private uint m_ProtectLabelCarouselDelayCall;

	private UIGameModeGameplayAffixDetailsDropdownView m_View;

	private VisualInstanceHolder m_EnterFromPreviewVfxHolder;

	private readonly List<UIGameModeGameplayAffixDetailsDropdownItemController> m_DropdownItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private IFixTimeCarouselItem CarouselItemControllerGenerator(Transform carouselContainer)
	{
		return null;
	}

	private void CollapseExpandDropdownInternal(bool collapse)
	{
	}

	private void SetupDefaultState()
	{
	}

	private void SetProgressView()
	{
	}

	private void RefreshProgressView()
	{
	}

	private void PrepareFixTimeCarousel()
	{
	}

	private void PlayFixTimeCarousel(GameplayAffixEventData gameplayAffixEventData)
	{
	}

	private void RefreshTimeRange(GameplayAffixEventData gameplayAffixEventData)
	{
	}

	private void RefreshScrollViewDragRegion()
	{
	}

	private void Repopulate(GameplayAffixEventData gameplayAffixEventData)
	{
	}

	private void RefreshContentInternal()
	{
	}

	private void ReleaseAllVfxInstances()
	{
	}

	public void TryStopProtectLabelCarousel()
	{
	}

	private void StartProtectLabelCarouselTween(TweenPosition target1, TweenPosition target2, Transform pos1, Transform pos2, Transform pos3)
	{
	}

	private void RefreshProtectLabelCarousel()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void OnScrollViewDragRegionBtnClick()
	{
	}

	private void OnDropdownBtnClick()
	{
	}

	public void AdjustPanelDepthWithBase(int dropdownBaseDepth)
	{
	}

	public void SetViewData(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
	}

	public void RefreshContent()
	{
	}

	public void CollapseDropdown()
	{
	}

	public void PlayEnterFromPreviewEffect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
