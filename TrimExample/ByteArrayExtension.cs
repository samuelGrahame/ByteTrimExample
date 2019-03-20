using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimExample
{
    public static class ByteArrayExtension
    {
        public static byte[] Trim(this byte[] data)
        {
            if (data == null || data.Length == 0)
                return data;

            var list = new List<byte>(data);
            
            for (int i = 0; i < list.Count; i++)
            {
                if(!char.IsWhiteSpace((char)list[i]))
                {
                    list.RemoveRange(0, i);
                    removedFirst = true;
                    break;
                }
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (!char.IsWhiteSpace((char)list[i]))
                {
                    list.RemoveRange(i + 1, list.Count - 1 - i);

                    break;
                }
            }

            return list.ToArray();
        }
    }
}
