using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSAreaTipsController : UIBaseController
{
	private UINinthSYSAreaTipsView m_View;

	private GameObject m_CurrentActiveGo;

	private uint m_DelayPreCallKey;

	private uint m_DelayCallKey;

	private readonly float Duration;

	private readonly float DelayDuration;

	private uint m_PendingTipsType;

	private uint m_CurrentTipsType;

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

	public void SocialLobbyTips(uint data)
	{
	}

	private bool TryGetTipsGo(uint tipsType, out GameObject tipsGo)
	{
		tipsGo = null;
		return false;
	}

	private bool IsNeedShowTips(uint tipsType)
	{
		return false;
	}

	private void SaveShowTips(uint tipsType)
	{
	}

	private void ClearDelayCall()
	{
	}

	private void OnPreDelayCallBack()
	{
	}

	private void ShowTips(uint tipsType, GameObject tipsGo)
	{
	}

	private void HideAllTips()
	{
	}

	private void OnDelayCallBack()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
