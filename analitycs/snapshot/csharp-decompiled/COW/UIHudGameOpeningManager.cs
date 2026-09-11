using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudGameOpeningManager : UIBaseController
{
	private sealed class _003CShowAnimSprite_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudGameOpeningManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowAnimSprite_003Ed__37(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public UISprite topBg;

	public UISprite bottomBg;

	public UILabel mapTxt;

	public UILabel dateTxt;

	public UILabel matchText;

	public UISprite tweenTopBg;

	private TweenPosition TopTween;

	public UISprite tweenBottomBg;

	private TweenPosition bottomTween;

	public Transform uiRoot;

	public GameObject animSprite;

	public GameObject startEffect;

	public GameObject endEffect;

	public GameObject rankingText;

	private UILabel[] m_Labels;

	private TypewriterEffect[] m_Writers;

	private int m_WriterIndex;

	private uint m_DelayCallId;

	private uint m_DelayShowAirlineTipsId;

	private AudioResource m_TypeWriterSound;

	private UIhudBossOniPopupController m_BossOniPopupController;

	private uint m_DelayShowEighthOnBoardTipsID;

	private UIHUDEighthOnBoardTipsController m_EighthOnBoardTipsController;

	private uint m_DelayShowDiwali25GPGameOpeningTipID;

	private uint m_DelayShowSFRoleplayOnBoardID;

	private uint m_DelayShowTreasureHuntOnBoardID;

	private uint m_DelayShowWL25GPOnBoardTipsID;

	private uint m_DelayShowCarni25GPOnBoardTipsID;

	private uint m_DelayShowBlueTearsGPOnBoardTipsID;

	private uint m_DelayShowGB_GPOnBoardTipsID;

	private uint m_DelayShowBloodmoonGPOnBoardTipsID;

	private uint m_DelayShowNinthGPOnBoardTipsID;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void SetUIData()
	{
	}

	private void EnableTypeWriter()
	{
	}

	private IEnumerator ShowAnimSprite()
	{
		return null;
	}

	private void ShowTween(object[] data)
	{
	}

	public void OnTypeWriterEffectFinished()
	{
	}

	private void resizeParticleShapeSize(GameObject effectGo)
	{
	}

	private void OnTweenFinish()
	{
	}

	private void ShowAirlineCurveTips()
	{
	}

	private void ShowEighthOnBoardTips()
	{
	}

	private void ShowSFRoleplayOnBoard()
	{
	}

	private void ShowWL25GPOnBoardTips()
	{
	}

	private void ShowTreasureHuntOnBoardTips()
	{
	}

	private void ShowCarni25GPOnBoardTips()
	{
	}

	private void ShowBlueTearsGPOnBoardTips()
	{
	}

	private void ShowGB_GPOnBoardTips()
	{
	}

	private void ShowBloodmoonGPOnBoardTips()
	{
	}

	private void ShowNinthGPOnBoardTips()
	{
	}

	private void OnOpeningEnd(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
