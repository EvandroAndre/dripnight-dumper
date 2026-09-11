using GCommon;
using UnityEngine;

public class SeasonReplayDestinyWeaponData : CSVBaseData
{
	public uint WeaponType;

	public Vector3 Position1;

	public Vector3 Rotation1;

	public Vector3 Scale1;

	public Vector3 Position2;

	public Vector3 Rotation2;

	public Vector3 Scale2;

	public Vector3 Position3;

	public Vector3 Rotation3;

	public Vector3 Scale3;

	public const uint TypeOthers = 99u;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private Vector3 GetVector3(string fieldName, string[] headers, string[] values, char InSplitChar = ';')
	{
		return default(Vector3);
	}
}
