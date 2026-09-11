using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerMarkIcon : UIBaseController
{
	public UISprite m_Icon;

	public UILabel m_PlayerTeamIndex;

	public GameObject m_EnemyIcon;

	public Transform m_ScaleRoot;

	public Animation m_InteractingIconAnimation;

	public UISprite m_InteractingIcon1;

	public UISprite m_InteractingIcon2;

	public UISprite m_InteractingIcon3;

	public UISprite m_InteractingIcon4;

	public UISprite m_InteractingAnimIcon;

	private Vector3 m_pos;

	private float m_DefaultInteractingIconX;

	private float m_DefaultInteractingIconY;

	private UIHudPlayerMarkWinterlandController m_WinterlandMarkCtrl;

	private uint m_ParachuteLeaderMarkEffect;

	private uint m_PosType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ForceHide()
	{
	}

	private void ForceHide(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetInfo(int playerTeamIndex, byte teamId, Vector3 realPos, uint posType = 0u, float scale = 1f)
	{
	}

	private void SetInteractingIconPos(uint posType)
	{
	}

	private void SetScale(float scale)
	{
	}

	public bool IsLineEffectPosType()
	{
		return false;
	}

	private void OnMarkObjectStateChanged(object[] data)
	{
	}

	public void UpdatearachuteLeaderMarkEffect(bool b)
	{
	}

	private void ResetPointUI()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
