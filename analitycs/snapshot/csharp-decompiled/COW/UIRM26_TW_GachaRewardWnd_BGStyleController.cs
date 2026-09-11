using GCommon;
using UnityEngine;

namespace COW;

public class UIRM26_TW_GachaRewardWnd_BGStyleController : UIBaseController
{
	public UIRM26_TW_GachaRewardWnd_BGStyleView m_View;

	protected Vector3 m_RewardGridPos;

	protected Vector3 m_ButtomPos;

	protected bool m_ShowBtns;

	private const float STANDARD_ITEM_MAXB_HALFHEIGHT = 86f;

	public bool ShowBtns => false;

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

	public virtual void GetRewardGridPosAndPivot(out Vector3 pos, out UIWidget.Pivot? pivot)
	{
		pos = default(Vector3);
		pivot = null;
	}

	public virtual Vector3 GetExtraItemPos()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetAutoOpenBoxBundleVFXPos()
	{
		return default(Vector3);
	}

	public Vector3 GetBottomPos()
	{
		return default(Vector3);
	}

	public virtual void SetUserData(object userData)
	{
	}

	protected virtual string GetGuideBtnSpriteName()
	{
		return null;
	}

	protected virtual string GetNormalBtnSpriteName()
	{
		return null;
	}

	protected virtual UIAtlas GetGuideBtnSpriteAtlas()
	{
		return null;
	}

	protected virtual UIAtlas GetNormalBtnSpriteAtlas()
	{
		return null;
	}

	public virtual void AdjustBtnStyle(bool GuideOnLeft = false)
	{
	}

	public virtual Color GetFastEquipDisableColor()
	{
		return default(Color);
	}

	public virtual void OnLastWndOpen()
	{
	}

	public virtual void OnNavigationBack()
	{
	}

	public virtual void OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
