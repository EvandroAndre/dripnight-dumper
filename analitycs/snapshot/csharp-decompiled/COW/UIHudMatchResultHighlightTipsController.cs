using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudMatchResultHighlightTipsController : UIBaseController
{
	private UIHudMatchResultHighlightTipsView m_View;

	private ulong m_MatchId;

	private EHighlightDisplayType m_DisplayType;

	private Action m_PlayAction;

	private uint m_RestartUIFXDelayCallId;

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

	public void SetView(ulong matchId = 0uL, EHighlightDisplayType displayType = EHighlightDisplayType.VideoInMatchResult, uint posterCommentsId = 0u)
	{
	}

	private void SetUIFXActiveByDisplayType(EHighlightDisplayType displayType)
	{
	}

	private void OnMatchResultMainUIShown(object[] data)
	{
	}

	private bool ShouldReplayUIFXOnMatchResultShown()
	{
		return false;
	}

	private void RestartUIFX()
	{
	}

	private void DelayRestartUIFX()
	{
	}

	private string GetHighlightPhotoTypeLogDetail(List<AlbumPhotoInfo> highlightPhotos)
	{
		return null;
	}

	private EHighLightPlayType GetHighestPriorityPhotoHighlightType(List<AlbumPhotoInfo> highlightPhotos, out uint killCount)
	{
		killCount = default(uint);
		return EHighLightPlayType.None;
	}

	private string GetPhotoHighlightLabel(EHighLightPlayType highlightType, uint killCount)
	{
		return null;
	}

	private string FormatHighlightCount(uint killCount)
	{
		return null;
	}

	private string FormatGetHighlightShowLabel(BaseHighlightInfo info, EHighLightPlayType highLightPlayType)
	{
		return null;
	}

	public void SetPlayAction(Action playAction)
	{
	}

	private void OnPlayBtnClick()
	{
	}

	private void PlaySingleHighlightWithScreenShot()
	{
	}

	private void PlaySingleHighlight()
	{
	}

	public UIWidget GetVideoWindowWidget()
	{
		return null;
	}

	private void AdjustNoIcon()
	{
	}

	private void _003CPlaySingleHighlightWithScreenShot_003Eb__21_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
