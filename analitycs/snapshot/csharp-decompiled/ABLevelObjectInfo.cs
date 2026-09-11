using System.IO;
using UnityEngine;

public abstract class ABLevelObjectInfo
{
	public int GoInfoIndex;

	public static ABLevelObjectInfo CreateInfoDataByType(EABLevelObjectInfoType type)
	{
		return null;
	}

	public abstract EABLevelObjectInfoType GetABLevelObjectInfoType();

	public void UnSerializedData(ref BinaryReader reader)
	{
	}

	protected abstract void OnUnSerializedData(ref BinaryReader reader);

	public abstract void ApplyData(GameObject inst_object);

	public abstract bool CreateInfo(GameObject level_object);
}
