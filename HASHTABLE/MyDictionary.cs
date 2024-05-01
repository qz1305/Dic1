using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace HASHTABLE
{
    class MyDictionary
    {
        //Properties
        public MyHashTable myHashTable = new MyHashTable();
        //Method
        //Hàm lấy dữ liệu từ tệp txt
        public void LoadData(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string dic = sr.ReadLine();
                while (dic != "" && dic != null)
                {
                    dic = dic.ToLower();
                    string[] word = dic.Split('\t');
                    word[0] = word[0].Trim();
                    myHashTable.AddKey(word[0], word[1]);
                    dic = sr.ReadLine();
                }
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Không tìm thấy tệp tin: " + ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc tệp tin: " + ex.Message);
            }
        }
        //Hàm thêm một từ điển
        public bool AddDictionary(string key, string value)
        {
            if (!IsValidString(key))
                return false;
            myHashTable.AddKey(key, value);
            return true;
        }
        //Hàm xóa một từ điển
        public void RemoveDictionary(string key)
        {
            myHashTable.RemoveKey(key);
        }
        //Hàm thay đổi một từ điển
        public void ChangeDictionary(string key, string value)
        {
            Node p = myHashTable.SearchKey(key);
            p.value = value;
        }
        //Hàm tìm kiếm một từ điển
        public Node SearchDictionary(string key)
        {
            return myHashTable.SearchKey(key);
        }
        //Hàm kiểm tra một key có hợp lệ hay không
        private bool IsValidString(string word)
        {
            if (word == null)
                return false;
            word = word.ToLower();
            for (int i = 0; i < word.Length; i++)
                if (word[i] < 'a' && word[i] > 'z')
                    return false;
            return true;
        }
        //Hàm lưu lại dữ liệu sau khi thoát ứng dụng
        public void BackUp(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < myHashTable.HT.Count(); i++)
            {
                for (Node p = myHashTable.HT[i].pHead; p != null; p = p.pNext)
                {
                    if (p != null)
                    {
                        sw.WriteLine(p.key + "\t" + p.value);
                    }
                }
            }
            sw.Close();
        }
    }
}
