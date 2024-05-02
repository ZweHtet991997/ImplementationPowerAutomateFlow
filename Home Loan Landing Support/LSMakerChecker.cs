using Home_Loan_Landing_Support.Models;

namespace Home_Loan_Landing_Support
{
    public class LSMakerChecker
    {
        public List<LSAnalystAssignPersonList> AssignPersonList()
        {
            List<LSAnalystAssignPersonList> lstAssignPeron = new List<LSAnalystAssignPersonList>();
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Zwe Wai Yan Htet", Email = "zwewaiyanhtet@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Rozan Naing", Email = "rozannaing@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "SaBai Aung", Email = "sabai.aung@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Swe Zin Soe", Email = "swezinsoe@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Pyae Phyo Swe", Email = "pyaephyoswe@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Aung Zaw Paing Oo", Email = "aungzawpaingoo@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Ko Ko Naung", Email = "kokonaung@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Khine Swe Swe Aung", Email = "eimyatmon@yomabank.com" });
            lstAssignPeron.Add(new LSAnalystAssignPersonList { Name = "Ei Myat Mon", Email = "eimyatmon@yomabank.com" });
            return lstAssignPeron;
        }

        public string GetEmailByName(string Name)
        {
            return AssignPersonList().Where(x => x.Name == Name).Select(x => x.Email).FirstOrDefault();
        }
    }
}
