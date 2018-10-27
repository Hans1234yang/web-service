using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace web_service尝试
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int i,int j)
        {
            return i + j;
        }
        [WebMethod]
        public int JianFa(int i,int j)
        {
            return i - j;
        }
        [WebMethod]
        public int ChengFa(int i,int j)
        {
            return i * j;
        }

        [WebMethod]
        public string GetWeek(int day)
        {
            string result;
            if(day>6)
            {
                result = "输入格式有误";
            }
            else
            {
                DayOfWeek week=(DayOfWeek)day;
                result = week.ToString();
            }

            return result;
        }
    }
}
