using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace safeSubirArchivo
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //llamaremos al metodo que realizará todo el proceso.
            try
            {
                GuardarArchivos();
                lblComprobar.Text = "Se ha guardado correctamente el archivo.";
            }
            catch (Exception ex)
            {

                lblComprobar.Text = ex.Message;
            }
        }

        private void GuardarArchivos()
        {
            //Declararemos la variable que usaremos.
            //string strRutaDestino = @"C:\Users\cristian\Documents";
            string strRutaDestino = @"C:\Users\cristian\Documents";
            string strRutaArchivo = string.Empty;
            string strRutaExtension = string.Empty;

            try
            {
                //validamos que exista nuestra rutaDestino.
                if (!Directory.Exists(strRutaDestino)) 
                {
                    Directory.CreateDirectory(strRutaDestino);
                }
            }
            catch (IOException ex)
            {

                throw new ArgumentException(ex.Message);
            }

            //si todo va bien hasta aqui es momentos de validar si se ha seleccionado un archivo
            if (fuArchivo.HasFile)
            {
                strRutaArchivo += fuArchivo.PostedFile;
                strRutaArchivo += "\\";
                strRutaArchivo += fuArchivo.FileName;

                //validamos que tenga la extension correcta
                strRutaExtension = Path.GetExtension(strRutaArchivo);

                if (strRutaExtension != ".xls" && strRutaExtension != ".xlsx")
                {
                    throw new ArgumentException("¡no es un tipo archivo excel!");
                }

                //Guardar el contenido de nuestro Upload.
                try
                {
                    fuArchivo.SaveAs(strRutaDestino + "\\" + fuArchivo.FileName);
                }
                catch (Exception ex)
                {

                    throw new ArgumentException(ex.Message);
                }
            }
            else
            {
                //en caso de que se de click y no tengamos archivo lanzar error.
                throw new ArgumentException("¡No se ha seleccionado ningun archivo!");
            }
        }
    }
}