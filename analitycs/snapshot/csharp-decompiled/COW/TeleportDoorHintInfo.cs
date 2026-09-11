using COW.GamePlay;
using UnityEngine;

namespace COW;

public class TeleportDoorHintInfo : MonoBehaviour
{
	public uint UID;

	public HCBGDFOPAIJ DoorType;

	public string MapGroup;

	public UILabel GroupLabel;

	public GameObject GoArrow;

	public Vector2 WorldPos;

	public void InitData(uint uid, HCBGDFOPAIJ doorType, string mapGroup)
	{
	}
}
