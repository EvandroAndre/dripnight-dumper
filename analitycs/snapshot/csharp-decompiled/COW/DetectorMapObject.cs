using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class DetectorMapObject
{
	private class Point
	{
		public UISprite Sprite;

		public TweenAlpha TweenAlpha;

		public Transform SpriteTrans;

		public MiniMapVehicleHorse MiniMapHorse;
	}

	private DetectorMapObjectModel m_Model;

	private Transform m_MapContainer;

	private Transform m_Detector;

	private UISprite m_Point;

	private UISprite m_Circle;

	private MiniMapVehicleHorse m_CarPoint;

	private TweenScale m_CircleTween;

	private List<Point> m_Points;

	private List<Point> m_CarPoints;

	private float m_RangeOnMap;

	private float m_Scale;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private int m_LastDetectFrame;

	public float m_FadeStartTime;

	public float m_FadeEndTime;

	private float m_InitialPointRotAngle;

	private bool m_FadeLine;

	public bool Stopped => false;

	public void SetMapOffsetContext(UIMapUtil.MapOffsetContext ctx)
	{
	}

	internal void OnUIInit(Transform container, DetectorMapObjectModel dectModel, Transform detector, UISprite circle, UISprite point, MiniMapVehicleHorse car, TweenScale tweenScale, float scale, bool fadeLine)
	{
	}

	public void OnUIDestory()
	{
	}

	public void Update(float rotAngles)
	{
	}

	public void UpdateDetectorPointScale(Vector3 mapIconScale)
	{
	}

	private void UpdateFading()
	{
	}

	private void ShowCircleTween()
	{
	}

	private void HideCircleTween()
	{
	}

	private void ShowCarPoints(List<Vector3> ps, float angle, MiniMapVehicleHorse sprite, List<Point> points, List<uint> subTypes)
	{
	}

	private void ShowPoints(List<Vector3> ps, float angle, UISprite sprite, List<Point> points)
	{
	}

	private void SetPointShow(Point point, float angle, Vector3 p)
	{
	}

	private void ShowPointInRange(int initialPointsCount, int pointsCount, List<Point> points)
	{
	}

	private void DestroyPoints()
	{
	}

	private void HidePoints()
	{
	}
}
