using System;
using UnityEngine;

namespace COW.GamePlay;

public class TrainingSceneRenderGroupPreset : MonoBehaviour
{
	[Serializable]
	public struct ZoneTypeRender
	{
		public NADDEMMBAJF ZoneType;

		public int[] ContainRenderGroup;
	}

	public ZoneTypeRender[] ZoneTypeRenders;

	private void Awake()
	{
	}
}
