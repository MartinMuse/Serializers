using System;
using System.Reflection;
using System.IO;

namespace Menu_Builder.Class_Managment
{
    class Class__Managment
    {
        Object[] objects;
        Type[] types;
        int edit_obj_num;
        int edit_prop_num;
        PropertyInfo[] edit_obj_props;

        public Class__Managment()
        {
            Array.Resize(ref objects, 0);
            Assembly assembly = Assembly.Load("Menu Builder");
            types = assembly.GetTypes();

        }
        public int GetEditObjNum()
        {
            return edit_obj_num;
        }

        public int GetObjNum()
        {
            return objects.Length; ;
        }

        public int GetEditPropNum()
        {
            return edit_prop_num;
        }

        public string[] GetClasses()
        {
            string[] result = new string[types.Length];
            int j = 0;
            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].IsClass && (!types[i].IsAbstract) && types[i].FullName.Contains("MyClasses"))
                    result[j++] = types[i].Name;
            }
            Array.Resize(ref result, j);
            return result;
        }  

        public object CreateObject(string obj_name)
        {
            int objs_len = objects.Length;
            Array.Resize(ref objects, objs_len + 1);
            int i = 0;
            while (obj_name != types[i].Name)
            {
                i++;
            }
            objects[objs_len] = Activator.CreateInstance(types[i]);
            return objects[objs_len];
        }

        public string GetName()
        {
            Type type = objects[edit_obj_num].GetType();
            PropertyInfo prop_info = type.GetProperty("name", BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);
            return (string)prop_info.GetValue(objects[edit_obj_num]);////??
        }

        public void SetActiveLastObj()
        {
            edit_obj_num = objects.Length - 1;
            edit_prop_num = 0;
            GetProps();
        }
        public void SetActiveObj(int index)
        {
            edit_obj_num = index;
            edit_prop_num = 0;
            GetProps();
        }

        public void SetActiveProp(int num)
        {
            edit_prop_num = num;
        }

        public bool IsPropClass()
        {
            string a = edit_obj_props[edit_prop_num].PropertyType.Name;
            return edit_obj_props[edit_prop_num].PropertyType.IsClass &&
                edit_obj_props[edit_prop_num].PropertyType.Name != "String";
        }
        public void GetProps()
        {
            Type type = objects[edit_obj_num].GetType();
            edit_obj_props=type.GetProperties(BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic);
        }

        public string[] GetObjPropsTxt()
        {
            string[] result = new string[edit_obj_props.Length];
            for (int i = 0; i < edit_obj_props.Length; i++)
            {
                result[i] = edit_obj_props[i].Name + " :  ";
                if (edit_obj_props[i].GetValue(objects[edit_obj_num]) != null)
                    if (edit_obj_props[i].PropertyType.IsClass &&
                    edit_obj_props[i].PropertyType.Name != "String")
                    {
                        Type type = objects[edit_obj_num].GetType();
                        PropertyInfo prop_info = type.GetProperty("menu_item", BindingFlags.Instance
                                | BindingFlags.Static
                                | BindingFlags.Public
                                | BindingFlags.NonPublic);
                        object buf = prop_info.GetValue(objects[edit_obj_num]);
                        type = buf.GetType();
                        prop_info = type.GetProperty("name", BindingFlags.Instance
                                | BindingFlags.Static
                                | BindingFlags.Public
                                | BindingFlags.NonPublic);
                        result[i] += (string)prop_info.GetValue(buf);
                    }
                    else
                        result[i] += Convert.ToString(edit_obj_props[i].GetValue(objects[edit_obj_num])) + ";";
                else
                    result[i] += "none;";


            }
            return result;
        }

        private object[] GetChildObjects()
        {
            object[] result = new object[0];
            for (int i = 0; i < objects.Length; i++)
                if (objects[i].GetType().BaseType == edit_obj_props[edit_prop_num].PropertyType)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = objects[i];
                }
            return result;
        }
        public string[] GetChildObjectsTxt()
        {
            object[] children = GetChildObjects();
            string[] result = new string[children.Length];
            for (int i = 0; i < result.Length; i++)
            {
                Type type = children[i].GetType();
                PropertyInfo prop_info = type.GetProperty("name", BindingFlags.Instance
                        | BindingFlags.Static
                        | BindingFlags.Public
                        | BindingFlags.NonPublic);
                result[i] = (string)prop_info.GetValue(children[i]);
            }
            return result;
        }
        public bool SetPropVal(string val, int ind)
        {
            if (edit_obj_props[edit_prop_num].PropertyType.Name == "Int32")
            {
                try
                {
                    if (Convert.ToInt32(val) >= 0)
                    {
                        edit_obj_props[edit_prop_num].SetValue(objects[edit_obj_num],
                            Convert.ToInt32(val));
                        return true;
                    }
                    else return false;
                }
                catch
                {
                    return false;
                }
            }
            if (edit_obj_props[edit_prop_num].PropertyType.Name == "String")
            {
                edit_obj_props[edit_prop_num].SetValue(objects[edit_obj_num], val);
                return true;
            }
            if (edit_obj_props[edit_prop_num].PropertyType.IsClass &&
                edit_obj_props[edit_prop_num].PropertyType.Name != "String")
            {
                object[] children = GetChildObjects();
                edit_obj_props[edit_prop_num].SetValue(objects[edit_obj_num], children[ind]);
                return true;
                //edit_obj_props[edit_prop_num].SetValue(objects[edit_obj_num], CreateObject(val));
            }
            return false;
        }

        public void DeleteObj()
        {
            PropertyInfo[] buf_props;
            Type type;
            for (int i = 0; i < objects.Length; i++)
            {
                type = objects[i].GetType();
                buf_props = type.GetProperties(BindingFlags.Instance
                        | BindingFlags.Static
                        | BindingFlags.Public
                        | BindingFlags.NonPublic);
                for (int j = 0; j < buf_props.Length; j++)
                    if (ReferenceEquals(buf_props[j].GetValue(objects[i]), objects[edit_obj_num]))
                    {
                        buf_props[j].SetValue(objects[i], null);
                    }
            }
            objects[edit_obj_num] = null;
            for (int i = edit_obj_num; i < objects.Length - 1; i++)
            {
                objects[i] = objects[i + 1];
            }
            Array.Resize(ref objects, objects.Length - 1);
            if (edit_obj_num > 0)
                edit_obj_num -= 1;
        }




        public string[] GetSerialisers()//недоработано
        {
            string[] result = new string[types.Length];
            int j = 0;
            for (int i = 0; i < types.Length; i++)
            {
                if (types[i].IsClass && types[i].FullName.Contains("Serializers"))
                    result[j++] = types[i].Name;
                //ClassesCB.Items.Add(types[i].Name);
            }
            Array.Resize(ref result, j);
            return result;
        }

        //выбираем как сохранять и доставать в зависимости от поля IsTxt (dialog)
        

        private void SaveTxt(string path, string[] text)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < text.Length; i++)
                    sw.WriteLine(text[i]);
            }
        }

        public void Save(string path, string ser_name)
        {
            int i = 0;
            object[] save_objects = DeletExtra();
            while (types[i].Name != ser_name)
                i++;
            if ((bool)types[i].GetField("IsTxt").GetValue(null))
            {
                object[] ps = { save_objects };
                string[] text = (string[])types[i].GetMethod("SerializeArr").Invoke(null, ps);
                SaveTxt(path, text);
            }
            else
            {
                object[] ps = { objects, path };
                types[i].GetMethod("SerializeArr").Invoke(null, ps);
            }
        }

        private string[] LoadTxt(string path)
        {
            string[] result = new string[0];
            using (StreamReader sr = new StreamReader(path))
            {
                string buf;
                while ((buf = sr.ReadLine()) != null)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = buf;
                }
            }
            return result;
        }


        public void Load(string path, string ser_name)
        {
            int i = 0;
            while (types[i].Name != ser_name)
                i++;
            if ((bool)types[i].GetField("IsTxt").GetValue(null))
            {
                string[] objs_txt = LoadTxt(path);
                object[] ps = { objs_txt };
                objects = (object[])types[i].GetMethod("DeserializeArr").Invoke(null, ps);
            }
            else
            {
                object[] ps = { path };
                objects = (object[])types[i].GetMethod("DeserializeArr").Invoke(null, ps);
            }
        }

        private object[] DeletExtra()
        {
            int[] Labels = new int[objects.Length];
            int size = 0;
            for (int i = 0; i < objects.Length; i++)
                Labels[i] = 1;
            for (int i = 0; i < objects.Length; i++)
            {
                PropertyInfo[] props = objects[i].GetType().GetProperties();
                for (int j = 0; j < props.Length; j++)
                {
                    if (props[j].PropertyType.IsClass && props[j].PropertyType.FullName.Contains("User_Classes"))
                    {
                        for (int k = 0; k < objects.Length; k++)
                        {
                            if (ReferenceEquals(props[j].GetValue(objects[i]), objects[k]))
                                Labels[k] = -1;
                        }
                    }
                }
            }
            for (int i = 0; i < objects.Length; i++)
                if (Labels[i] > 0)
                    size++;
            object[] result = new object[size];
            int l = 0;
            for (int i = 0; i < objects.Length; i++)
            {
                if (Labels[i] == 1)
                {
                    result[l] = objects[i];
                    l++;
                }
            }
            return result;
        }
        
    }
}
