using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinCustomPopWndController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	public enum AttributeItemType
	{
		AttributeItem,
		SkillItem
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__90_0;

		internal void _003CSetHotFixTextShow_003Eb__90_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public UIWeaponSkinCustomPopWndController _003C_003E4__this;

		public uint sortType;

		internal int _003CRefreshAttributeList_003Eb__0(WeaponSkinBaseInfo a, WeaponSkinBaseInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_1
	{
		public bool hasCustom;

		public _003C_003Ec__DisplayClass62_0 CS_0024_003C_003E8__locals1;

		internal int _003CRefreshAttributeList_003Eb__1(WeaponSkinBaseInfo x, WeaponSkinBaseInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public List<WeaponScoreName> scoreNameList;

		public UIWeaponSkinCustomPopWndController _003C_003E4__this;

		public Action<object> _003C_003E9__2;

		internal int _003CGetPopMenuDataList_003Eb__0(uint x, uint y)
		{
			return 0;
		}

		internal void _003CGetPopMenuDataList_003Eb__1(object obj)
		{
		}

		internal void _003CGetPopMenuDataList_003Eb__2(object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass75_0
	{
		public UIWeaponSkinCustomPopWndController _003C_003E4__this;

		public WeaponSkinData skinData;

		internal void _003COnAppearanceItemClick_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public UIWeaponSkinCustomPopWndController _003C_003E4__this;

		public CSSharedItemData item_data;

		public List<ResourceID> res_list;

		internal void _003CSetHotFixTextShow_003Eb__1()
		{
		}
	}

	private sealed class _003CResetWeapon_003Ed__82 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWeaponSkinCustomPopWndController _003C_003E4__this;

		private Quaternion _003Clerproate_003E5__2;

		private float _003Ctime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetWeapon_003Ed__82(int _003C_003E1__state)
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

	private UIWeaponSkinCustomPopWndView m_View;

	private UIModelCollection m_ModelCollection;

	private UIModelRandomCollection m_ModelRandomCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelWeaponSkinCustom m_ModelWeaponSkinCustom;

	private UIPopMenuSmallControler m_AttributeSortFilter;

	private UINewDownloadInfoController m_DownloadCtrl;

	private bool m_IsItemABReady;

	private uint m_WeaponId;

	private uint m_WeaponSkinId;

	private uint m_WeaponPowerId;

	private uint m_UniqueId;

	private UICommonGuideController m_GuideCtrl;

	private bool m_isDuringGuide;

	private uint m_GuideDelayCall;

	private uint m_WeaponShowDelayCall;

	private uint m_WeaponSkillId;

	private bool m_IsOpenMultiSelect;

	private List<WeaponSkinBaseInfo> m_WeaponInfoList;

	private List<WeaponSkinBaseInfo> m_AfterSortAttributeList;

	private List<WeaponSkinBaseInfo> m_AfterSortAppearanceList;

	private const int ATTRIBUTE_LINE_COUNT = 1;

	private int m_SkillIndex;

	private int m_SecondSkillIndex;

	private uint m_FirstSkillId;

	private uint m_SecondSkillId;

	private const float m_RotateRate = 0.5f;

	private GameObject m_PreviewWeaponObj;

	private UIItemInputHandler m_ItemInputHandler;

	private Quaternion m_StopPos;

	private GameObject m_ItemCameraGo;

	private Camera m_ItemCamera;

	private Vector3 m_WeaponPos;

	private Vector3 m_StartWeaponPos;

	private TweenPosition m_WeaponTeen;

	private bool isFirstRefresh;

	private bool isAttributeFirstClick;

	private bool m_IsForceRefresh;

	private const uint DEFAULT_SORT = 99u;

	private uint m_CurrentSelectSortType;

	public List<uint> SortIndexsList;

	private int m_GuideStep;

	public uint WeaponPowerId => 0u;

	public uint WeaponSkillId => 0u;

	public bool IsOpenMultiSelect => false;

	public uint WeaponSkinId => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void InitData()
	{
	}

	private void InitCamera()
	{
	}

	private void InitWeaponList()
	{
	}

	private int SortAppearanceList(WeaponSkinBaseInfo x, WeaponSkinBaseInfo y)
	{
		return 0;
	}

	private void InitListTemplate()
	{
	}

	public void RefreshWeaponAfterOpenWnd()
	{
	}

	private void RefreshAttributeList(uint sortType = 99u)
	{
	}

	private void RefreshAppearanceList()
	{
	}

	private void InitMultiSelect()
	{
	}

	public void RefreshMultiSelectLabel()
	{
	}

	private void OnClickRandomCheckBoxBtn()
	{
	}

	private void GenerateAttributeMenuData()
	{
	}

	private List<PopMenuData> GetPopMenuDataList()
	{
		return null;
	}

	private void OnSortTypeSelected(uint popSortType)
	{
	}

	private float GetSkinAttributeScore(uint skinId, uint attributeTypeIndex)
	{
		return 0f;
	}

	protected override void OnUIDestory()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnHelpBntClick()
	{
	}

	private void OnSaveBtnClick()
	{
	}

	private void OnAppearanceItemClick(uint skinId)
	{
	}

	private void OnAttributeItemClick(object[] args)
	{
	}

	private void OnSkillItemClick(object[] args)
	{
	}

	private void OnRefreshEventTrigger(object[] data)
	{
	}

	protected void Ondraging(GameObject go, Vector2 delta)
	{
	}

	private void OndragStart(GameObject gameObject)
	{
	}

	private void OndragEnd(GameObject gameObject)
	{
	}

	private IEnumerator ResetWeapon()
	{
		return null;
	}

	private void Refresh3dWeapon(ResourceID model_id, bool isFirstCreate = false)
	{
	}

	private void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, float scaley = 0.5f, bool isAvatar = false)
	{
	}

	private void AutoShift3DPreview(ref GameObject go, float scalex, float scaley)
	{
	}

	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	private bool CheckInvaildCollider(Renderer render)
	{
		return false;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetHotFixTextShow(bool show)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void CheckWeaponSkinCustomGuide()
	{
	}

	private void AutoCloseGuide(float time)
	{
	}

	private void OnClickMultiTipsBtn()
	{
	}

	private UITable2.IUITable2Item _003CInitListTemplate_003Eb__60_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitListTemplate_003Eb__60_1()
	{
		return null;
	}

	private bool _003COnAttributeItemClick_003Eb__76_0(WeaponSkinBaseInfo x)
	{
		return false;
	}

	private void _003CAutoCloseGuide_003Eb__95_0()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
