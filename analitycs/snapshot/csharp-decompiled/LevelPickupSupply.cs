using System;
using System.Collections.Generic;
using UnityEngine;

public class LevelPickupSupply : MonoBehaviour
{
	[Serializable]
	public class SupplyInfo
	{
		public uint m_ItemID;

		public uint m_ItemNum;
	}

	public uint m_RoundID;

	public uint m_SubRoundID;

	public List<SupplyInfo> m_SupplyInfos;

	private void Start()
	{
	}
}
