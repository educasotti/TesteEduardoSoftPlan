using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace TesteEduardoSoftPlan.Services
{
    public class InterestService
    {
        static HttpClient client = new HttpClient();
        public async Task<double> GetInterest(string path)
        {
            double result = 0;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                result = Convert.ToDouble(response.Content.ReadAsStringAsync().Result);
            }
            return result;
        }

        public string Calc(double interest, double startValue, int months)
        {
            return string.Format("{0:0.00}", Math.Round(startValue * Math.Pow((1 + interest), months), 2));
        }
    }
}
