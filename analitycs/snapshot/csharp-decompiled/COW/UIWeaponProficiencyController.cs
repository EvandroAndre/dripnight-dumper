using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponProficiencyController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	public enum Pin
	{
		Pinned = 1,
		CancelPinned
	}

	public enum PinView
	{
		Main = 1,
		WeaponList
	}

	private sealed class _003CResetWeapon_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponProficiencyController _003C_003E4__this;

		private Quaternion _003Clerproate_003E5__2;

		private float _003Ctime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetWeapon_003Ed__79(int _003C_003E1__state)
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

	private UIWeaponProficiencyView m_View;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelWeaponPower m_ModelWeaponPower;

	private uint m_CurrentPopMenuType;

	private uint m_CurrentWeaponId;

	private UIPopMenuSmallControler m_PickScreenPopMenu;

	private UIWeaponProficiencyProgressBarV2Controller m_ProgressBarV2Ctrl;

	private List<GameObject> m_GoVfxLevel;

	private List<GameObject> m_GoVfx;

	private List<GameObject> m_GoVfxUpgrade;

	private GameObject m_GoVfxV2Upgrade;

	private GameObject m_GoVfxV2;

	private List<UIWeaponProficiencyProgressBarItemController> m_ProgressBarItem;

	private GameObject m_PreviewWeaponObj;

	private GameObject m_PreviewVfxObj;

	private Coroutine m_RotateWeaponCoroutine;

	private const float m_RotateRate = 0.5f;

	private GameObject m_ItemCameraGo;

	private Camera m_ItemCamera;

	private float m_PreviewItemPosX;

	private uint m_SkinId;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonController;

	public static readonly List<Type> InterestedModels;

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

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void ShowUpgreadeVfx()
	{
	}

	private void ShowV2UpgradeVfx()
	{
	}

	private void OnAnimEvent(object[] data)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public static void BeforeInit()
	{
	}

	public void SetViewData(uint weaponId, bool setCurrentPopMenuTab = true)
	{
	}

	public bool GetCanShowBtnJmpToWeaponLeaderboard()
	{
		return false;
	}

	public void RefreshView(bool IsResetPickItem = true)
	{
	}

	private void RefreshJmpToArmory()
	{
	}

	private void RefreshWeaponPower()
	{
	}

	private void RefreshTypeScreen()
	{
	}

	private void RefreshRank()
	{
	}

	private void RefreshLevelUpButton()
	{
	}

	private int ComparePickItem(uint weaponIdX, uint weaponIdY)
	{
		return 0;
	}

	private void ResetWeaponPickItems()
	{
	}

	private void RefreshPin()
	{
	}

	private void RefreshProgressBar()
	{
	}

	private void RefreshCenterWeapon()
	{
	}

	private void RefreshWeaponVfx()
	{
	}

	private void OnClickBtnJmpToArmory()
	{
	}

	private void OnClickBtnJmpToWeaponLeaderboard()
	{
	}

	private void OnClickBtnPin()
	{
	}

	private void OnClickBtnShare()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnClickBtnLevelup()
	{
	}

	private void OnWeaponSelected(object[] data)
	{
	}

	private void OnTypeSelected(uint popMenuType)
	{
	}

	private void OnRefreshEventTrigger(object[] data)
	{
	}

	private void OnChangeToV2Bar(object[] data)
	{
	}

	private void ChangeLayer(Transform transform, int layer)
	{
	}

	private bool CanJmpToArmory()
	{
		return false;
	}

	private void SetShareBgView(bool shareView)
	{
	}

	private string GetValText(uint val)
	{
		return null;
	}

	private void GenerateGameModeMenuData()
	{
	}

	private List<PopMenuData> GetPopMenuDataList()
	{
		return null;
	}

	private uint GetDefaultWeaponIdByType(uint popMenuType)
	{
		return 0u;
	}

	private void PrepareProgressBar()
	{
	}

	private void Refresh3dWeapon(uint weaponId)
	{
	}

	protected void OnDraging(GameObject go, Vector2 delta)
	{
	}

	private void OnDragStart(GameObject gameObject)
	{
	}

	private void OnDragEnd(GameObject gameObject)
	{
	}

	private IEnumerator ResetWeapon()
	{
		return null;
	}

	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool useY = false, float scaley = 0.5f, bool isAvatar = false)
	{
	}

	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY)
	{
	}

	private void AutoGen3DPreviewCollider(GameObject go)
	{
	}

	private bool CheckInvaildCollider(Renderer render)
	{
		return false;
	}

	private bool _003CRefreshTypeScreen_003Eb__48_0(PopMenuData x)
	{
		return false;
	}

	private int _003CResetWeaponPickItems_003Eb__52_0(uint x, uint y)
	{
		return 0;
	}

	private void _003CGetPopMenuDataList_003Eb__72_0(object obj)
	{
	}

	private void _003CGetPopMenuDataList_003Eb__72_1(object obj)
	{
	}

	private int _003CGetDefaultWeaponIdByType_003Eb__73_0(uint x, uint y)
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
