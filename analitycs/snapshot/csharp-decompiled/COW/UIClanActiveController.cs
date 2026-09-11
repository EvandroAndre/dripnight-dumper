using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanActiveController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanActiveView m_View;

	private UIModelClan m_ModelClan;

	private UIModelMall m_ModelMall;

	private List<UIClanActivenessProgressBarItemController> m_ProgressBarList;

	private Dictionary<uint, UIClanActiveWayItemController> m_DicActiveWays;

	public static uint MAX_ACTIVE_WAYNUM;

	private const int CLAN_MALL_GUIDE_DEPTH = 19;

	private int m_CurrentWeekNum;

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

	protected override void OnVisibilityChanged()
	{
	}

	private void OnExchangeMallBtnClick()
	{
	}

	private void OnActiveProgressRuleClick()
	{
	}

	public void ShowClanMallGuide()
	{
	}

	private void InitLeftCdn()
	{
	}

	private void InitProgressBar()
	{
	}

	private void InitActiveWay()
	{
	}

	private void RefreshActiveLabel()
	{
	}

	private void RefreshTimeLabel()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
