using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUnifiedMapSlotBaseController : UIBaseController
{
	public class MapSlotItem
	{
		public delegate bool NeedShowAction();

		public NeedShowAction NeedShow;

		public Action OnShow;

		public Action OnHide;
	}

	private bool m_IsExposed;

	protected SceneEditSlotInfo m_SlotInfo;

	protected UIModelSceneEdit m_Model;

	protected UINavigationUtil.UINavigationFrom m_LogFrom;

	protected string m_LogFromInfo;

	protected EUGCScene m_LogFromScene;

	private List<List<MapSlotItem>> m_SlotItems;

	private ERecommendationType m_RecommendationType;

	private UIUGCHotIndicatorController m_HotIndicatorCtrl;

	private bool m_KolInited;

	private float m_KolNameOriginalX;

	private float m_KolNameNoIconX;

	protected void AddMapSlotItemGroup(MapSlotItem[] items)
	{
	}

	protected sealed override void OnUIInit()
	{
	}

	protected virtual void OnSlotInit()
	{
	}

	public void SetSlotInfo(SceneEditSlotInfo slotInfo)
	{
	}

	public void SetFromInfo(UINavigationUtil.UINavigationFrom from, string fromInfo, EUGCScene scene)
	{
	}

	public void SetRecommendationType(ERecommendationType type)
	{
	}

	public void OnExposure()
	{
	}

	public void OnRecommendationItemExposure()
	{
	}

	protected void ShowHotIndicator(GameObject hotContainer)
	{
	}

	protected bool HotIndicatorNeedShow()
	{
		return false;
	}

	protected void ShowKol(UILabel kolAuthorName, UINetworkTexture kolAuthorIcon, GameObject defaultAuthorIcon = null)
	{
	}

	protected bool PlayTimeNeedShow()
	{
		return false;
	}

	protected void ShowPlayTime(UILabel timeLabel, bool show)
	{
	}

	protected void ShowSpecialState(GameObject lockState, UILabel lockTxt, UISprite warningIcon, bool show)
	{
	}

	protected string GetMapName()
	{
		return null;
	}

	protected string GetMapModeText()
	{
		return null;
	}

	protected void ModifyLabelItem(string content, UILabel label, int maxWidth, UISprite bg = null, int padding = 0, string tail = "...")
	{
	}

	protected void SetMapBg(UINetworkTexture cdnSlotIcon, UITexture gameMapBg, UITexture gameBitMap, UITexture gameBitOutlineMap, UISprite iconItemSprite)
	{
	}

	protected void OnMapSlotBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
