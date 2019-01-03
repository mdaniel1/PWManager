using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWManager.classes
{
    public class PropertiesManager
    {
        private Dictionary<String, String> list;
        private String filename;

        public PropertiesManager(String file)
        {
            reload(file);
        }

        public String get(String field, String defValue)
        {
            return (get(field) == null) ? defValue : get(field);
        }
        public String get(String field)
        {
            return list.ContainsKey(field) ? list[field] : null;
        }

        public void set(String field, Object value)
        {
            if (!list.ContainsKey(field))
                list.Add(field, value.ToString());
            else
                list[field] = value.ToString();
        }

        public void Save()
        {
            Save(this.filename);
        }

        public void Save(String filename)
        {
            this.filename = filename;
            FileStream fs = null;

            if (!File.Exists(filename))
            {
                fs = File.Create(filename);
            }
            else
            {
                fs = new FileStream(filename, FileMode.Open);
            }

            StreamWriter file = new StreamWriter(fs);

            foreach (String prop in list.Keys.ToArray())
                if (!String.IsNullOrWhiteSpace(list[prop]))
                    file.WriteLine(prop + "=" + list[prop]);

            file.Close();
            fs.Close();
        }

        //Default reload() function, it's preferable to directly use reload(String filename) to be sure, 
        //but this works fine if you know what you do, and it's faster to type. #laziness
        public void reload()
        {
            reload(this.filename);
        }

        public void reload(String filename)
        {
            this.filename = filename;
            list = new Dictionary<String, String>();

            if (File.Exists(filename))
                loadFromFile(filename);
            else
            {
                //Default value is set to "My Documents" for when the file is created on the first launch.
                //Can be changed in the Options panel and will be correctly loaded afterwards.
                string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                Path += "\\PWManager";

                set("FILE_PATH", Path);
                set("LANGUAGE", "0"); //Index of comboBox in OptionWindow. Default (0) is French.

                Save(filename);
            }
                
        }

        private void loadFromFile(String file)
        {
            foreach (String line in File.ReadAllLines(file))
            {
                if ((!String.IsNullOrEmpty(line)) &&
                    (!line.StartsWith(";")) &&
                    (!line.StartsWith("#")) &&
                    (!line.StartsWith("'")) &&
                    line.Contains('='))
                {
                    int index = line.IndexOf('=');
                    String key = line.Substring(0, index).Trim();
                    String value = line.Substring(index + 1).Trim();

                    if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                        (value.StartsWith("'") && value.EndsWith("'")))
                    {
                        value = value.Substring(1, value.Length - 2);
                    }

                    try
                    {
                        //ignore dublicates
                        list.Add(key, value);
                    }
                    catch { }
                }
            }
        }
    }
}
