using System;
using GCommon;

namespace COW;

public class UIModelVehicleDisplay : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__14_0;

		internal void _003CRequestSetVehicleSkinID_003Eb__14_0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const string HDVEHICLEDISPLAYGUIDE = "HDVEHICLEDISPLAYGUIDE_";

	public const string UILobbyVehicleDisplayGuideKey = "UILOBBYVEHICLEDISPLAYGUIDEKEY_";

	public const string UILobbyVehicleAutoRotateGuideKey = "UILOBBYVEHICLE_AUTOROTATE_GUIDEKEY_";

	private uint _003CSelectedVehicleSkinID_003Ek__BackingField;

	private bool _003CGetDataAfterLogin_003Ek__BackingField;

	public uint SelectedVehicleSkinID
	{
		get
		{
			return _003CSelectedVehicleSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CSelectedVehicleSkinID_003Ek__BackingField = value;
		}
	}

	public bool GetDataAfterLogin
	{
		get
		{
			return _003CGetDataAfterLogin_003Ek__BackingField;
		}
		private set
		{
			_003CGetDataAfterLogin_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessData(uint skinID)
	{
	}

	public void RequestSetVehicleSkinID(uint skinID, bool autoRotate = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
