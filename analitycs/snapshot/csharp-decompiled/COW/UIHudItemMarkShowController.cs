using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudItemMarkShowController : UIHudNameBaseController
{
	private class OkItem
	{
		public UISprite icon;

		public UILabel label;

		public int teamIndex;
	}

	private sealed class _003CMarkLineCoroutine_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite targetLine;

		public UIHudItemMarkShowController _003C_003E4__this;

		private float _003Cspeed_003E5__2;

		private float _003Cpercent_003E5__3;

		private int _003CendLength_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMarkLineCoroutine_003Ed__55(int _003C_003E1__state)
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

	private UIHudItemMarkShowView m_View;

	private Vector3 m_bindWorldPosition;

	private EMEFBBBEPDG _003CItemMarkType_003Ek__BackingField;

	private uint _003CItemMarkId_003Ek__BackingField;

	private uint _003CItemMarkObjectId_003Ek__BackingField;

	private string ItemMarkName;

	private Transform m_DistTrans;

	private Vector3[] m_DistPosArray;

	private Transform m_Transform;

	private Transform m_ContainerTrans;

	public float SqrAlphaThreshold;

	private int m_EnemyLineLen;

	private int m_PickUpLineLen;

	private float m_DistanceValue;

	private const float HideThreshold = 100f;

	private BHGGAEEHJCO m_PlayerID;

	private UISprite m_TargetLine;

	private Queue<OkItem> m_okItems;

	private bool m_showGuide;

	private bool m_isPointTypeMark;

	private bool m_showResponseEffect;

	private UIRevivePointMapIconController m_RevivePointCtrl;

	private UILockAirDropIconController m_LockAirDropCtrl;

	private UIHudTreasuryMarkShowController m_TreasuryCtrl;

	private UIMapContenBigItemIconController m_BigItemIconCtrl;

	private UIHudEnergyDeviceMapItemController m_EnergyDeviceCtrl;

	private uint m_ParachuteLeaderMarkEffect;

	private bool m_IsFloatingLandMark;

	private bool m_needCheckArea;

	private float m_playerEnterAreaHideTime;

	private float m_pinCheckDistance;

	private bool m_startCheckEnterArea;

	public EMEFBBBEPDG ItemMarkType
	{
		get
		{
			return _003CItemMarkType_003Ek__BackingField;
		}
		private set
		{
			_003CItemMarkType_003Ek__BackingField = value;
		}
	}

	public uint ItemMarkId
	{
		get
		{
			return _003CItemMarkId_003Ek__BackingField;
		}
		private set
		{
			_003CItemMarkId_003Ek__BackingField = value;
		}
	}

	public uint ItemMarkObjectId
	{
		get
		{
			return _003CItemMarkObjectId_003Ek__BackingField;
		}
		private set
		{
			_003CItemMarkObjectId_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLocalIIV1v1BattleChanged(bool inBattle)
	{
	}

	private void RefreshIIV1v1BattleState()
	{
	}

	private void OnLocalGB_GP_GulagBattleChanged()
	{
	}

	private void RefreshTeammateEighthIcon(uint PlayerID, uint iconType)
	{
	}

	private void RefreshEightInLandState()
	{
	}

	private void OnLocalPlayerPhysicsStateChange(GEvent data)
	{
	}

	private void OnMarkObjectStateChanged(object[] data)
	{
	}

	private bool NeedRefreshObject(OPICPDCLKAG levelObject)
	{
		return false;
	}

	private void ResetPointUI()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	private void UpdatearachuteLeaderMarkEffect(bool b)
	{
	}

	public void SetUIShowData(EMEFBBBEPDG markType, uint markId, string markName, uint levelObjectId, int teamIndex, Vector3 targetPosition, BHGGAEEHJCO playerID, bool playMarkSound)
	{
	}

	private ResourceID GetIconRes(OPICPDCLKAG levelOjbectType)
	{
		return default(ResourceID);
	}

	private IEnumerator MarkLineCoroutine(UISprite targetLine)
	{
		return null;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	private void ForceHide(object[] data)
	{
	}

	private void ForceHide()
	{
	}

	private void ResetUI()
	{
	}

	public void RemoveMarkUI(EMEFBBBEPDG markType, uint markId, uint levelObjectId)
	{
	}

	public void RemoveMarkUI()
	{
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override Vector4 GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	protected override void LateUpdate()
	{
	}

	protected override void OnDistanceChanged(float distance)
	{
	}

	protected override bool NeedOptDistanceUpdate()
	{
		return false;
	}

	protected override void OnDistanceLabelChanged()
	{
	}

	private void UpdateMarkAlpha()
	{
	}

	public void UpdateMarkVible()
	{
	}

	public bool CheckLocalPlayerAndMarkInSameArea()
	{
		return false;
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override void OnTrainingZoneChanged(object[] param)
	{
	}

	protected override void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	private void UpdateMarkPointVisible()
	{
	}

	private void OnMarkBtnClick(GameObject obj)
	{
	}

	private void OnRecvQuickChat(object[] data)
	{
	}

	private void InitCheckPlayerInArea()
	{
	}

	private void UpdateCheckPlayerInArea()
	{
	}

	private void ClearCheckPlayerInArea()
	{
	}

	private void UpdateJumpSuggest()
	{
	}

	public void OnRevivePointStateChanged(object[] param)
	{
	}

	public void OnRevivePointTimeChanged(object[] param)
	{
	}

	public void OnRevivePointAdvancedChanged(object[] param)
	{
	}

	private void OnLockAirDropIntStateChanged(object[] param)
	{
	}

	private void OnLockAirDropIntStepChanged(object[] param)
	{
	}

	private void OnLockAirDropIntTimeChanged(object[] param)
	{
	}

	private void OnInteractAreaStateChanged(GEvent param)
	{
	}

	private void OnInteractAreaTimeChanged(GEvent param)
	{
	}

	private void OnUpdateTreasuryState(object[] data)
	{
	}

	private bool RefreshSpecialMarkShowView(Vector3 poition, OPICPDCLKAG levelObjectType)
	{
		return false;
	}

	private bool RefreshLLevelObjectMarkShowView(OPICPDCLKAG levelObjectType, OGIJAGDFGAM levelObject)
	{
		return false;
	}

	private bool IsLLevelObject(OPICPDCLKAG levelObjectType)
	{
		return false;
	}

	private bool RefreshLevelObjectMarkShowView(OPICPDCLKAG levelObjectType, BaseLevelObject levelObject)
	{
		return false;
	}

	private OGIJAGDFGAM GetLLevelObjectByLevelObjectType(Vector3 position, OPICPDCLKAG levelObjectType)
	{
		return null;
	}

	private BaseLevelObject GetLevelObjectByLevelObjectType(Vector3 position, OPICPDCLKAG levelObjectType)
	{
		return null;
	}

	private void HideResponseEffect()
	{
	}

	private void ShowResponseEffect()
	{
	}

	private void OnAstrolGateRemoved(int objectID)
	{
	}

	private void OnCampFireRemoved(int objectID)
	{
	}

	private void OnMapThrowerSmokeRemoved()
	{
	}

	private void OnSpaceShieldRemoved(int objectID)
	{
	}

	private void SetTreasuryLocalPosition(EUIHudTreasuryMapState state)
	{
	}

	private void _003COnUIInit_003Eb__40_0()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
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

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}

	public Vector4 _003C_003EiFixBaseProxy_GetWidgetDirOffset()
	{
		return default(Vector4);
	}

	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDistanceChanged(float P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedOptDistanceUpdate()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDistanceLabelChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnTrainingZoneChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE P0)
	{
	}
}
