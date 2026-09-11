using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class CustomEventReader
{
	private UGCVarValueDataV2 _003CValueData_003Ek__BackingField;

	public UGCVarValueDataV2 ValueData
	{
		get
		{
			return _003CValueData_003Ek__BackingField;
		}
		private set
		{
			_003CValueData_003Ek__BackingField = value;
		}
	}

	public IJHPDKODECM EditMapValue => null;

	public EUGCUserCustomEventSource EventSource
	{
		get
		{
			return EUGCUserCustomEventSource.UserCustomEvent;
		}
		set
		{
		}
	}

	public string EventName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string EventGUID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Receiver
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int TargetSide
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<UGCVarValueDataV2> Params
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CustomEventReader(UGCVarValueDataV2 eventItem)
	{
	}

	public CustomEventReader()
	{
	}

	public void Load(UGCVarValueDataV2 eventItem)
	{
	}
}
