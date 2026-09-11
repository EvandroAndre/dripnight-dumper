using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal abstract class UIHGSnowDifficultySelectionBaseItemController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CPlayClickAnim_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionBaseItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayClickAnim_003Ed__45(int _003C_003E1__state)
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

	private sealed class _003CPlayUnlockAnim_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionBaseItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayUnlockAnim_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003CSelectDifficulty_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHGSnowDifficultySelectionBaseItemController _003C_003E4__this;

		private UIHGSnowDifficultySelectionController _003CparentCtrl_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSelectDifficulty_003Ed__46(int _003C_003E1__state)
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

	protected UIModelHuntingGround.HuntingGroundMissionData m_Data;

	protected UIModelHuntingGround m_Model;

	protected UIModelMapOpeningInfo m_ModelMap;

	protected UIModelOptionalDownload m_ModelDownload;

	protected MapModeData m_MapModeData;

	protected UINewDownloadInfoController m_Downloader;

	protected bool m_IsGroupUnlock;

	protected UINetworkTexture CdnBg;

	protected UISprite SpriteAward;

	protected UILabel RecordTitle;

	protected UILabel RecordValue;

	protected UIButton BtnRecord;

	protected UILabel LabelDifficultyName;

	protected UIButton BtnSelectDifficulty;

	protected GameObject Record;

	protected UIButton BtnAward;

	protected GameObject Selected;

	protected Animation ClickAnim;

	protected Animation MainAnim;

	protected Animation UnlockAnim;

	protected GameObject LockEffect;

	protected GameObject UnlockEffect;

	protected GameObject LabelNodata;

	protected UIWidget GuideWidget;

	protected Transform DownloaderConatainer;

	protected GameObject AwardEffect;

	protected UINetworkTexture LockCdnBg;

	protected TweenRotation AwardAnim;

	protected UISprite Bg;

	protected UISprite Line;

	protected AnimatedAlpha Alp;

	protected bool m_NeedDownloadController;

	private static readonly string[] ITEM_BGS;

	private static readonly uint[] ITEM_BG_COLOR;

	protected override void OnUIInit()
	{
	}

	protected abstract void InitView();

	public void SetBgByIndex(int index)
	{
	}

	public virtual void SetViewData(UIModelHuntingGround.HuntingGroundMissionData data)
	{
	}

	private void UpdateDownloadList()
	{
	}

	protected void TryDownloadMapRes()
	{
	}

	private void RefreshAward()
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public UIButton GetGuideBtn()
	{
		return null;
	}

	public void PlayMainAnim()
	{
	}

	private IEnumerator PlayUnlockAnim()
	{
		return null;
	}

	private IEnumerator PlayClickAnim()
	{
		return null;
	}

	protected IEnumerator SelectDifficulty()
	{
		return null;
	}

	private void OnItemClick(uint difficulty, uint gamemode)
	{
	}

	private void OnBtnRecordClick()
	{
	}

	protected abstract void OnBtnSelectDifficultyClick();

	private void OnBtnAwardClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
