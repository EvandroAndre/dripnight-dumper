using ProtoBuf;

namespace proto;

public class CustomerReportDesc : IMessage
{
	public string region;

	public string language;

	public string customer_service_url;

	public bool external_customer_service;

	public string terms_of_service_url;

	public string privacy_policies_url;

	public string customer_del_account_ios_url;

	public string customer_del_account_review_url;

	public string report_url;

	public string desc;

	public string customer_del_account_android_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
