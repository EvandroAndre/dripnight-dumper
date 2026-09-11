using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UISparkPetLevelUpAnnounceController : UIPopupWindowController
{
	private UIModelSparkPet m_ModelSparkPet;

	private UISparkPetLevelUpAnnounceView m_View;

	private List<SparkLevelAwardDesc> m_LevelAwardList;

	private Action m_CloseCallback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetCloseCallback(Action callback)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void PrepareDataList()
	{
	}

	public void SetViewData(SparkLevelAwardDesc curLevelAwardDesc, SparkLevelAwardDesc nextLevelAwardDesc)
	{
	}

	private void RefreshSparkPetCDN()
	{
	}

	private void RefreshAward(SparkLevelAwardDesc awardDesc)
	{
	}

	private void RefreshNextLevelLabel(SparkLevelAwardDesc nextAwardDesc)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
