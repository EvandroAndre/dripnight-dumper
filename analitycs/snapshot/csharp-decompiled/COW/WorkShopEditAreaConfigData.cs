using GCommon;

namespace COW;

public class WorkShopEditAreaConfigData : CSVBaseData, IGetId
{
	public uint AreaID;

	public uint MapID;

	public string AreaName;

	public float[] AreaAxis;

	public float BoundaryMaxX;

	public float BoundaryMinX;

	public float BoundaryMaxY;

	public float BoundaryMinY;

	public float BoundaryMaxZ;

	public float BoundaryMinZ;

	public float HeightLimit;

	public float MoveStep;

	public float[] PlayerTransPos;

	public float[] PlayerTransRot;

	public uint GridWidth;

	public float CamDefaultHeight;

	public uint DynGridWidth;

	public float FloorOffset;

	public int AdjustFloorPlaneDefault;

	public uint AdjustFloorPlaneStep;

	public int AdjustFloorPlaneMin;

	public int AdjustFloorPlaneMax;

	public int AllowObjectMaxHeight;

	public int YMOVE_Max;

	public uint[] SelectAreaSize;

	public static implicit operator WorkshopSceneData(WorkShopEditAreaConfigData data)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
