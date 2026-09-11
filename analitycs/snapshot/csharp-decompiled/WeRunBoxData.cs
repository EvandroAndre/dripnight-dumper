using System;
using System.Collections.Generic;
using UnityEngine;
using message;

[Serializable]
public class WeRunBoxData
{
	public int GroupId;

	public CJMCIEMHPEG BoxType;

	public List<Transform> BoxSpawnPos;

	public string ResourceIDName;
}
