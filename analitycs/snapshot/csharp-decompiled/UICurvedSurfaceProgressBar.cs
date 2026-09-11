using System;
using UnityEngine;

public class UICurvedSurfaceProgressBar : UIProgressBar
{
	private float mCurvatureAngle;

	private int mSegments;

	private AnimationCurve mThumbYCurve;

	private float mThumbYScale;

	private bool mEnableThumbScaleByProgress;

	[NonSerialized]
	private bool mCurvatureDirty;

	[NonSerialized]
	private UIWidget mCachedFG;

	[NonSerialized]
	private UIWidget mCachedBG;

	public float curvatureAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int segments
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public AnimationCurve thumbYCurve
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float thumbYScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool enableThumbScaleByProgress
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private UICurvedSurfaceSprite CurvedFG => null;

	private UICurvedSurfaceSprite CurvedBG => null;

	private bool IsCurvedMode => false;

	protected override void OnStart()
	{
	}

	public override void ForceUpdate()
	{
	}

	private void SyncCurvature()
	{
	}

	private void UpdateCurvedThumb()
	{
	}

	private void UpdateFlatThumb()
	{
	}

	private void ApplyThumbScale()
	{
	}

	public Vector3 GetThumbWorldPosition(float progress)
	{
		return default(Vector3);
	}
}
