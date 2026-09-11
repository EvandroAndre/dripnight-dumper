using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCProfileInfoRepItem
{
	public const int PROP_ID_ACCOUNTID = -326000;

	public const int PROP_ID_HEADID = -326001;

	public const int PROP_ID_BANNERID = -326002;

	public const int PROP_ID_PINID = -326003;

	public const int PROP_ID_NICKNAME = -326004;

	public const int PROP_ID_BRRANK = -326005;

	public const int PROP_ID_BRPEAKRANK = -326006;

	public const int PROP_ID_CSRANK = -326007;

	public const int PROP_ID_CSPEAKRANK = -326008;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnAccountIDChangeEvent;

	public Action<string> OnHeadIDChangeEvent;

	public Action<string> OnBannerIDChangeEvent;

	public Action<string> OnPinIDChangeEvent;

	public Action<string> OnNickNameChangeEvent;

	public Action<int> OnBRRankChangeEvent;

	public Action<int> OnBRPeakRankChangeEvent;

	public Action<int> OnCSRankChangeEvent;

	public Action<int> OnCSPeakRankChangeEvent;

	private string _003CAccountID_003Ek__BackingField;

	private string _003CHeadID_003Ek__BackingField;

	private string _003CBannerID_003Ek__BackingField;

	private string _003CPinID_003Ek__BackingField;

	private string _003CNickName_003Ek__BackingField;

	private int _003CBRRank_003Ek__BackingField;

	private int _003CBRPeakRank_003Ek__BackingField;

	private int _003CCSRank_003Ek__BackingField;

	private int _003CCSPeakRank_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string AccountID
	{
		get
		{
			return _003CAccountID_003Ek__BackingField;
		}
		private set
		{
			_003CAccountID_003Ek__BackingField = value;
		}
	}

	public string HeadID
	{
		get
		{
			return _003CHeadID_003Ek__BackingField;
		}
		private set
		{
			_003CHeadID_003Ek__BackingField = value;
		}
	}

	public string BannerID
	{
		get
		{
			return _003CBannerID_003Ek__BackingField;
		}
		private set
		{
			_003CBannerID_003Ek__BackingField = value;
		}
	}

	public string PinID
	{
		get
		{
			return _003CPinID_003Ek__BackingField;
		}
		private set
		{
			_003CPinID_003Ek__BackingField = value;
		}
	}

	public string NickName
	{
		get
		{
			return _003CNickName_003Ek__BackingField;
		}
		private set
		{
			_003CNickName_003Ek__BackingField = value;
		}
	}

	public int BRRank
	{
		get
		{
			return _003CBRRank_003Ek__BackingField;
		}
		private set
		{
			_003CBRRank_003Ek__BackingField = value;
		}
	}

	public int BRPeakRank
	{
		get
		{
			return _003CBRPeakRank_003Ek__BackingField;
		}
		private set
		{
			_003CBRPeakRank_003Ek__BackingField = value;
		}
	}

	public int CSRank
	{
		get
		{
			return _003CCSRank_003Ek__BackingField;
		}
		private set
		{
			_003CCSRank_003Ek__BackingField = value;
		}
	}

	public int CSPeakRank
	{
		get
		{
			return _003CCSPeakRank_003Ek__BackingField;
		}
		private set
		{
			_003CCSPeakRank_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCProfileInfoRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
