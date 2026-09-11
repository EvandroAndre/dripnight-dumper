using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILaunchTagFrameController : UIBaseController, IUIModelDataChangeObserver
{
	public enum EStyle
	{
		Invalid,
		All,
		Icon_Number,
		OnlyIcon
	}

	private sealed class _003CStartNumberRoll_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILaunchTagFrameController _003C_003E4__this;

		public uint start;

		public uint end;

		private float _003ClerpValue_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartNumberRoll_003Ed__53(int _003C_003E1__state)
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

	public static readonly string UNKNOWN;

	public static readonly string REACH_LIMIT;

	public static readonly string FORMAT;

	public static readonly string ANIM_GACHA_IN;

	public static readonly string ANIM_GROUP_IN_COMMON;

	public static readonly string ANIM_GROUP_IN_CITYHERO;

	public static readonly string ANIM_GROUP_IN_EASTERRABBIT;

	public static readonly string ANIM_TOKENTOWERNEW_IN;

	public static readonly string ANIM_GROUP_IN_WINTERLAND;

	public static readonly string ANIM_TOKENTOWERNEW_IN_WINTERLAND;

	public static readonly string ANIM_GACHA_FEATURE_IN_ECLIPSE;

	public static readonly string ANIM_GROUP_IN_ECLIPSE;

	public static readonly string ANIM_TOKENTOWERNEW_IN_ECLIPSE;

	public const uint LAUNCH_TAG_LIMIT = 999999u;

	public const uint DIGIT_LIMIT = 6u;

	private const float LERP_TIME = 3f;

	private UIModelInventory m_ModelInventory;

	private EStyle m_Style;

	private UILaunchTagFrameView m_View;

	private uint m_TagID;

	private bool m_IsCommonLaunchTag;

	private bool m_IsOwned;

	private bool m_ButtonEnable;

	private uint m_SerialNumber;

	private bool m_CoroutineNotFinish;

	private uint m_CoroutineTargetNumber;

	private Coroutine m_Coroutine;

	private UILaunchTagHelper m_Helper;

	private GameObject m_TagObj;

	private ResourceID m_TagResID;

	public Transform ExternResRoot;

	public string LogClickFrom;

	private Transform ResRoot => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void LoadResByTagID()
	{
	}

	private void OnBtnClick()
	{
	}

	private void ShowIntroduceWnd()
	{
	}

	public void SetViewByTagID(uint id, bool owned, uint serialNumber = uint.MaxValue, bool requestServerData = true)
	{
	}

	public void SetBottomKeyText(bool isOwnedText)
	{
	}

	private void SetNumberText(uint serialNumber)
	{
	}

	public void SetStyle(EStyle eStyle, bool force = false)
	{
	}

	public void EnableButton(bool enable)
	{
	}

	public void PlayAnim(bool isEnterGroup)
	{
	}

	private bool PlaySpecialGachaFeatureInAnim()
	{
		return false;
	}

	private bool PlaySpecialEnterGroupAnim()
	{
		return false;
	}

	public void PlayTokenTowerNewAnim()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RequestServerProgress()
	{
	}

	private void OnServerProgressUpdate()
	{
	}

	public IEnumerator StartNumberRoll(uint start, uint end)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
