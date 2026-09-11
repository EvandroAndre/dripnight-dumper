using COW.GamePlay;
using UnityEngine;

namespace COW;

public class BountyScannerMapObject
{
	private Transform m_MarkContainer;

	private UISprite m_MarkSprite;

	private UISprite m_DirectionSprite;

	private TweenAlpha m_MarkerTween;

	private TweenAlpha m_DirectionTween;

	private UIMapUtil.EMapType m_MapType;

	private float m_Scale;

	private NDELOOCFHJG m_BountyManager;

	private UIPanel m_MinimapPanel;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private const float MINIMAP_DIECTION_RANGE = 90f;

	public void OnUIInit(Transform container, UISprite markSprite, TweenAlpha markTween, float scale, UIMapUtil.EMapType mapType = UIMapUtil.EMapType.Bigmap, UISprite directionSprite = null, TweenAlpha directionTween = null)
	{
	}

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void SetMinimap(UIPanel panel)
	{
	}

	public void OnUIDestory()
	{
	}

	private void RefreshUIView(object[] data)
	{
	}

	private void HideBountyView(object[] data)
	{
	}

	private void ShowMark()
	{
	}

	public void ShowMarkDirection()
	{
	}

	public bool IsMarkDirectionActive()
	{
		return false;
	}

	private void ShowPlayerTween()
	{
	}

	private void HideMarkerTween()
	{
	}
}
