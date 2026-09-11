using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudBESubTypeNodeItemController : UIBaseController
{
	private UIHudBESubTypeNodeItemView m_View;

	private bool m_IsExpand;

	private List<KDAPIMCJEHJ> m_Children;

	public Action FunctionalBtnCallback;

	public JGFEALBJPGE parent;

	public int RawDataCount;

	private bool m_IsFirstTimeInited;

	public string BlockSubType;

	private int m_CurrentInitIndexInDataList;

	private bool m_IsLastReposFail;

	private bool m_LastReposFailExpand;

	public bool IsInitFinished => false;

	public int CurrentInitIndexInDataList
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsExpand => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void AddItem(KDAPIMCJEHJ block)
	{
	}

	public void RemoveItem(KDAPIMCJEHJ block)
	{
	}

	public void ClearItems()
	{
	}

	public List<KDAPIMCJEHJ> GetBlocks()
	{
		return null;
	}

	private void OnArrowClick()
	{
	}

	private void OnEnable()
	{
	}

	public void SetExpand(bool expand, bool forceInitBlocks = false)
	{
	}

	public void ShowToturial(TutorialEventEnum tutorialEvent)
	{
	}

	public void SetName(string key)
	{
	}

	public string GetName()
	{
		return null;
	}

	public void SetFunctionalBtnCallback(Action callback)
	{
	}

	private void TopCurrentTab()
	{
	}

	private void RefreshFunctionalBtn()
	{
	}

	private void _003COnUIInit_003Eb__17_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
