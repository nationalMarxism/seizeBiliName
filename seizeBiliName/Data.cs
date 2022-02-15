using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace seizeBiliName
{
    class Data
    {
        public static int MAX = 500;
        public static int number;
        public static string[] name = new string[Data.MAX];

        public static string emailAddress = "xxx@qq.com";//发送和接受的邮件
        public static string emailKey = "xxx";//smtp授权码
        public static string emailSmtpHost = "smtp.qq.com";//smtp服务器

    }
}
