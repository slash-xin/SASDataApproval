using System.Text.RegularExpressions;

namespace ExportSASData
{
    public static class RegexHelper
    {
        //身份证正则表达式
        private static Regex cardidregex = new Regex(@"(\d{18}|\d{17}(\d|X|x)|\d{15})");
        //手机号正则表达式
        private static Regex phoneregex = new Regex(@"1[34578]\d{9}");
        //固话号正则表达式
        private static Regex mobileregex = new Regex(@"^(\d{3,4}-?)?\d{7,8}$");
        //6位密码正则表达式
        private static Regex coderegex = new Regex(@"[1-9]\d{5}(?!\d)");

        /// <summary>
        /// 是否为邮箱名
        /// </summary>
        public static bool IsCardId(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            return cardidregex.IsMatch(s);
        }

        /// <summary>
        /// 是否为手机号
        /// </summary>
        public static bool IsMobile(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            return mobileregex.IsMatch(s);
        }

        /// <summary>
        /// 是否为固话号
        /// </summary>
        public static bool IsPhone(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            return phoneregex.IsMatch(s);
        }

        public static string replaceValue(Regex regex, string value, string replacement)
        {
            string result = value;
            //if (regex.IsMatch(value))
            // {
            result = regex.Replace(value, replacement);
            // }
            return result;
        }
        public static string allReplaceValue(string value)
        {
            value = replaceValue(cardidregex, value, "(id_num)");
            value = replaceValue(phoneregex, value, "(phone_num)");
            string substr = "";
            int index = value.IndexOf("密码");
            if (index >= 0)
            {
                int sublength = 17;
                if (value.Length - index < 17)
                {
                    sublength = value.Length - index;
                }
                string temp = substr = value.Substring(index, sublength);
                if (coderegex.IsMatch(substr))
                {
                    value = value.Replace(temp, replaceValue(coderegex, substr, "(code)"));
                }
            }
            // value = replaceValue(coderegex, value, "(code)");
            return value;
        }
    }
}
