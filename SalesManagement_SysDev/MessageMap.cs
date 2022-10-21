using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev
{
    public class MessageMap
    {

        private Dictionary<String, String> map = new Dictionary<String, String>();

        public String get(String code)
        {

            String message = map[code];
            if (message != null)
            {

                return message;

            }

            return "";

        }

        public String put(String code, String message)
        {

            map.Add(code, message);

            return message;

        }

    }

}
