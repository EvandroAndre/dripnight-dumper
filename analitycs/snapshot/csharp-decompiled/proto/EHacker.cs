namespace proto;

public class EHacker
{
	public enum HackerPoolCdt
	{
		HackerPoolCdt_NONE = 0,
		HackerPoolCdt_SIGNATURE_LOGIN = 1,
		HackerPoolCdt_FFANTI = 2,
		HackerPoolCdt_START_TIME = 3,
		HackerPoolCdt_MD5_FILE_EXCEPTION = 4,
		HackerPoolCdt_MD5_SCAN_COUNT = 5,
		HackerPoolCdt_MD5_COUNT = 6,
		HackerPoolCdt_PMS_HOOK = 7,
		HackerPoolCdt_CLIENT_INFO_EMPTY = 8,
		HackerPoolCdt_NATIVE_RESULT = 9,
		HackerPoolCdt_MD5_COUNT_AND_VALUE = 15,
		HackerPoolCdt_MATCH_MODE_CHECK = 16,
		HackerPoolCdt_IS_HACKER_CHECK = 17,
		HackerPoolCdt_GIN_CHECK_DATA_EMPTY_ANDROID = 18,
		HackerPoolCdt_GIN_CHECK_DATA_EMPTY_IOS = 19,
		HackerPoolCdt_GIN_CHECK_DATA_EMPTY_PC = 20
	}

	public enum HackerCdtManner
	{
		HackerCdtManner_EQU,
		HackerCdtManner_CVR,
		HackerCdtManner_GTR,
		HackerCdtManner_LSS,
		HackerCdtManner_JSON_EQU,
		HackerCdtManner_JSON_NOT_EQU,
		HackerCdtManner_EQU_OPPOSITE
	}

	public enum HackerCdtID
	{
		HackerCdtID_NONE = 0,
		HackerCdtID_FALSIFY_MEM_VALUE = 100,
		HackerCdtID_CLIENT_INFO_EMPTY = 101
	}
}
