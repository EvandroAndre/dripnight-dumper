using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class PreviewStoryCgShowUIComp : UIBaseController
{
	private sealed class _003CSetSharePreviewPos_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PreviewStoryCgShowUIComp _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetSharePreviewPos_003Ed__22(int _003C_003E1__state)
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

	private PreviewStoryCgComp m_StoryCgInstance;

	public UIButton m_Sharebtn;

	public UIButton m_Replaybtn;

	public UIButton m_Funcbtn;

	public UITexture m_BgTex;

	public UILabel m_FunTxt;

	private bool m_isLevelup;

	private bool m_ShowFuncBtn;

	public GameObject Eppanel;

	public GameObject MallPanel;

	public GameObject GachaPanel;

	public UILabel Subtitle;

	public UILabel ContinueLabel;

	public void SetStoryCGInstance(PreviewStoryCgComp ins)
	{
	}

	public void InitShowUI(bool isHas, bool showFuncBtn = true)
	{
	}

	public void PlaySubtitle(string subtitleStr)
	{
	}

	public void StopSubtitle()
	{
	}

	protected bool CheckItemIsBuy(uint itemid)
	{
		return false;
	}

	protected override void Awake()
	{
	}

	private void OnbtnShare()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private IEnumerator SetSharePreviewPos()
	{
		return null;
	}

	private void OnbtnReplay()
	{
	}

	private void ClearStoryCG()
	{
	}

	private void OnbtnFunc()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
