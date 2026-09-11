using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudWolfHPController : UIHudNameBaseController
{
	private UIHudWolfHPView m_View;

	private BHGGAEEHJCO m_BindAIID;

	private NetworkAIPawn m_BindAI;

	private float m_Counter;

	private int m_LastDisplayedHP;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public void BindAI(BHGGAEEHJCO aiId)
	{
	}

	public void UnbindAI()
	{
	}

	public void OnHpChanged(int oldHP, int curHP, int maxHP)
	{
	}

	public void RefreshShowTime()
	{
	}

	private void Update()
	{
	}

	private void TrySyncDeadWolfHp()
	{
	}

	private void SyncHpFromBindAI()
	{
	}

	private void SetHpBarFill(float fillAmount)
	{
	}

	private void ClearAndHideHpBar()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
