using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaIchis55TenRewardContainerController : UIBaseController, UITable2.IUITable2Item
{
	private UIGachaIchis55TenRewardContainerView m_View;

	private List<UIGachaIchis55RewardItemController> m_TenRewardItemCtrlList;

	private bool m_IsRevealPrepared;

	private const int ICHIS55_TEN_REWARD_DISPLAY_COUNT = 10;

	private const int ICHIS55_REVEAL_CARD_COUNT = 10;

	private const string ICHIS55_NORMAL_CARD_SPRITE = "FF_UI_Ichis_55_Card01";

	private const string ICHIS55_BIG_PRIZE_CARD_SPRITE = "FF_UI_Ichis_55_Card00";

	private const string ICHIS55_NORMAL_CARD_ONCE_VFX = "UIFX_Ichis_55_NormalCrad_Once";

	private const string ICHIS55_BIG_PRIZE_CARD_ONCE_VFX = "UIFX_Ichis_55_ColorfulCrad_Once";

	private const string ICHIS55_NORMAL_CARD_FRONT_VFX = "UIFX_Ichis_55_NormalCrad_Front";

	private const string ICHIS55_BIG_PRIZE_CARD_FRONT_VFX = "UIFX_Ichis_55_ColorfulCrad_Front";

	private const string ICHIS55_NORMAL_CARD_FRONT_LOOP_VFX = "UIFX_Ichis_55_NormalCrad_FrontLoop";

	private const string ICHIS55_BIG_PRIZE_CARD_FRONT_LOOP_VFX = "UIFX_Ichis_55_ColorfulCrad_FrontLoop";

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

	public void SetViewData(List<CommonRewardItemInfo> rewardInfoList, bool showFrontLoopVFX = false)
	{
	}

	public void PrepareCardReveal(List<CommonRewardItemInfo> rewardInfoList)
	{
	}

	public void RevealCard(int index)
	{
	}

	public void RevealCardImmediately(int index)
	{
	}

	public float GetRevealCardAnimationLength(int index)
	{
		return 0f;
	}

	public List<UIGachaIchis55RewardItemController> GetItemControllers()
	{
		return null;
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void SetRevealCardsActive(bool active)
	{
	}

	private void ClearRewardItemControllers()
	{
	}

	private void SetRewardItemControllerActive(int index, bool active)
	{
	}

	private UIGachaIchis55RewardItemController OpenRewardItemController(Transform parent)
	{
		return null;
	}

	private void SetRewardItemControllerParent(UIGachaIchis55RewardItemController itemCtrl, Transform parent)
	{
	}

	private List<Transform> GetRevealRewardTransList()
	{
		return null;
	}

	private List<GameObject> GetRevealRewardContainerList()
	{
		return null;
	}

	private List<Animation> GetRevealAniList()
	{
		return null;
	}

	private List<GameObject> GetRevealBGList()
	{
		return null;
	}

	private List<UISprite> GetRevealCardList()
	{
		return null;
	}

	private List<VFXCreateHelper> GetRevealUIFXOnceList()
	{
		return null;
	}

	private List<VFXCreateHelper> GetRevealUIFXFrontList()
	{
		return null;
	}

	private List<VFXCreateHelper> GetRevealUIFXFrontLoopList()
	{
		return null;
	}

	private void SetRevealCardVFXResource(int index, bool isBigPrize)
	{
	}

	private void RefreshFinalRewardVFX(int index, CommonRewardItemInfo itemInfo, bool showFrontLoopVFX)
	{
	}

	private void SetVFXResource(int index, List<VFXCreateHelper> vfxList, ResourceID resId)
	{
	}

	private ResourceID GetVFXResourceID(string vfxName)
	{
		return default(ResourceID);
	}

	private void ResetRevealCardAnimation(int index, List<Animation> aniList)
	{
	}

	private void SetAllRevealCardVFXActive(bool active)
	{
	}

	private void SetRevealCardVFXActive(int index, bool active)
	{
	}

	private void SetRevealCardVFXActive(int index, List<VFXCreateHelper> onceList, List<VFXCreateHelper> frontList, List<VFXCreateHelper> frontLoopList, bool active)
	{
	}

	private void SetRevealCardVFXFrontLoopActive(int index, bool active)
	{
	}

	private void SetVFXActive(int index, List<VFXCreateHelper> vfxList, bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
