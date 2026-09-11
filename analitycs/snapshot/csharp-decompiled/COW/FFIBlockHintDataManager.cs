using GCommon;

namespace COW;

public class FFIBlockHintDataManager : SingletonModule<FFIBlockHintDataManager>
{
	private CSVAsyncDataMap<uint, FFIBlockHintData> m_DataMap;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public FFIBlockHintData GetData(EFFIBlockType blockType)
	{
		return null;
	}

	public string GetCustomerLink(EFFIBlockType blockType)
	{
		return null;
	}

	public string GetStoreLink(EFFIBlockType blockType)
	{
		return null;
	}

	private string GetStoreLinkByPlatform(FFIBlockHintData data)
	{
		return null;
	}
}
