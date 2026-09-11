using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventTopBtnBaseController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public UIBigEventTopBtnBaseController _003C_003E4__this;

		public uint tokenId;

		public Transform tipPos;

		internal void _003CInitTokenBtn_003Eb__0()
		{
		}
	}

	private UIBigEventTopBtnBaseView m_View;

	protected BigEventTopBtnData m_TopBtnData;

	protected EventDelegate.Callback m_OnBtnClose;

	private UIModelBigEvent m_ModelBigEvent;

	public uint SugarTokenCacheNum;

	protected Action<uint, Vector3> mOnClickTokenCallback;

	public UIBigEventTopBtnBaseView BaseView
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(BigEventTopBtnData topBtnData, EventDelegate.Callback onBtnClose, Action<uint, Vector3> tokenTipsCallback = null)
	{
	}

	private void InitTokenBtn(uint tokenId, UISprite tokenSprite, UIButton btnToken, UILabel tokenCount, Transform tipPos)
	{
	}

	public virtual uint GetTokenCount(uint tokenId)
	{
		return 0u;
	}

	public virtual string GetTokenClickSoundId()
	{
		return null;
	}

	private void OnTokenTipClick(uint tokinId, Transform trans)
	{
	}

	private void OnGoPosBtnClick()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CSetViewData_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
