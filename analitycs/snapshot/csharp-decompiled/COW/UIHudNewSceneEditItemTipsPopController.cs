using COW.GamePlay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudNewSceneEditItemTipsPopController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public long typeId;

		internal bool _003CSetPrefabData_003Eb__0(InspectorCraftlandConfig_Default e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UIHudNewSceneEditItemTipsPopController _003C_003E4__this;

		public UGCAssetRef assetRef;

		internal void _003COnBtnDeleteClick_003Eb__0()
		{
		}

		internal void _003COnBtnDeleteClick_003Eb__1()
		{
		}
	}

	private UIHudNewSceneEditItemTipsPopView m_View;

	private SceneEditPrefabConfigData m_PrefabData;

	private KCJDEKIJAKH m_TemplateData;

	private ulong m_ResourceId;

	private EUGCAssetProviderType m_Type;

	private HNDHJGJILHC m_Game;

	private UGCAssetExplorer m_Explorer;

	private SceneEditResourceShopManager m_Manager;

	private float m_MinY;

	private float m_MaxY;

	private float m_PosX;

	private Color GRAY_LABEL_COLOR;

	private Color YELLOW_UPLOAD_COLOR;

	private uint RED_COST_COLOR;

	private const int EDGE_HEIGHT = 10;

	private const int SPACE_HEIGHT = 6;

	private const int TEMPLATE_HEIGHT = 36;

	private const int RESOURCE_HEIGHT = 78;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private void ClearData()
	{
	}

	public void ResetClickMask()
	{
	}

	public void SetPrefabData(SceneEditPrefabConfigData data, Vector3 pos, EUGCAssetProviderType type)
	{
	}

	private void CalculatePos(int height, ref Vector3 localPos)
	{
	}

	private void OnResourceDataChange(object[] data)
	{
	}

	public void SetTemplateData(KCJDEKIJAKH data, Vector3 pos, EUGCAssetProviderType type)
	{
	}

	private void RefreshResource(ref int height)
	{
	}

	private void OnAttributeButtonClick()
	{
	}

	private void OnBtnShareClick()
	{
	}

	private bool TryGetResourceIndex(out UGCResourceIndexEntry entry)
	{
		entry = null;
		return false;
	}

	private bool TryBuildUUIDWithVersion(out string uuidWithVersion)
	{
		uuidWithVersion = null;
		return false;
	}

	private void OnBtnDeleteClick()
	{
	}

	private bool TryGetStorePrefabAssetIdFromPrefabData(out string prefabAssetId)
	{
		prefabAssetId = null;
		return false;
	}

	private void OnBtnUploadClick()
	{
	}

	private void OnBtnDetailClick()
	{
	}

	private void _003COnBtnDetailClick_003Eb__37_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
