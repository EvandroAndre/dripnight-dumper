using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryTagController : UIBaseController
{
	public enum UIType
	{
		None,
		NewCSShopWeaponDetail,
		Inventory,
		InGameShopItemDesc
	}

	private Camera m_Camera;

	private UICamera m_UICamera;

	private float dist;

	public string TagDesc;

	public int MinLabelWidth;

	public int MaxLabelWidth;

	public bool m_IsPressing;

	private UIHudInventoryTagView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void Reset()
	{
	}

	public void OnRecycle()
	{
	}

	public void OnReInit()
	{
	}

	public void SetViewData(WeaponTagInfoData data, UIType uiType = UIType.None)
	{
	}

	public void SetViewData(HENEHAGJCLI data)
	{
	}

	public UIButton GetBtnForGuide()
	{
		return null;
	}

	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	public float GetTagLeftPosX()
	{
		return 0f;
	}

	private bool CheckPos(Vector2 pos)
	{
		return false;
	}

	private bool CheckPcTouch(Vector3 pos)
	{
		return false;
	}

	private void OnPress()
	{
	}

	private void OnRelease()
	{
	}

	private void TryGetCameraComponent()
	{
	}

	private void Update()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
