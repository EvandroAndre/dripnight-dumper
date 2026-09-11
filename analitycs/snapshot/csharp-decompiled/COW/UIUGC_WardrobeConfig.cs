using System;
using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW;

internal class UIUGC_WardrobeConfig : ScriptableObject
{
	[Serializable]
	public class CustomClothCfg
	{
		public string Name;

		public LCBJLLIGMCP Style;

		public Color MainColor1;

		public Color MainColor2;

		public Color PantsColor;

		public List<uint> ClothIdList;
	}

	public List<CustomClothCfg> FootBallShirtList;

	public CustomClothCfg GetClothByType(LCBJLLIGMCP eType)
	{
		return null;
	}
}
