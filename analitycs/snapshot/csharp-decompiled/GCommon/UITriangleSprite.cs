using UnityEngine;

namespace GCommon;

public class UITriangleSprite : UISprite
{
	public enum Verts
	{
		LeftBottom,
		LeftTop,
		RightTop,
		RightBottom
	}

	public Verts IngoreVert;

	protected override void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
