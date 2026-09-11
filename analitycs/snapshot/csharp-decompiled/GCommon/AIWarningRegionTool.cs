using UnityEngine;

namespace GCommon;

public class AIWarningRegionTool
{
	public static IAIWarningRegion CreateWarningRegion<T0, T>(ResourceID regionResID, Vector3 Pos, Quaternion Rot, T initParam) where T0 : AIWarningRegion<T>
	{
		return null;
	}

	public static IAIWarningRegion CreateCircleRegion(ResourceID regionResID, Vector3 Pos, Quaternion Rot, float radius)
	{
		return null;
	}

	public static IAIWarningRegion CreateQuadRegion(ResourceID regionResID, Vector3 Pos, Quaternion Rot, float width, float height, float length)
	{
		return null;
	}
}
