namespace GarenaMSDK;

public enum SessionStatus
{
	None,
	Created,
	Opening,
	TokenAvailable,
	Closed,
	ClosedWithError,
	InspectionWithError,
	ClosedWithBindFail
}
