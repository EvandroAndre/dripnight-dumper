using System.Collections.Generic;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public class UGCTemplateManager : SingletonModule<UGCTemplateManager>
{
	public Dictionary<string, uint> PrefabIdDic;

	private Dictionary<uint, WorkShopTemplateResourceContentConfigData> m_TemplateConfigDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public WorkShopPrefabResourceContentConfigData GetTemplateConfigData(uint prefabId)
	{
		return null;
	}

	public void BuildResourceContentConfigData(uint prefabId, KCJDEKIJAKH templateData, uint optionId, EUGCAssetProviderType type)
	{
	}

	public void BuildResourceContentConfigData(string assetId, KCJDEKIJAKH templateData, uint optionId, EUGCAssetProviderType type)
	{
	}

	public void UnregisterObjectTemplate(string assetId)
	{
	}
}
