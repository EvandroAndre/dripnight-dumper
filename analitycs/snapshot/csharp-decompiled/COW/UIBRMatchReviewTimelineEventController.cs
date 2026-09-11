using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewTimelineEventController : UIBaseController
{
	public enum ETimelineMarkerType
	{
		Airline,
		ZoneShrink
	}

	private UIBRMatchReviewTimelineEventView m_View;

	private long m_TimeMs;

	private readonly List<UIWidget> m_DepthWidgets;

	private readonly List<int> m_OriginalDepths;

	public Action<long> OnMarkerClicked;

	private const float SELF_EVENT_SCALE = 1.2f;

	private const string SpriteResKill = "UI_Review_icon_Event_Kill";

	private const string SpriteResDeath = "UI_Icon_Deathbox";

	private const string SpriteResRevive = "UI_Icon_BrReview_Resurrection";

	private const string SpriteResTeamWipeout = "UI_Icon_TeamWipeout";

	private const string SpriteResSpecialAirdrop = "UI_Icon_BrReview_Airdrop";

	private const string SpriteResSpecialVault = "UI_Icon_BrReview_Treasury";

	private const string SpriteResSpecialEnergyDevice = "UI_Icon_BrReview_Energydevice";

	private const string SpriteResSpecialActivity = "FF_Ui_Mission";

	private const string SpriteLowerAirline = "UI_Review_icon_Event01";

	private const string SpriteLowerZoneShrink = "UI_Review_icon_Event02";

	private const string SpriteResBooyah = "UI_Profile_Highlight_Booyah";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnRecycleUIGameObject()
	{
	}

	public void SetUpperEvent(HJNFDCJPPDE eventData, bool isSelfEvent, Color bubbleTint)
	{
	}

	public void SetLowerEvent(ETimelineMarkerType markerType, long timeMs)
	{
	}

	public void SetPositionX(float localX)
	{
	}

	public void SetDepthOffset(int offset)
	{
	}

	private void CacheOriginalWidgetDepths()
	{
	}

	private void RestoreOriginalWidgetDepths()
	{
	}

	private void OnButtonClicked()
	{
	}

	private static void ApplyUpperBubbleSprite(UISprite bubble, Color tint)
	{
	}

	private void ApplyUpperMainIcon(UISprite target, HJNFDCJPPDE eventData)
	{
	}

	private static string GetSpecialEventSpriteName(PHOPGMDJODO subType)
	{
		return null;
	}

	private void ApplyLowerMainIcon(ETimelineMarkerType markerType)
	{
	}

	private static void ApplySprite(UISprite target, string spriteName, UIUtils.SpriteScaleType scaleType)
	{
	}

	private static void ClearSprite(UISprite target)
	{
	}

	private void RefreshKillMergeCountUI(HJNFDCJPPDE eventData)
	{
	}

	private static bool TryGetMergedKillCount(HJNFDCJPPDE eventData, out int killCount)
	{
		killCount = default(int);
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycleUIGameObject()
	{
	}
}
