using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIVirtualBrandStoryController : UINavigationController, IEasyList
{
	private UIVirtualBrandStoryView m_View;

	private UIStandardAdsController m_DraftCtrl;

	private UIStandardAdsController m_BrandBgCtrl;

	private UIModelVirtualBrand m_Model;

	private const int DRAFT_SCROLLVIEW_DEPTH = -2;

	private const int BRAND_BG_DEPTH_SCROLLVIEW_DEPTH = -3;

	private const int DRAFT_DRAG_CONTENT_DEPTH = 1;

	private const int BRAND_BG_DRAG_CONTENT_DEPTH = 0;

	private const int BRAND_BG_DOT_POSX = 0;

	private const int BRAND_BG_DOT_POSY = -320;

	private const int BRAND_BG_DOT_CELL_WIDTH = 35;

	private const int BRAND_BG_DOT_CELL_HEIGHT = 20;

	private const int BRAND_BG_AUTO_SCROLL_TIME = 6;

	private const int DRAFT_WIDTH = 286;

	private const int DRAFT_HEIGHT = 390;

	private const int BRAND_BG_WIDTH = 1750;

	private const int BRAND_BG_HEIGHT = 1070;

	private const string BRAND_BG_ENABLE_SPRITE_NAME = "FF_UI_VirtualBrand_PagesBG_1";

	private const string BRAND_BG_DISABLE_SPRITE_NAME = "FF_UI_VirtualBrand_PagesBG_2";

	private const string LOCAL_SAVE_IS_DRAFT_LIKED = "VirtualBrandStoryIsGetLikeAward";

	private const string DRAFT_TIPS_KEY = "T_36_DY_VB_SKETCH_EX";

	private Vector3 m_DraftLikeIconPos;

	private Vector3 m_DraftLikeBgPos;

	private uint m_CurBrandId;

	private int m_CurDraftIndex;

	private bool m_SketchOn;

	private uint m_GuideDelayCallTid;

	public const string VIRTUAL_BRAND_LIKE_GUIDE = "VIRTUAL_BRAND_LIKE_GUIDE_{0}_{1}";

	private const uint DELAY_TIME = 4u;

	private List<GameObject> m_DraftLikeDefaultIconList;

	private List<GameObject> m_DraftLikedIconList;

	private readonly Dictionary<uint, ulong> m_VirtualBrandIDViewTimeDict;

	private ulong m_TabStartShowTime;

	private ulong m_TabEndShowTime;

	private EventLogger.EventNaviTabViewTime m_EventTypeVirtualBrandViewTimeInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetDraftUIData(int index)
	{
	}

	private void InitBrandList()
	{
	}

	public void SetViewData()
	{
	}

	public override EFrontendBGMType GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	private GameObject CreateDraftChildObject(GameObject obj, Transform parent, Vector3 pos)
	{
		return null;
	}

	private void HideLikeBubble()
	{
	}

	private void ShowLikeBubbleIfNeed()
	{
	}

	private void InitBrandViewTimeData()
	{
	}

	private void AddBrandViewTimeInfoToList(EventLogger.EventNaviTabViewTime viewTimeInfo, uint brandID, ulong viewTime)
	{
	}

	private void UpdateSelectedBrandViewTime(uint lastSelectBrandId)
	{
	}

	private void OnStoryItemClicked(object[] param)
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnBtnDraftTipsClick()
	{
	}

	private void OnBtnKnowMoreClick()
	{
	}

	private void OnBtnLikeClick()
	{
	}

	private void OnBtnNextDraftClick()
	{
	}

	private void OnBtnPreDraftClick()
	{
	}

	private bool _003CInitBrandList_003Eb__43_0(uint id)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
