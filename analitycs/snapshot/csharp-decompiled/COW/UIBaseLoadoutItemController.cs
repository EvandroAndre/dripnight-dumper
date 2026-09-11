using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBaseLoadoutItemController : UIBaseController
{
	public UIModelLoadout m_ModelLoadout;

	public UIModelInventory m_ModelInventory;

	public uint LoadoutId;

	public Item PlayCardData;

	public BaseItemInfo LoadOutData;

	public UISprite ItemSprite;

	public UISprite EmptyMaskIcon;

	public GameObject EmptyMaskGameObject;

	public UILabel QuantityLabel;

	public UICountDownLabel PlayCardTime;

	public GameObject PlayCardContainer;

	public bool IsV2;

	public uint LoadoutV2Id;

	public UISprite LoadoutV2Sprite;

	public Transform EquipEffectContainer;

	public UISprite LoadoutV2LeftBg;

	public UISprite LoadoutV2RightBg;

	public UICountDownLabel V2ConutDown;

	private GameObject EquipEffect;

	private GameObject BgEffect;

	protected bool m_NeedEquipEffect;

	protected override void OnUIInit()
	{
	}

	private void ShowEquipEffect()
	{
	}

	protected virtual void InitView()
	{
	}

	public virtual void SetData(uint id, bool isV2 = false, uint id2 = 0u)
	{
	}

	public virtual void RefreshUI()
	{
	}

	protected virtual void OnFinishPlayCard()
	{
	}

	protected virtual void RefreshStateWithoutPlayCard()
	{
	}

	protected virtual void SetEmptyState()
	{
	}

	private bool _003CRefreshUI_003Eb__25_0(Item x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
