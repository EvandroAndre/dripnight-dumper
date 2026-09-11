using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBuffEcaKillNotificationItem : MonoBehaviour
{
	public UILabel CoinText;

	private ResourceID _003CResID_003Ek__BackingField;

	public string SoundResID;

	public ResourceID ResID
	{
		get
		{
			return _003CResID_003Ek__BackingField;
		}
		set
		{
			_003CResID_003Ek__BackingField = value;
		}
	}
}
