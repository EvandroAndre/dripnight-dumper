using UnityEngine;

public class UICurvedSurfaceSprite : UISprite
{
	private float mCurvatureAngle;

	private int mSegments;

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

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	private void FillCurved(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}

	public Vector3 GetLocalPositionAtNormalized(float t)
	{
		return default(Vector3);
	}

	public float GetLocalYAngleAtNormalized(float t)
	{
		return 0f;
	}
}
