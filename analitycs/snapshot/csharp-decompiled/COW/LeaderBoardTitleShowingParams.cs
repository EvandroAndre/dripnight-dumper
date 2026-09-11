using GCommon;
using UnityEngine;

namespace COW;

public struct LeaderBoardTitleShowingParams
{
	public uint Rank;

	public string Region;

	public string Name;

	public ResourceID IconRes;

	public ResourceID BgRes;

	public ResourceID IconVFXRes;

	public Color IconLabelColor;

	public Color IconShadowColor;

	public bool IsPeakTitle;
}
