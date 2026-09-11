using GCommon;
using UnityEngine;
using message;

namespace COW;

public class ScanByTypeResultData
{
	public uint PlayerId;

	public FMHKKEBHFIC ResultType;

	public Vector3 WorldPos;

	public UIManagedLevelObjectMapIconController Ctrl;

	public ResourceID GetIconResByScanType()
	{
		return default(ResourceID);
	}
}
