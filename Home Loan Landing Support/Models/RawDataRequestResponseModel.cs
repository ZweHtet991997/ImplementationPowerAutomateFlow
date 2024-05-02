using Newtonsoft.Json;

namespace Home_Loan_Landing_Support.Models
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

    public class BusinessType
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class CustomerCurrentUsingBank
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class CustomerInterestedProduct1
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class CustomerInterestedProduct2
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class CustomerInterestedProduct3
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class CustomerSource
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class CustomerType
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
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

    public class LeadsStatus
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class Product
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class RegionCode
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class Root
    {
        [JsonProperty("@odata.nextLink")]
        public string odatanextLink { get; set; }
        public List<Value> value { get; set; }
    }

    public class SalesCallStatus
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        public int Id { get; set; }
        public string Value { get; set; }
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
        public RegionCode RegionCode { get; set; }

        [JsonProperty("RegionCode#Id")]
        public int RegionCodeId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public DateTime Created { get; set; }
        public string CustomerName { get; set; }
        public string BusinessName { get; set; }
        public BusinessType BusinessType { get; set; }

        [JsonProperty("BusinessType#Id")]
        public int BusinessTypeId { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string BusinessLocatedTownship { get; set; }
        public CustomerType CustomerType { get; set; }

        [JsonProperty("CustomerType#Id")]
        public int CustomerTypeId { get; set; }
        public string MeetingDate { get; set; }
        public List<object> SalesCallProduct { get; set; }

        [JsonProperty("SalesCallProduct@odata.type")]
        public string SalesCallProductodatatype { get; set; }

        [JsonProperty("SalesCallProduct#Id")]
        public List<object> SalesCallProductId { get; set; }

        [JsonProperty("SalesCallProduct#Id@odata.type")]
        public string SalesCallProductIdodatatype { get; set; }
        public SalesCallStatus SalesCallStatus { get; set; }

        [JsonProperty("SalesCallStatus#Id")]
        public int SalesCallStatusId { get; set; }
        public LeadsStatus LeadsStatus { get; set; }

        [JsonProperty("LeadsStatus#Id")]
        public int LeadsStatusId { get; set; }
        public CustomerInterestedProduct1 CustomerInterestedProduct_1 { get; set; }

        [JsonProperty("CustomerInterestedProduct_1#Id")]
        public int CustomerInterestedProduct_1Id { get; set; }
        public string CustomerInterestedAmount { get; set; }
        public CustomerCurrentUsingBank CustomerCurrentUsingBank { get; set; }

        [JsonProperty("CustomerCurrentUsingBank#Id")]
        public int CustomerCurrentUsingBankId { get; set; }
        public CustomerSource CustomerSource { get; set; }

        [JsonProperty("CustomerSource#Id")]
        public int CustomerSourceId { get; set; }
        public Product Product { get; set; }

        [JsonProperty("Product#Id")]
        public int ProductId { get; set; }
        public string LoanType { get; set; }
        public string Form_3_Stage { get; set; }
        public DateTime Form3_Submitted_Date { get; set; }
        public string LS_Stage { get; set; }
        public string LS_SubmittedDate { get; set; }
        public string LS { get; set; }
        public DateTime Modified { get; set; }
        public string Legal_Stage { get; set; }
        public string Legal_SubmittedDate { get; set; }
        public string COD_Stage { get; set; }
        public string COD_SubmittedDate { get; set; }
        public Author Author { get; set; }

        [JsonProperty("Author#Claims")]
        public string AuthorClaims { get; set; }
        public bool IsNewRecord { get; set; }
        public string MailMessageID { get; set; }
        public Editor Editor { get; set; }

        [JsonProperty("Editor#Claims")]
        public string EditorClaims { get; set; }

        [JsonProperty("{Identifier}")]
        public string Identifier { get; set; }

        [JsonProperty("{IsFolder}")]
        public bool IsFolder { get; set; }

        [JsonProperty("{Thumbnail}")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("{Link}")]
        public string Link { get; set; }

        [JsonProperty("{Name}")]
        public string Name { get; set; }

        [JsonProperty("{FilenameWithExtension}")]
        public string FilenameWithExtension { get; set; }

        [JsonProperty("{Path}")]
        public string Path { get; set; }

        [JsonProperty("{FullPath}")]
        public string FullPath { get; set; }

        [JsonProperty("{HasAttachments}")]
        public bool HasAttachments { get; set; }

        [JsonProperty("{VersionNumber}")]
        public string VersionNumber { get; set; }
        public CustomerInterestedProduct2 CustomerInterestedProduct_2 { get; set; }

        [JsonProperty("CustomerInterestedProduct_2#Id")]
        public int? CustomerInterestedProduct_2Id { get; set; }
        public CustomerInterestedProduct3 CustomerInterestedProduct_3 { get; set; }

        [JsonProperty("CustomerInterestedProduct_3#Id")]
        public int? CustomerInterestedProduct_3Id { get; set; }
        public string Remark { get; set; }
        public string TransferedOwner { get; set; }
        public string CustomerSource_OtherAnswer { get; set; }
        public string Legal { get; set; }
    }
}
