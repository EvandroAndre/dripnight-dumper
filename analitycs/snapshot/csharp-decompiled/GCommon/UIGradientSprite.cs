using UnityEngine;

namespace GCommon;

public class UIGradientSprite : UISprite
{
	public enum GradientDirection
	{
		TopBottom,
		LeftRight
	}

	public GradientDirection GradientDir;

	protected override void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
