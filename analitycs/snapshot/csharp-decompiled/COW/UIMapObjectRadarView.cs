using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIMapObjectRadarView : MonoBehaviour
{
	public uint RadarID;

	public List<UISprite> Points;

	public UISprite Circle;

	public TweenScale CircleTween;

	private UISprite m_Point;

	private Transform m_ParentTrans;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void Init(UISprite point, Transform parentTrans)
	{
	}

	public void UpdatePointsPosition(List<Vector3> PlayerPositions, int scanSize, float scale)
	{
	}

	private void HidePoints()
	{
	}

	public void Hide()
	{
	}
}
