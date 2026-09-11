using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudItemSearchMarkController : UIHudNameBaseController
{
	private sealed class _003CMarkLineCoroutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISprite targetLine;

		public UIHudItemSearchMarkController _003C_003E4__this;

		private float _003Cspeed_003E5__2;

		private float _003Cpercent_003E5__3;

		private int _003CendLength_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMarkLineCoroutine_003Ed__33(int _003C_003E1__state)
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

	public static float auto_find_items_distance_total;

	public static int auto_find_items_pickup_total;

	private UIHudItemSearchMarkView m_View;

	private Transform m_DistTrans;

	private Vector3[] m_DistPosArray;

	private Transform m_Transform;

	private Transform m_ContainerTrans;

	public float SqrAlphaThreshold;

	private int m_PickupLineLen;

	private Vector3 m_BindWorldPosition;

	private Vector2 m_SelfBound;

	private float m_DistanceValue;

	private uint m_DelayHideID;

	private float m_DistanceWhenMarking;

	private const float HideThreshold = 100f;

	private uint m_ItemDataID;

	private uint m_ItemID;

	private uint m_ItemContainerID;

	private bool m_ItemPickuped;

	private bool m_ItemPickupedBySelf;

	private bool m_HideForNoUpdate;

	private uint m_DelayAttackShow;

	private bool m_MatchEnd;

	private bool m_ShowState;

	private bool m_IsHideByAttackOrBeHit;

	private bool m_IsHideBySighting;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshTeammateEighthIcon(uint PlayerID, uint iconType)
	{
	}

	private void RefreshEightInLandState()
	{
	}

	private void RefreshIIV1v1BattleSceneLikeHUD(GEvent data)
	{
	}

	private void RefreshIIVFloatingLandHUD(uint PlayerID, uint joinTime)
	{
	}

	public void SetViewData(uint itemDataID, Vector3 targetPosition, uint itemID, uint containerID)
	{
	}

	private IEnumerator MarkLineCoroutine(UISprite targetLine)
	{
		return null;
	}

	public void ItemPickupByOthers(uint itemDataID, uint itemID)
	{
	}

	public void ItemPickupBySelf(uint itemDataID, uint itemID)
	{
	}

	public void ItemRejectedByTeamMark(uint itemDataID, uint containerID)
	{
	}

	public void StopBySelf()
	{
	}

	public void StopBySystem(uint itemDataID, uint itemID)
	{
	}

	public void HideForAttackOrBeHit()
	{
	}

	private void ShowForAttackOrBeHit()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
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

	protected override void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	private void ForceHide(object[] data)
	{
	}

	private void ResetUI()
	{
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
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

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	protected override void OnTrainingZoneChanged(object[] param)
	{
	}

	protected override float GetScaleFactorDefault()
	{
		return 0f;
	}

	protected override float GetScaleFactorDeltaChangeByMetre()
	{
		return 0f;
	}

	private void OnClickMarkIcon()
	{
	}

	private void _003COnUIInit_003Eb__27_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
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

	public void _003C_003EiFixBaseProxy_OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE P0)
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

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
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

	public void _003C_003EiFixBaseProxy_OnTrainingZoneChanged(object[] P0)
	{
	}

	public float _003C_003EiFixBaseProxy_GetScaleFactorDefault()
	{
		return 0f;
	}

	public float _003C_003EiFixBaseProxy_GetScaleFactorDeltaChangeByMetre()
	{
		return 0f;
	}
}
