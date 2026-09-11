using System;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityEighthSignetItemController : UIActivityContentController
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public uint subTypeId;

		internal bool _003CGetCdnUrl_003Eb__0(AdvertDesc e)
		{
			return false;
		}
	}

	protected const string ActivityGetHit = "T_49_ZP_EIGHTH_SIGNET_SYS_GETEGG";

	private UIActivityEighthSignetItemView m_View;

	private UIActivityEighthSignetItemContentController.Data m_Data;

	private UIActivityEighthSignetItemContentController.State m_PageState;

	private EActivity.State m_ActivityState;

	private EActivity.State m_ActivitySpecialState;

	private UIModelActivity.ActivityOperateStatus m_OperateStatus;

	private uint DelayCallID;

	private bool m_Complete;

	private UIModelActivity m_Model;

	private uint m_ShowFirstMission;

	private Action m_GuideCallback;

	public const uint CDN_SIGNET_ITEM_BG = 20250007u;

	public const uint CDN_SIGNET_DETAIL_BG = 20250008u;

	public const uint CDN_SHARE_ITEM_NEW = 20250021u;

	protected static readonly Vector3 EggInfoPosLeft;

	protected static readonly Vector3 EggInfoPosRight;

	public GameObject RootObject => null;

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

	public void SetData(UIActivityEighthSignetItemContentController.Data data)
	{
	}

	protected void OnShowCdn()
	{
	}

	protected string GetCdnUrl(uint subTypeId)
	{
		return null;
	}

	protected string GetCdnUrl()
	{
		return null;
	}

	public void PlayShowAnimation(int index)
	{
	}

	public EActivity.State GetState()
	{
		return EActivity.State.State_RECEIVED;
	}

	public EActivity.State GetEggState()
	{
		return EActivity.State.State_RECEIVED;
	}

	public void SetEggData(ClientActivityDesc activityDesc)
	{
	}

	public uint GetActivityId()
	{
		return 0u;
	}

	public uint GetActivitySortId()
	{
		return 0u;
	}

	public uint GetActivityEggId()
	{
		return 0u;
	}

	public void RefreshItemState()
	{
	}

	private void OnShowFirstEffect()
	{
	}

	public void RefreshSpecialItemState()
	{
	}

	protected bool IsShowEggInfoRight()
	{
		return false;
	}

	protected virtual void OnOperate()
	{
	}

	protected virtual void OnClickItemMask()
	{
	}

	protected virtual void OnClickDetailMask()
	{
	}

	protected virtual void OnClickEggInfoMask()
	{
	}

	public UIWidget GetSightItemFingerItem()
	{
		return null;
	}

	public UIWidget GetSightItemFingerText()
	{
		return null;
	}

	public void SetGuideClickBack(Action callback)
	{
	}

	public override void Reload()
	{
	}

	public virtual void SetPageState(UIActivityEighthSignetItemContentController.State pageState)
	{
	}

	public virtual void UpdateActiveState()
	{
	}

	protected void UpdateChildDepth(Transform trans, int depth)
	{
	}

	protected void UpdateState()
	{
	}

	protected void UpdateEggState()
	{
	}

	protected void OnShowDetail()
	{
	}

	protected void OnShowSpecialInfo()
	{
	}

	private bool LoadImageFromUrl(UINetworkTexture uINetworkTexture, string strUrl)
	{
		return false;
	}

	public void LogClick(string posfix, uint acitivtyId = 0u)
	{
	}

	private bool _003CGetCdnUrl_003Eb__23_0(AdvertDesc e)
	{
		return false;
	}

	private bool _003CGetCdnUrl_003Eb__23_1(AdvertDesc e)
	{
		return false;
	}

	private bool _003CGetCdnUrl_003Eb__23_2(AdvertDesc e)
	{
		return false;
	}

	private void _003CPlayShowAnimation_003Eb__24_0()
	{
	}

	private void _003COnShowFirstEffect_003Eb__34_0()
	{
	}

	private void _003COnShowFirstEffect_003Eb__34_3()
	{
	}

	private void _003COnShowFirstEffect_003Eb__34_1()
	{
	}

	private void _003COnShowFirstEffect_003Eb__34_2()
	{
	}

	private void _003COnShowFirstEffect_003Eb__34_4()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
