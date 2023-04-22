using System;

namespace P78Q50
{
    class Program
    {
        /// <summary>
        /// The function find the amount of second the is in the array of AD's inputed of a string inputed
        /// </summary>
        /// <param name="ads">The AD's array runnig through</param>
        /// <param name="companyName">The string inputed that looking for</param>
        /// <returns></returns>
        static int FindAllDuration(Ad[] ads, string companyName)
        {
            int duration = 0;
            foreach (Ad ad in ads)
            {
                if (ad.CompanyName == companyName)
                {
                    duration += ad.Duration;
                }
            }
            return duration;
        }


        static Ad[] FindCompanySumSeconds(Ad[] ads)
        {
            Ad[] tempCompanySum = new Ad[ads.Length];
            string companyLookingFor;
            for (int i = 1; i < ads.Length; i++)
            {
                companyLookingFor = ads[i].CompanyName;
                tempCompanySum[i].CompanyName = companyLookingFor;
                foreach (Ad ad in ads)
                {
                    if (ad.CompanyName == companyLookingFor)
                    {
                        tempCompanySum[1].Duration += ad.Duration;
                        ad.CompanyName = null;
                    }
                }
            }
            int cnt = 0;
            while (tempCompanySum[cnt].CompanyName != "")
            {
                cnt++;
            }
            Ad[] companySum = new Ad[cnt];
            for (int i = 0; i < cnt; i++)
            {
                companySum[i] = tempCompanySum[i];
            }
            return companySum;
        }
        static void Main(string[] args)
        {
            const int ADAMOUNT = 3;
            Ad[] ads = new Ad[ADAMOUNT];
            for (int i = 0; i < ads.Length; i++)
            {
                ads[i] = new Ad();
            }
            foreach (Ad ad in ads)
            {
                Console.Write("Enter the name of the Ad: ");
                ad.NameOfAd = Console.ReadLine();
                Console.Write("Enter the name of the company: ");
                ad.CompanyName = Console.ReadLine();
                Console.Write("Enter the duration of the ad: ");
                ad.Duration = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < ads.Length; i++)
            {
                Console.WriteLine($"Name: {ads[i].NameOfAd},Duration: {ads[i].Duration / 60}:{ads[i].Duration % 60},FullPrice: {ads[i].Duration * 800}");
                sum += ads[i].Duration * 800;
            }
            Console.WriteLine($"The price sum of all the Ads today is: {sum}");
            string maxCompanyName = "";
            int maxDuration = 0;
            foreach (Ad ad in ads)
            {
                if (maxCompanyName != ad.CompanyName && FindAllDuration(ads, ad.CompanyName) > maxDuration)
                {
                    maxCompanyName = ad.CompanyName;
                    maxDuration = ad.Duration;
                }
            }
            Console.WriteLine($"The company with the largest pay today is: {maxCompanyName}, with an astonishing {maxDuration * 800} NIS!!!");
        }
    }
}
