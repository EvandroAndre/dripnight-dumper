namespace GCommon;

public class HttpDataManager : SingletonModule<HttpDataManager>
{
	private CSVAsyncDataMap<uint, HttpChannelData> m_DictHttpChannelData;

	private CSVAsyncDataMap<uint, HttpSequenceData> m_DictHttpSequenceData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void LoadCSV(ResourceID httpChannel, ResourceID httpSequence)
	{
	}

	public HttpChannelData GetChannelData(string cmd)
	{
		return null;
	}

	public HttpSequenceData GetSequenceData(string controllerType)
	{
		return null;
	}
}
