using GCommon;

namespace COW;

public class Login2ndConfirmCustomerLinkDataManager : SingletonModule<Login2ndConfirmCustomerLinkDataManager>
{
	private CSVAsyncDataMap<uint, Login2ndConfirmCustomerLink> m_DataMap;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public Login2ndConfirmCustomerLink GetData(uint id)
	{
		return null;
	}

	public string GetUrl(uint id)
	{
		return null;
	}
}
