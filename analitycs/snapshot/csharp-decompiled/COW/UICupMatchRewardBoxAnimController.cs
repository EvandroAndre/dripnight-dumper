using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchRewardBoxAnimController : UIBaseController
{
	private UICupMatchRewardBoxView m_View;

	private List<Transform> m_ResultTrans;

	private List<CupMatchRewardBoxResultItem> m_ResultItems;

	private UIModelCupMatch m_ModelCupMatch;

	private int m_CupMatchKey;

	private List<GameObject> m_BoxEffects;

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

	public void Init(int key)
	{
	}

	public void ShowClaimed()
	{
	}

	private void RefreshBox()
	{
	}

	private void CreateResultItem()
	{
	}

	private void UpdateResultItem()
	{
	}

	private void AnimationEventHandler(object[] data)
	{
	}

	private bool NeedUpdateBox()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
