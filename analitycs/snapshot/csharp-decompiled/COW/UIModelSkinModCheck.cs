using GCommon;
using proto;

namespace COW;

public class UIModelSkinModCheck : UIBaseModel
{
	private const string REFRESH_FLAG = "SKINMOD_POPUPWND";

	private const string FIXTYPEKEY = "SKINMODCHECK_";

	private bool isHacker;

	private HackWarningInfoDesc m_HackWarningInfoDesc;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	private void RecordNextTimeStamp()
	{
	}

	public bool TimeCheck()
	{
		return false;
	}

	public bool MD5Check()
	{
		return false;
	}

	public bool PopUpCheck()
	{
		return false;
	}

	public void RequestHackerWarningInfo(bool silence = true, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void OnRequestCheckHackBehaviorResFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void ClientPreRecord(ESkinModFixType type)
	{
	}

	public ESkinModFixType GetLastClientPreRecord()
	{
		return ESkinModFixType.None;
	}

	public void SendFixLog(ESkinModFixType type)
	{
	}

	public void CheckPlayerRepairClientSuccess()
	{
	}

	private void _003CRequestHackerWarningInfo_003Eb__10_0(HttpErrorCode errorCode, object result)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
