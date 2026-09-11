using GCommon;

namespace COW;

public class WorkshopSceneData : CSVBaseData
{
	public uint SceneID;

	public float BoundaryMaxX;

	public float BoundaryMinX;

	public float BoundaryMaxY;

	public float BoundaryMinY;

	public float BoundaryMaxZ;

	public float BoundaryMinZ;

	public float HeightLimit;

	public float MoveStep;

	public ResourceID WorkShopMap;

	public ResourceID WorkShopMiniMap;

	public ResourceID FloorPlane;

	public float GridWidth;

	public float FloorOffset;

	public float[] PlayerTransPos;

	public float[] PlayerTransRot;

	public float CamDefaultHeight;

	public float YPosAdjust;

	public uint DynGridWidth;

	public float[] EditAreaCenter;

	public uint AdjustFloorPlaneStep;

	public int AdjustFloorPlaneMin;

	public int AdjustFloorPlaneMax;

	public int AdjustFloorPlaneDefault;

	public int AllowObjectMaxHeight;

	public int YMOVE_Max;

	public bool EnableAreaEdit;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
