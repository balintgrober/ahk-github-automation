namespace DTOs
{
    public class PullRequestStatusDTO
    {
        public PullRequestStatusDTO(int number, string htmlUrl, string status, string assignee)
        {
            this.Number = number;
            this.HtmlUrl = htmlUrl;
            this.Status = status;
            this.Assignee = assignee;
        }

        public int Number { get; }
        public string HtmlUrl { get; }
        public string Status { get; }
        public string Assignee { get; }
    }
}
