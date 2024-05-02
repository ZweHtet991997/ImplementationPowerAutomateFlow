using Newtonsoft.Json;

namespace Home_Loan_Landing_Support.Models.LS
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Author
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public string Claims { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }

    public class Editor
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public string Claims { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }

    public class Root
    {
        public List<Value> value { get; set; }
    }

    public class Thumbnail
    {
        public object Large { get; set; }
        public object Medium { get; set; }
        public object Small { get; set; }
    }

    public class Value
    {
        [JsonProperty("@odata.etag")]
        public string odataetag { get; set; }
        public string ItemInternalId { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Stage { get; set; }
        public string ApprovalLevel { get; set; }
        public string Assign_Analyst_Name { get; set; }
        public string Assign_Analyst_Email { get; set; }
        public string AssessorPrice { get; set; }
        public string Assessor_Total_Assessed_Value { get; set; }
        public string LS_Complete { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public Author Author { get; set; }

        [JsonProperty("Author#Claims")]
        public string AuthorClaims { get; set; }
    }


}
