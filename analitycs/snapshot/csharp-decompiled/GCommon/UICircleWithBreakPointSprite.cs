using UnityEngine;

namespace GCommon;

public class UICircleWithBreakPointSprite : UISprite
{
	public class ClipRect
	{
		public Vector2[] TempPos;

		public Vector2[] TempUVs;
	}

	protected float m_MaxAngle;

	public uint m_BreakPointNum;

	protected float m_OneBreakPointAngle;

	protected float m_FillPercent;

	protected BetterList<float> m_SubLevelStartAngles;

	protected float m_OnePartAngle;

	protected float m_Radius;

	protected float m_RadiusUV;

	protected Vector2 m_CenterPos;

	protected Vector2 m_CenterUVs;

	protected BetterList<BetterList<ClipRect>> m_SubLevelSectorRect;

	protected BetterList<BetterList<ClipRect>> m_FilledSubLevelSectorRect;

	protected Vector4 m_DrawingUVs;

	private uint m_SplitNumForOneSector;

	public void SetViewData(float maxAngle, uint breakPointNum, float onePointAngle, float fillPercent)
	{
	}

	private void CreatSubLevelSector()
	{
	}

	private void SetFillAmount()
	{
	}

	private BetterList<ClipRect> GetSplitSectorRect(float startAngle, float endAngle, uint SplitNum)
	{
		return null;
	}

	private BetterList<float> GenerateSublevelStartAngleList()
	{
		return null;
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
