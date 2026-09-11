using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudArmsListController : UIBaseController
{
	private UIHudArmsListView m_View;

	private List<KCIPKBBMIOJ> m_ArmsInfoList;

	private List<UIHudArmsItemController> m_ArmsItemCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(List<KCIPKBBMIOJ> armsInfoList)
	{
	}

	private void OnGridReposition()
	{
	}

	private void AdaptBgWidth()
	{
	}

	private void StartCountdownLabel(int delayTime)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
