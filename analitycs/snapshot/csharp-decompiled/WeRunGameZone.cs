using System;
using System.Collections.Generic;
using UnityEngine;
using message;

[Serializable]
public class WeRunGameZone
{
	public uint AutoID;

	public CMDBIPLGLGA GroupMode;

	public Transform Center;

	public ESafeZoneType SafeZoneType;

	public float ZoneRadius;

	public uint Damage;

	public uint RetreatPointCnt;

	public List<WeRunSpawnData> TeamSpawnInfo;

	public List<WeRunBoxData> BoxData;

	public List<WeRunBotData> BotData;
}
