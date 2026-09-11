using System;
using GCommon;
using UnityEngine;

namespace COW;

public class NewBieGuildBasProcessor
{
	public class NewBieGuideCondition
	{
		public int precdt1;

		public int value1;

		public int precdt2;

		public int value2;

		public int precdt3;

		public int value3;

		public int precdt4;

		public int value4;

		public void SetGuideVal(int pre1, int val1, int pre2, int val2, int pre3, int val3, int pre4, int val4)
		{
		}
	}

	protected NewbieGuideId m_newbieid;

	public uint m_LobbyPrority;

	protected string m_newbieguidekey;

	protected NewBieGuideCondition m_Condition;

	public UICommonGuideController m_NewbieGuideCtrl;

	public UITutorialIndicatorHandController m_NewbieGuideHandCtrl;

	public UIBaseController m_NotCommonGuideCtrl;

	public UIWidget m_HandPoint;

	public Transform m_OpenTransform;

	public UIButton m_Button;

	protected bool m_OpenToNewBie;

	protected bool m_IsOpen;

	protected bool m_IsForceClickFinish;

	protected bool m_IsShowWithMask;

	protected bool m_IsUseBackendFlag;

	protected bool m_IsShowWhenTakePhotoState;

	protected uint[] NextGuidIds;

	public Func<UIWidget> m_HandPointDelegate;

	public UICommonGuideData CommonGuideData;

	public bool UncloseIfShowNewGuide;

	public NewBieGuildBasProcessor()
	{
	}

	public NewBieGuildBasProcessor(NewbieGuideId guideId)
	{
	}

	public NewBieGuildBasProcessor SetHandWidgetAndButton(UIWidget handPoint, Func<UIWidget> handPointDelegate = null, UIButton showButton = null, Transform openTransForm = null)
	{
		return null;
	}

	public NewBieGuildBasProcessor SetGuideData(UICommonGuideData commonGuideData, Transform openTransForm = null)
	{
		return null;
	}

	public void ClearHandWidget()
	{
	}

	public NewbieGuideId GetNewBieGuideId()
	{
		return NewbieGuideId.None;
	}

	public string GetGuideKey()
	{
		return null;
	}

	public bool IsForceClickFinish()
	{
		return false;
	}

	public bool IsShowWithMask()
	{
		return false;
	}

	protected bool IsShowInLobby()
	{
		return false;
	}

	public virtual void InitNewBieGuide()
	{
	}

	private bool CheckIsTakePhotoState()
	{
		return false;
	}

	public virtual bool CheckCanGuide()
	{
		return false;
	}

	private bool CheckAllStepShowed()
	{
		return false;
	}

	public void FinishForceClickFinishGuide()
	{
	}

	public virtual void DoGuild()
	{
	}

	public virtual void CloseGuild()
	{
	}

	protected void SetBackendOrPlayerPrefFlag()
	{
	}

	private bool CheckGuideCondition(int condinum, int valuenum)
	{
		return false;
	}
}
