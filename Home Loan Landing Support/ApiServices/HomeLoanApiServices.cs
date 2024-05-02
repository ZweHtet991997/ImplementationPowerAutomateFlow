using Home_Loan_Landing_Support.Models;
using Home_Loan_Landing_Support.Models.LS;
using RestSharp;
using System.Text.Json;

namespace Home_Loan_Landing_Support.ApiServices
{
    public class HomeLoanApiServices
    {
        private ApiURLRouter _apiRouter;
        private RestClient _restClient;

        public HomeLoanApiServices(ApiURLRouter apiRouter)
        {
            _apiRouter = apiRouter;
            _restClient = new RestClient();
        }

        public async Task<List<Form1ResponseModel>> GetForm1List()
        {
            try
            {
                Models.Root root = new Models.Root();
                List<Form1ResponseModel> lstForm1 = new List<Form1ResponseModel>();
                var request = new RestRequest(_apiRouter.GetListApiUrl(), Method.Get);
                var response = await _restClient.ExecuteAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    root = JsonSerializer.Deserialize<Models.Root>(response.Content);
                    foreach (var item in root.value)
                    {
                        Form1ResponseModel responseModel = new Form1ResponseModel();
                        responseModel.ID = item.ID;
                        responseModel.CustomerName = item.CustomerName;
                        responseModel.SubmissionDate = item.Form3_Submitted_Date.ToString("mm/dd/yyyy");
                        responseModel.Region = item.RegionCode.Value;
                        responseModel.BranchName = item.BranchName;
                        responseModel.Status = item.LS_Stage;
                        lstForm1.Add(responseModel);
                    }
                }
                return lstForm1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<int> CreateLS(LSRequestModel model)
        {
            try
            {
                var request = new RestRequest(_apiRouter.CreateApiUrl()).AddJsonBody(model);
                var response = await _restClient.ExecutePostAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<LSResponseModel>> GetLSByCaseID(string CaseID)
        {
            try
            {
                LSCaseRequestModel requestModel = new LSCaseRequestModel();
                requestModel.CaseID = CaseID;
                Models.LS.Root root = new Models.LS.Root();
                List<LSResponseModel> lstLS = new List<LSResponseModel>();
                var request = new RestRequest(_apiRouter.GetLSByCaseIDApiUrl()).AddJsonBody(requestModel);
                var response = await _restClient.ExecutePostAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    root = JsonSerializer.Deserialize<Models.LS.Root>(response.Content);
                    foreach (var item in root.value)
                    {
                        LSResponseModel responseModel = new LSResponseModel();
                        responseModel.ID = item.ID.ToString();
                        responseModel.CaseID = item.Title;
                        responseModel.Stage = item.Stage;
                        responseModel.ApprovalLevel = item.ApprovalLevel;
                        responseModel.Assign_Analyst_Name = item.Assign_Analyst_Name;
                        responseModel.Assign_Analyst_Email = item.Assign_Analyst_Email;
                        responseModel.Assessor_Price = item.AssessorPrice;
                        responseModel.Assessor_Total_Assessed_Value = item.Assessor_Total_Assessed_Value;
                        responseModel.LS_Complete = item.LS_Complete;
                        lstLS.Add(responseModel);
                    }
                }
                return lstLS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> UpdateLS(LSUpdateRequestModel model)
        {
            try
            {
                var request = new RestRequest(_apiRouter.UpdateApiUrl()).AddJsonBody(model);
                var response = await _restClient.ExecutePutAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
