using System;
using UnityEngine;

namespace GCommon;

public class UIEasyListIntervalShowItem : MonoBehaviour
{
	protected UIEasyListItemController m_EasyListItemCtrl;

	public Func<int> CurPlayingIndex;

	public GameObject Item;

	private bool m_Played;

	private int m_LastIndex;

	private bool m_UseNewShow;

	private UIEasyListIntervalShowHelper m_ParentController;

	protected UIEasyListItemController EasyListItemCtrl => null;

	private int CtrlRealIndex => 0;

	protected UIEasyListIntervalShowHelper ParentController => null;

	private void Update()
	{
	}

	public void SetNewShow()
	{
	}

	public void NewShow()
	{
	}

	private void PlayExtraAction(int index)
	{
	}

	public virtual void HideItem()
	{
	}

	public virtual void ShowItem()
	{
	}
}
