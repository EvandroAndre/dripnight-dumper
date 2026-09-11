using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UavMapObject
{
	public class UavPoint
	{
		public UISprite Sprite;

		public TweenAlpha TweenAlpha;

		public Transform SpriteTrans;
	}

	private const float UI_CIRCLE_FILL_RATIO = 0.9f;

	private const float UI_PLAYER_CNT_OFFSET = -10f;

	private LevelUAV m_Uav;

	public UIUAVMapObjectView m_UavObjectView;

	private float m_UavFadeStartTime;

	private float m_UavFadeEndTime;

	private float m_UavFadeTime;

	public List<UavPoint> m_UavPoints;

	private bool m_KeepUavIconUp;

	private float m_Scale;

	private float m_RangeOnMap;

	private float m_RangeExtendedOnMap;

	private float m_UAVRange;

	private float m_UAVRangeExtended;

	private float m_UAVPointTweenDurationExtension;

	private Transform m_MapContainer;

	public UISprite m_UavPoint;

	private TweenAlpha m_PlayerTween;

	private TweenScale m_CircleTween;

	public UISprite m_Circle;

	public UISprite m_CircleExtneded;

	private int m_LastUpdateFrame;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private static bool m_IgnoreSubsequentLocalPlayerReveal;

	private bool m_ShowPlayerCnt;

	private float m_UAVRevealTime;

	protected BitArrayBoolean m_OrVisible;

	protected BitArrayBoolean m_Visible;

	protected const uint ISVISIBLE_ALL = 1u;

	protected const uint ISVISIBLE_FRIENDLY = 2u;

	protected const uint ISVISIBLE_REVEAL = 8u;

	protected const uint ISVISIBLE_ALWAYS_SHOWN = 16u;

	protected const uint VISIBLE_OR = 1u;

	protected const uint VISIBLE_GAMEGLOBALMISSION = 2u;

	protected const uint VISIBLE_TEAM_FILTER = 4u;

	private HCFAJFBKDIJ m_VisualType;

	private VisualInstanceHolder m_ScanningVfxHolder;

	private bool m_ScannedTipsShowed;

	public HCFAJFBKDIJ VisualType => HCFAJFBKDIJ.EUAV_VISUALTYPE_NONE;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void OnUIInit(Transform container, UIUAVMapObjectView uav, UISprite circle, UISprite circleExtneded, UISprite point, TweenAlpha tweenAlpha, TweenScale tweenScale, float scale)
	{
	}

	public void OnUIDestory()
	{
	}

	public void OnUavCreate(object[] data)
	{
	}

	private void UpdateUAVCircleRange()
	{
	}

	private void UpdateShowPlayerCntPosition()
	{
	}

	private EFactionRelationType GetRelationWithTrackedPlayer()
	{
		return EFactionRelationType.Friendly;
	}

	private void SetupStyleContent(EKLALLOELLG style)
	{
	}

	private void UpdateFactionStyleContent(EFactionRelationType relationType, DCHMEBMBAIP styleConfigData = null)
	{
	}

	private void UpdateFactionVisibility(EFactionRelationType relationType)
	{
	}

	private bool TryReleaseAllVfxHolders()
	{
		return false;
	}

	private void LoadScanningVfxForOwnedUav(ResourceID scanningVfxResID)
	{
	}

	private void OnScanningVfxAttached(GameObject vfxInstance)
	{
	}

	public void OnUavRecycle(object[] data)
	{
	}

	private void OnUavReveal(object[] data)
	{
	}

	private void SetShowPlayerCnt(bool show, int cnt)
	{
	}

	private void NotifyLocalPlayerRevealed(bool isPersonalUAV = false)
	{
	}

	private static void UpdateLocalPlayerRevealed(LevelUAV m_Uav, bool rangeChecked, bool outRange)
	{
	}

	private static Player GetLocalPlayer()
	{
		return null;
	}

	public void SetMapIconScale(Vector3 mapIconScale)
	{
	}

	public void UpdateIconRotationUp(Quaternion mapIconRotation)
	{
	}

	public void UpdateWhenTrackedTargetChanged(object[] data)
	{
	}

	private void RefreshTeamFilterVisibility()
	{
	}

	public void UpdateUAVPosition(bool updateInterval = false)
	{
	}

	private void HideUavPoints()
	{
	}

	private void ShowPlayerTween()
	{
	}

	private void HidePlayerTween()
	{
	}

	private void ShowCircleTween()
	{
	}

	private void HideCircleTween()
	{
	}

	public bool IsSelf(uint uavID)
	{
		return false;
	}

	public bool IsRecycled()
	{
		return false;
	}

	private void SetVisibleState(uint flag, bool v)
	{
	}

	public bool OwnerIsLocal()
	{
		return false;
	}

	private void _003CSetupStyleContent_003Eb__48_0()
	{
	}
}
