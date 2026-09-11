namespace proto;

public class ReportMailInfo
{
	public ulong report_mail_id;

	public EMail.ReportMailType report_mail_type;

	public ReportInfo report_info;

	public long receive_time;

	public EMail.Status status;

	public string release_version;

	public MailAttachment attachment;
}
