using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIHollowedTexture : UITexture
{
	protected int mRow;

	protected int mCloumn;

	protected List<int> mHollowIndex;

	private int alpahIndex;

	private float alphaVaule;

	private float alphaTime;

	public void SetRowAndCloumn(int row, int cloumn)
	{
	}

	public void SetHollowedIndexs(List<int> indexs)
	{
	}

	public void PlayHollowedAlphaTween(int alpahIndex, float alphaTime = 1f)
	{
	}

	private void Update()
	{
	}

	protected override void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color> cols)
	{
	}
}
