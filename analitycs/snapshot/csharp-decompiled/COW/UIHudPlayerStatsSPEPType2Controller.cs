using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerStatsSPEPType2Controller : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public bool fromHideToShow;

		internal void _003CRefreshSP_003Eb__0(bool changed)
		{
		}
	}

	private UIHudPlayerStatsSPEPType2View m_View;

	private Player m_Player;

	private uint m_HideEPNodeDelayCall;

	private bool m_IsShowMushroomEp;

	private int MushroomEp;

	private UGC_CommonHudSwitchController.ESwitchValue m_IsEPNodeVisibilityByUGC;

	private List<UIHudPlayerEPItem> m_CachedEPItemList;

	private Vector3 m_EPPos;

	private int m_CurActiveEPItemCnt;

	private UIFXProgressHelper m_PersonaEPUp;

	private UIFXProgressHelper m_PersonaEPDown;

	private float m_BloodPoolUseEpMarkDefaultX;

	private bool m_ShowSP;

	private List<UIHudPlayerSPItem> m_CachedItemList;

	private Vector3 m_SPPos;

	private int m_CurActiveItemCnt;

	private int m_HPBarWidth;

	private float m_MaxItemWidth;

	private const int INTERVAL_PER_ITEM = 2;

	private UIHudPlayerSPItem.ESPEffectType m_SPEffectType;

	private float m_SPEffectTime;

	private uint m_SPDelta;

	private const float SP_UP_EFFECT_TIME = 2f;

	private const float SP_DOWN_EFFECT_TIME = 0.4f;

	private const uint SP_LABEL_PERM_COLOR = 4282304767u;

	private const uint SP_LABEL_TEMP_COLOR = 4285459967u;

	private UIHudPlayerStatsController m_ParentCtrl;

	private UIHudPlayerSPItem.ESPVisualType m_SPVisualType;

	private VisualInstanceHolder m_EPBarInfiniteHealerEpVfx;

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

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private void Update()
	{
	}

	private void UpdateSPVisualType()
	{
	}

	public void CancelDelayCall()
	{
	}

	private void OnMushRoomDataChange(object[] data)
	{
	}

	private void OnMushRoomEpChange(bool data)
	{
	}

	private void OnPlayerPersonaEPStateChanged(uint playerID)
	{
	}

	public GameObject GetEPNode()
	{
		return null;
	}

	public void HideEPByUGC(UGC_CommonHudSwitchController.ESwitchValue switchValue)
	{
	}

	public void ShowHideEPNode(bool flag, bool directSet = false)
	{
	}

	private void RefreshNodeHeightBySPEP(bool currentShow)
	{
	}

	private void RefreshMushroomEp()
	{
	}

	public void RefreshEP(bool directSet = false)
	{
	}

	private void RefreshBloodPoolEPMark()
	{
	}

	private void RefreshPersonaEPEffect()
	{
	}

	private void OnShowMushroomEpTutorial(object[] param)
	{
	}

	private void OnShowEPChangeTutorial(object[] param)
	{
	}

	public void ShowEighth_GP_InfiniteHealerEpVfx(bool show)
	{
	}

	private void OnShieldRecoverSpChanged(object[] data)
	{
	}

	private void OnPersonaBreakSP(GEvent evt)
	{
	}

	public void InitHPBarWidth(int width, float x)
	{
	}

	public void RefreshSP(uint type = 0u, uint newValue = 0u, uint oldValue = 0u)
	{
	}

	private Vector3 GetSPNodeCenterPos()
	{
		return default(Vector3);
	}

	private void UpdateSpEffect()
	{
	}

	public Color GetTempLabelColor()
	{
		return default(Color);
	}

	public Color GetPermLabelColor()
	{
		return default(Color);
	}

	private void _003CShowHideEPNode_003Eb__42_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
