using System;
using System.Collections.Generic;
using UnityEngine;
using message;

public class RoundAISpawnPoints : MonoBehaviour
{
	[Serializable]
	public class RoundAIInfo
	{
		public int RoundID;

		public int SubRoundID;

		public BMLKMJHLEDP AIType;
	}

	public List<RoundAIInfo> m_SpawnInfoList;

	private void Start()
	{
	}
}
