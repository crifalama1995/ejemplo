using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;

namespace safeSubirArchivo
{
    public partial class listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] files = Directory.GetFiles(@"C:\Users\cristian\Desktop\SAFE");
            DataTable table = new DataTable();
            table.Columns.Add("File Name");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);
            }

            gvArchivos.DataSource = table;
            gvArchivos.DataBind();
        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}