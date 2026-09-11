using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICreateCharacterController : UIBaseController, IUIModelDataChangeObserver
{
	public enum ErrorNameType
	{
		DuplicateName,
		DirtyName
	}

	private sealed class _003CCloseUICoroutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public UICreateCharacterController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseUICoroutine_003Ed__20(int _003C_003E1__state)
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

	private UICreateCharacterView m_View;

	private UIFFLogoController m_UIFFLogoCtrl;

	private uint m_AvatarId;

	private const string m_EnterAnimName = "FF_Renamed_Admission_ani";

	private const string m_ExitAnimName = "FF_Renamed_Appearance_ani";

	private uint m_DelayCallFinishHide;

	private float m_FinishWaitingDuration;

	private string m_UserInputName;

	private uint m_AvatarIdTmp;

	private Color PlaceHolderColor;

	private ulong StartTimeStamp;

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

	protected override void OnUIDestory()
	{
	}

	public void SetNickNameAndID(string nickName, ulong accountId)
	{
	}

	private void InitFFLogo()
	{
	}

	public void PlayEnterAnim()
	{
	}

	public void FinishAndClose()
	{
	}

	private IEnumerator CloseUICoroutine(float delay)
	{
		return null;
	}

	private void OnInputChange()
	{
	}

	private void SetNickNameErrMessage(string errMessage)
	{
	}

	private void OnRegisterClick()
	{
	}

	public void OnGenerateNickName(object[] param)
	{
	}

	public void OnErrorUsername(object[] param)
	{
	}

	private void OnUseClick()
	{
	}

	public void CreateRandomName()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
