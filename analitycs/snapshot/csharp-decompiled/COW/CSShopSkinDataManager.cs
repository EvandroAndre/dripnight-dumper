using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class CSShopSkinDataManager : SingletonModule<CSShopSkinDataManager>
{
	private Dictionary<uint, CSShopSkin> m_SkinDatas;

	public const uint SKIN_TYPE_DEFAULT = 0u;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool GetTitleLabelColor(out Color color)
	{
		color = default(Color);
		return false;
	}

	public bool GetTitleLabelOffset(out Vector3 offset)
	{
		offset = default(Vector3);
		return false;
	}

	public bool GetBuyLabelColor(out Color color)
	{
		color = default(Color);
		return false;
	}

	public bool GetAskLabelColor(out Color color)
	{
		color = default(Color);
		return false;
	}

	public bool GetCountDownColor(out Color color)
	{
		color = default(Color);
		return false;
	}

	public bool GetCloseBtnLocalPos(out Vector3 lp)
	{
		lp = default(Vector3);
		return false;
	}

	public bool GetCountDownLocalPos(out Vector3 lp)
	{
		lp = default(Vector3);
		return false;
	}

	public CSShopSkin GetSkinData()
	{
		return null;
	}

	public CSShopSkin GetSkinDataByType(uint skinType)
	{
		return null;
	}

	public CSShopSkinnedItemData GetSkinnedItemDataByFiler(uint filter)
	{
		return null;
	}
}
