namespace GCommon;

public enum HttpErrorCode
{
	OK = 0,
	InvalidArgs = 1,
	Exception = 2,
	Timeout = 3,
	DataTypeError = 4,
	SSLAuthError = 5,
	DefaultHttpOK = 200,
	BadRequest = 400,
	Unauthorized = 401,
	Forbidden = 403,
	NotFound = 404,
	NotAcceptable = 406,
	RequestTimeout = 408,
	Conflict = 409,
	InternalServerError = 500,
	BadGateway = 502,
	ServiceUnavailable = 503,
	GatewayTimeout = 504
}
