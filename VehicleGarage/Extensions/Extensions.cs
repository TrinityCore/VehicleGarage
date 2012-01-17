using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace VehicleGarage.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Reads the NULL-terminated string from the current stream.
        /// </summary>
        /// <param name="reader">Stream to read from.</param>
        /// <returns>Resulting string.</returns>
        public static string ReadCString(this BinaryReader reader)
        {
            byte num;
            var temp = new List<byte>();

            while ((num = reader.ReadByte()) != 0)
            {
                temp.Add(num);
            }

            return Encoding.UTF8.GetString(temp.ToArray());
        }

        /// <summary>
        /// Reads the struct from the current stream.
        /// </summary>
        /// <typeparam name="T">Struct type.</typeparam>
        /// <param name="reader">Stream to read from.</param>
        /// <returns>Resulting struct.</returns>
        public static /*unsafe*/ T ReadStruct<T>(this BinaryReader reader) where T : struct
        {
            byte[] rawData = reader.ReadBytes(Marshal.SizeOf(typeof(T)));

            GCHandle handle = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            T returnObject = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));

            handle.Free();

            return returnObject;
        }

        public static void SetEnumValues<T>(this ComboBox cb, string NoValue)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");

            dt.Rows.Add(new Object[] { -1, NoValue });

            foreach (var str in Enum.GetValues(typeof(T)))
            {
                dt.Rows.Add(new Object[] { (int)str, "(" + ((int)str).ToString("000") + ") " + str });
            }

            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static void SetStructFields<T>(this ComboBox cb)
        {
            cb.Items.Clear();

            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(MemberInfo));
            dt.Columns.Add("NAME", typeof(String));

            var type = typeof(T).GetMembers();
            var i = 0;
            foreach (var str in type)
            {
                if (!(str is FieldInfo) && !(str is PropertyInfo)) 
                    continue;

                var dr = dt.NewRow();
                dr["ID"] = str;
                dr["NAME"] = String.Format("({0:000}) {1}", i, str.Name);
                dt.Rows.Add(dr);
                i++;
            }

            cb.DataSource = dt;
            cb.DisplayMember = "NAME";
            cb.ValueMember = "ID";
        }

        public static byte ToByte(this Object val)
        {
            if (val == null)
                return 0;

            byte num;
            byte.TryParse(val.ToString(), out num);
            return num;
        }

        public static uint ToUInt32(this Object val)
        {
            if (val == null)
                return 0;

            uint num;
            uint.TryParse(val.ToString(), out num);
            return num;
        }

        public static uint ToUInt32FromPossibleHexString(this Object val)
        {
            if (val.GetType() == typeof(String))
            {
                var newVal = ((String)val).Replace("0x", String.Empty);
                if (newVal.Equals(val))
                    return val.ToUInt32(); 
                    
                try
                {
                    return uint.Parse(newVal, System.Globalization.NumberStyles.AllowHexSpecifier);
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0u;
                }
            }

            return val.ToUInt32();
        }

        public static int ToInt32(this Object val)
        {
            if (val == null)
                return 0;

            int num;
            int.TryParse(val.ToString(), out num);
            return num;
        }

        public static float ToFloat(this Object val)
        {
            if (val == null)
                return 0.0f;

            float num;
            float.TryParse(val.ToString().Replace(',', '.'), out num);
            return num;
        }

        public static ulong ToUlong(this Object val)
        {
            if (val == null)
                return 0U;

            ulong num;
            ulong.TryParse(val.ToString(), out num);
            return num;
        }

        /// <summary>
        /// Compares the text on the partial occurrence of a string and ignore case
        /// </summary>
        /// <param name="text">The original text, which will search entry</param>
        /// <param name="compareText">String which will be matched with the original text</param>
        /// <returns>Boolean(true or false)</returns>
        public static bool ContainsText(this string text, string compareText)
        {
            return (text.ToUpper().IndexOf(compareText.ToUpper(), StringComparison.CurrentCultureIgnoreCase) != -1);
        }

        /// <summary>
        /// Compares the text on the partial occurrence of a string and ignore case
        /// </summary>
        /// <param name="text">The original text, which will search entry</param>
        /// <param name="compareText">Array strings which will be matched with the original text</param>
        /// <returns>Boolean(true or false)</returns>
        public static bool ContainsText(this string text, string[] compareText)
        {
            return compareText.Any(str => (text.IndexOf(str, StringComparison.CurrentCultureIgnoreCase) != -1));
        }
    }
}
