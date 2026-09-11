using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public class UIMapObjectMapScanView : MonoBehaviour
{
	public uint RadarID;

	public List<UISprite> Points;

	public float BaseSize;

	public GameObject MainRoot;

	public TweenScale tweenScale;

	public TweenAlpha tweenAlpha;

	public UIWidget[] widgets;

	public ParticleSystem[] particleSystems;

	public GameObject LoopRoot;

	public GameObject OnceRoot;

	public GameObject GroupRoot;

	public Color firendColor;

	public Color enemyColor;

	private UISprite m_Point;

	private Transform m_ParentTrans;

	public bool IsShow;

	private BHGGAEEHJCO OwnerId;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	public void Init(UISprite point, Transform parentTrans)
	{
	}

	public void UpdatePointsPosition(List<Vector3> PlayerPositions)
	{
	}

	private void HidePoints()
	{
	}

	public void Hide()
	{
	}

	public void RefreshByPlayerID(BHGGAEEHJCO pid, out bool isSameTeam)
	{
		isSameTeam = default(bool);
	}

	private void SetColor(Color changeColor)
	{
	}

	public void PlayEffect(float scanSize, float scale, BHGGAEEHJCO pid)
	{
	}

	public void SwitchObserver(BHGGAEEHJCO pid)
	{
	}

	private void OnTweenFinish()
	{
	}
}
