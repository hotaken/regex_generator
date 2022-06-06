using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WinFormsRegex
{
    public class FoundData
    {
        public int start;
        public int end;
        public string str;
        public string cstr;

        public FoundData(int start, int end, string str, string cstr)
        {
            this.start = start;
            this.end = end;
            this.str = str;
            this.cstr = cstr;
        }
    }

    public class Dataset
    {
        public List<FoundData>[] data;
        public Dataset(string file_name)
        {
            using (StreamReader r = new StreamReader(file_name))
            {
                var json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<FoundData>[]>(json);
            }
        }
        public Dataset(int number)
        {
            data = new List<FoundData>[number];
            for (int i = 0; i < number; i++)
            {
                data[i] = new List<FoundData>();
            }
        }
    }
}
