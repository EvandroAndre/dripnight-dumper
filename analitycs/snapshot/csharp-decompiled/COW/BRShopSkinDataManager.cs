using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class BRShopSkinDataManager : SingletonModule<BRShopSkinDataManager>
{
	private Dictionary<uint, BRShopSkin> m_SkinDatas;

	public const uint SKIN_TYPE_DEFAULT = 0u;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public BRShopSkin GetSkinDataByType(uint skinType)
	{
		return null;
	}

	public bool GetBuyBtnLabelColor(uint skinType, out Color color)
	{
		color = default(Color);
		return false;
	}

	public bool GetDisabledBuyBtnLabelColor(uint skinType, out Color color)
	{
		color = default(Color);
		return false;
	}

	private bool TryGetColor(uint[] colorData, out Color color)
	{
		color = default(Color);
		return false;
	}
}
