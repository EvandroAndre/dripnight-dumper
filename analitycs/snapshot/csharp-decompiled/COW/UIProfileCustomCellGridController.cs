using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomCellGridController : UIBaseController, IUIModelDataChangeObserver
{
	private class CtrlManager
	{
		public ProfileCollectionItemTemplate ItemTemplate;

		public List<UIProfileCustomCollectionItemBaseController> NormalList;

		public List<UIProfileCustomCollectionItemBaseController> CacheList;

		public bool CacheOne(int index)
		{
			return false;
		}

		public void CacheAll()
		{
		}
	}

	public enum EDirtyState
	{
		Not,
		Template,
		Position,
		EvoGunSkin,
		EvoGunProficiency,
		BundleOpened,
		BadgeInvalid,
		BigEventAchievementNotOpen,
		WeaponProficiencyWithInvalidSkin,
		SocialMediaUnlinked
	}

	public class DirtyLog
	{
		public ProfileCustomModuleData Data;

		public EDirtyState DirtyState;
	}

	public const int COLUMN_LIMIT = 6;

	public const int ROW_LIMIT_LEFT = 4;

	public const int ROW_LIMIT_RIGHT = 8;

	private UIProfileCustomCellGridView m_View;

	private UIModelProfileCustom m_ModelProfileCustom;

	private UIModelAchievement m_ModelAchievement;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelInventory m_ModelInventory;

	private int m_MaxRow;

	private int m_MaxColumn;

	private bool m_IsSelf;

	private bool m_InBriefBox;

	private bool m_CanEdit;

	private UIModelProfileCustom.EDataSource m_DataSource;

	private ProfileCustomDragTemplate m_ParentDragTemplate;

	private HashSet<int> m_TempTargetIndexes;

	private List<UIProfileCustomCellController> m_TempTargetCells;

	private UIProfileCustomCellController[] m_CellCtrls;

	private Dictionary<uint, CtrlManager> m_DictCtrlManager;

	private GameObject m_LoadingPrefab;

	private ProfileDataPunishSwitchConfig m_ProfileDataPunishConfig;

	public bool CanEdit => false;

	public UIModelProfileCustom.EDataSource DataSource => UIModelProfileCustom.EDataSource.None;

	public List<UIProfileCustomCellController> TempTargetCells => null;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetDepth(int depth)
	{
	}

	public Transform UIFXParent()
	{
		return null;
	}

	public void ShowNetworkBlock(bool show)
	{
	}

	public int PositionToIndex(Vector2Int pos)
	{
		return 0;
	}

	public int PositionToIndex(int row, int col)
	{
		return 0;
	}

	public Vector2Int IndexToPosition(int index)
	{
		return default(Vector2Int);
	}

	private bool IsDataValid(ProfileCustomModuleData data)
	{
		return false;
	}

	private EDirtyState GetDataDirtyState(ProfileCustomModuleData data, bool isSelf)
	{
		return EDirtyState.Not;
	}

	public List<DirtyLog> RefreshViewByModuleData(List<ProfileCustomModuleData> dataList, bool modifyCacheFlag = false)
	{
		return null;
	}

	public void InitConfig(int row, int column, bool inBriefBox, bool canEdit, bool enableCellClick, bool isSelf, UIModelProfileCustom.EDataSource dataSource, ProfileCustomDragTemplate template)
	{
	}

	public void SetProfileDataPunishConfig(ProfileDataPunishSwitchConfig config)
	{
	}

	public void CalculCellBoundsCache(Transform boundsRelativeTrans)
	{
	}

	public bool RefreshDragTargets(ProfileCustomDragTemplate dragTemplate)
	{
		return false;
	}

	public bool RefreshClickTargets(ProfileCustomModuleData data, int clickIndex)
	{
		return false;
	}

	private bool CalculateTempTargets(Vector2Int targetPos, Vector2Int cellSize, bool checkConflict)
	{
		return false;
	}

	public void ClearTargetCells()
	{
	}

	public void DeleteDataIDs(IEnumerable<int> dataIDs, bool refreshCellUI)
	{
	}

	public UIBaseController RecordDataToCells(ProfileCustomModuleData data, List<UIProfileCustomCellController> target)
	{
		return null;
	}

	public void DeleteAll(bool refreshCell = true)
	{
	}

	public void RefreshCellStyle(bool useTempTarget)
	{
	}

	public void RefreshCellDuringDrag(int dataSource, int index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitCtrlManagers()
	{
	}

	private UIProfileCustomCollectionItemBaseController OpenItemCtrl(ProfileCollectionItemTemplate eCtrlType)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
