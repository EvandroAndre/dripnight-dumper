using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIImageShareEmojiSelectPopController : UIPopupWindowController, IEasyList
{
	private UIImageShareEmojiSelectPopView m_View;

	private UIModelTakePhoto m_ModelTakePhoto;

	private List<EmojiSelectItemData> m_ItemDatas;

	private UIClickMask m_ClickMask;

	private bool m_ShowBigRewardSticker;

	private bool m_ShowSquadTreasureSticker;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void RefreshStickNum(Dictionary<uint, uint> typeNumDic)
	{
	}

	public void SetViewData(uint shareScreenType, Dictionary<uint, uint> typeNumDic, bool isVertical = false, bool showBigRewardSticker = false, bool showSquadTreasureSticker = false)
	{
	}

	private bool CheckShowSticker(StickerWithResConfig stickerConfig)
	{
		return false;
	}

	private void CheckAndRequestNoGoposItems(List<StickerWithResConfig> list)
	{
	}

	private void GetCurExistStickerNumAndLimitNum(StickerConfigDesc stickerConfig, Dictionary<uint, uint> typeNumDic, ref uint curNum, ref uint limitNum)
	{
	}

	public void AddClickMask(bool isVertical)
	{
	}

	public void ClearClickMask()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
