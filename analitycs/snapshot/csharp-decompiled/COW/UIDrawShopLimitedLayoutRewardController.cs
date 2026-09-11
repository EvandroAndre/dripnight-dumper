using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDrawShopLimitedLayoutRewardController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<DrawShopPoolItemData> _003C_003E9__5_0;

		public static Comparison<DrawShopPoolItemData> _003C_003E9__5_1;

		internal int _003CSetupRewardPool_003Eb__5_0(DrawShopPoolItemData a, DrawShopPoolItemData b)
		{
			return 0;
		}

		internal int _003CSetupRewardPool_003Eb__5_1(DrawShopPoolItemData a, DrawShopPoolItemData b)
		{
			return 0;
		}
	}

	public List<GameObject> RewardSlots;

	protected UIDrawShopLimitedRewardLayoutOneView m_View;

	private List<UIDrawShopLimitedRewardItemController> m_RewardItems;

	protected override void OnUIInit()
	{
	}

	private void InitializeRewardItems()
	{
	}

	public void SetupRewardPool(List<DrawShopPoolItemData> poolItems, uint drawShopId)
	{
	}

	private void CreateRewardItems(List<DrawShopPoolItemData> sortedItems, uint drawShopId)
	{
	}

	public void SetItemClickCallback(Action<int> onClickFunc)
	{
	}

	private UIDrawShopLimitedRewardItemController CreateItemByRarity(DrawShopPoolItemData itemData, Transform parent)
	{
		return null;
	}

	private void ClearRewardItems()
	{
	}

	public List<UIDrawShopLimitedRewardItemController> GetAllRewardItems()
	{
		return null;
	}

	public static EDrawShopLayoutType SelectLayoutType(List<DrawShopPoolItemData> poolItems)
	{
		return (EDrawShopLayoutType)0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
