using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UISeasonReplayDestinyWeaponItemController : UIBaseController
{
	private sealed class _003CResetWeapon_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UISeasonReplayDestinyWeaponItemController _003C_003E4__this;

		private Quaternion _003Clerproate_003E5__2;

		private float _003Ctime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetWeapon_003Ed__25(int _003C_003E1__state)
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

	private float ModelPosX;

	private float ModelPosY;

	private Camera m_Camera;

	private UIWidget m_PreviewBorder;

	private GameObject m_EvtListener;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private Coroutine m_RotateWeaponCoroutine;

	private GameObject m_PreviewWeaponObj;

	private EDestinyWeaponType m_PreviewType;

	private uint m_PreviewWeaponId;

	private float m_ScaleCoefficient;

	private const float RotateRate = 0.5f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetPreviewCamear(Camera cam)
	{
	}

	public void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	public void SetEventListener(GameObject evtListener)
	{
	}

	public void ShowPreview(uint weaponId, EDestinyWeaponType type, float scaleTimes = 1f)
	{
	}

	public void ShowPreview()
	{
	}

	public void ClosePreview()
	{
	}

	private void OnDragStart(GameObject gameObject)
	{
	}

	private void OnDraging(GameObject go, Vector2 delta)
	{
	}

	private void OnDragEnd(GameObject gameObject)
	{
	}

	private IEnumerator ResetWeapon()
	{
		return null;
	}

	private void Refresh3dWeapon(uint weaponId)
	{
	}

	private void ReadConfig(ref GameObject go)
	{
	}

	private void CalculateModelPos(UIWidget previewBorder)
	{
	}

	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool calculateYPos = false, float scaley = 0.5f, float offsetX = 0f)
	{
	}

	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY, float offsetX = 0f)
	{
	}

	private void AutoGen3DPreviewCollider(GameObject go)
	{
	}

	private bool CheckInvaildCollider(Renderer render)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
