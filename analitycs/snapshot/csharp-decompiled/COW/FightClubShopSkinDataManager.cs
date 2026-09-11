using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class FightClubShopSkinDataManager : SingletonModule<FightClubShopSkinDataManager>
{
	private Dictionary<uint, FightClubShopSkinData> m_SkinDatas;

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

	public bool GetCloseBtnLocalPos(out Vector3 lp)
	{
		lp = default(Vector3);
		return false;
	}

	public FightClubShopSkinData GetSkinData()
	{
		return null;
	}

	public FightClubShopSkinData GetSkinDataByType(uint skinType)
	{
		return null;
	}

	public FightClubShopSkinnedItemData GetSkinnedItemDataByFiler(uint filter)
	{
		return null;
	}
}
