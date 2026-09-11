using System;
using GCommon;

namespace COW;

public class UIClanWarV2RoundChangeController : UIBaseController
{
	private UIModelClanWarV2 m_ModelWar;

	private ClanWarV2Stage m_Stage;

	private UIClanWarV2RoundChangeView m_View;

	private Action m_OnCloseBtn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetCloseBtnAction(Action func)
	{
	}

	private void OnCloseBtn()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshRoundTrans()
	{
	}

	private void RefreshSeasonTrans()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
