using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFloatingLandMiniMapController : UIBaseController
{
	private class EnemyCtrl : MonoBehaviour
	{
		private float m_showDuration;

		public void Show(float duration)
		{
		}

		private void Update()
		{
		}
	}

	private class ColorDrumCtrl
	{
		private GameObject m_obj;

		private LevelFloatingLandColorDrums m_drum;

		public ColorDrumCtrl(GameObject obj, LevelFloatingLandColorDrums drum)
		{
		}

		public void Update()
		{
		}
	}

	private class DetectEnemyCtrl : MonoBehaviour
	{
		private float m_showDuration;

		public void Show(float duration)
		{
		}

		private void Update()
		{
		}
	}

	private UIHudFloatingLandMiniMapView m_View;

	private LevelFloatingLand m_floatingLand;

	private Player m_localPlayer;

	private Vector3 m_landPos;

	private Vector2 m_landScale;

	private Dictionary<uint, GameObject> m_teammateObjs;

	private Dictionary<uint, EnemyCtrl> m_enemyObjs;

	private List<ColorDrumCtrl> m_colorDrums;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnMapBtnClick()
	{
	}

	private void Update()
	{
	}

	public Vector2 ProjectToMapOffset(Vector3 pos)
	{
		return default(Vector2);
	}

	public Quaternion ProjectToAngel(Vector3 forward)
	{
		return default(Quaternion);
	}

	protected override void OnUIDestory()
	{
	}

	private void OnSomeoneFiring(GEvent param)
	{
	}

	private void OnDetectiveMarkEnemy(object[] data)
	{
	}

	private void OnHideFloatingLand(object[] data)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
